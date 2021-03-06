﻿using System;
using Lead.Detect.FrameworkExtension;
using Lead.Detect.FrameworkExtension.frameworkManage;
using Lead.Detect.FrameworkExtension.stateMachine;
using Lead.Detect.FrameworkExtension.motionDriver;
using Lead.Detect.FrameworkExtension.elementExtensionInterfaces;
using System.Windows.Forms;

namespace Lead.Detect.ThermoAOI2.MachineA.UserDefine
{
    /// <summary>
    /// 设备定义
    /// </summary>
    public class Machine : StateMachine
    {
        private Machine()
        {
        }

        public static Machine Ins { get; } = new Machine();

        /// <summary>
        /// 设备配置
        /// </summary>
        public MachineSettings Settings { get; set; }

        public override void Load()
        {
            //load all settings!!!
            Settings = MachineSettings.Load();
            if (Settings == null)
            {
                throw new Exception("Load MachineSettings Fail!");
            }


            //import machine objects
            if (FrameworkExtenion.IsSimulate)
            {
                Import(@".\Config\machinesim.cfg");
            }
            else
            {
                Import(@".\Config\machine.cfg");
            }

            //load platform positions
            foreach (var p in Platforms)
            {
                p.Value.Load();
            }
        }


        /// <summary>
        /// 保存配置文件
        /// </summary>
        public override void Save()
        {
            //save platform positions
            foreach (var p in Platforms.Values)
            {
                p.Save();
            }

            //save the machine settings
            Settings.Save();

            //export machine objects
            if (FrameworkExtenion.IsSimulate)
            {
                Export(@".\Config\machinesim.cfg");
            }
            else
            {
                Export(@".\Config\machine.cfg");
            }
        }


        public override void Initialize()
        {
            try
            {
                //初始化驱动
                Find<MotionCardWrapper>("M1").Init(string.Empty);
                Find<MotionCardWrapper>("IO1").Init(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化控制卡失败:{ex.Message}");
                throw ex;
            }

            //初始化关键io
            Find<IDoEx>("DOLamp")?.SetDo(true);
            Find<IDoEx>("DOVaccum1")?.SetDo(false);
            Find<IDoEx>("DOVaccum2")?.SetDo(false);

            //启动 main thread
            base.Initialize();
        }


        /// <summary>
        /// 终止程序，终止main线程
        /// </summary>
        public override void Terminate()
        {
            //终止 main thread
            base.Terminate();

            //终止关键io
        

            Find<IDoEx>("DOLamp")?.SetDo(false);
            Find<IDoEx>("DOVaccum1")?.SetDo(false);
            Find<IDoEx>("DOVaccum2")?.SetDo(false);

            //终止驱动
            Find<MotionCardWrapper>("M1").Uninit();
            Find<MotionCardWrapper>("IO1").Uninit();
        }


    }
}
