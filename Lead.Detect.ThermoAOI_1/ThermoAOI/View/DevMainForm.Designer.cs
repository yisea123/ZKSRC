﻿using Lead.Detect.DatabaseHelper;
using Lead.Detect.ThermoAOIProductLib.Thermo;

namespace Lead.Detect.ThermoAOI.Machine1.View
{
    partial class DevMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOpLvl = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSummry = new System.Windows.Forms.TabPage();
            this._thermoProductDisplayControl2 = new Lead.Detect.ThermoAOIProductLib.Thermo.ThermoProductDisplayControl();
            this._thermoProductDisplayControl1 = new Lead.Detect.ThermoAOIProductLib.Thermo.ThermoProductDisplayControl();
            this.labelRightFile = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeftFile = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.productDatabaseControl1 = new Lead.Detect.DatabaseHelper.ProductDatabaseControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLamp = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSummry.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbOpLvl);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 70);
            this.panel1.TabIndex = 9;
            // 
            // lbOpLvl
            // 
            this.lbOpLvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.lbOpLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOpLvl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbOpLvl.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOpLvl.ForeColor = System.Drawing.Color.Pink;
            this.lbOpLvl.Location = new System.Drawing.Point(685, 0);
            this.lbOpLvl.Name = "lbOpLvl";
            this.lbOpLvl.Size = new System.Drawing.Size(185, 70);
            this.lbOpLvl.TabIndex = 20;
            this.lbOpLvl.Text = "Operator";
            this.lbOpLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(870, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(69, 70);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfig.Location = new System.Drawing.Point(939, 0);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(69, 70);
            this.btnConfig.TabIndex = 18;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 70);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 659);
            this.splitContainer1.SplitterDistance = 919;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSummry);
            this.tabControl1.Controls.Add(this.tabResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSummry
            // 
            this.tabSummry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabSummry.Controls.Add(this._thermoProductDisplayControl2);
            this.tabSummry.Controls.Add(this._thermoProductDisplayControl1);
            this.tabSummry.Controls.Add(this.labelRightFile);
            this.tabSummry.Controls.Add(this.labelRight);
            this.tabSummry.Controls.Add(this.labelLeftFile);
            this.tabSummry.Controls.Add(this.labelLeft);
            this.tabSummry.Location = new System.Drawing.Point(4, 28);
            this.tabSummry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSummry.Name = "tabSummry";
            this.tabSummry.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSummry.Size = new System.Drawing.Size(911, 627);
            this.tabSummry.TabIndex = 0;
            this.tabSummry.Text = "生产概况";
            // 
            // _thermoProductDisplayControl2
            // 
            this._thermoProductDisplayControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._thermoProductDisplayControl2.Location = new System.Drawing.Point(451, 106);
            this._thermoProductDisplayControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._thermoProductDisplayControl2.Name = "_thermoProductDisplayControl2";
            this._thermoProductDisplayControl2.Size = new System.Drawing.Size(453, 511);
            this._thermoProductDisplayControl2.TabIndex = 8;
            // 
            // _thermoProductDisplayControl1
            // 
            this._thermoProductDisplayControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._thermoProductDisplayControl1.Location = new System.Drawing.Point(9, 106);
            this._thermoProductDisplayControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._thermoProductDisplayControl1.Name = "_thermoProductDisplayControl1";
            this._thermoProductDisplayControl1.Size = new System.Drawing.Size(434, 511);
            this._thermoProductDisplayControl1.TabIndex = 7;
            // 
            // labelRightFile
            // 
            this.labelRightFile.BackColor = System.Drawing.Color.Silver;
            this.labelRightFile.Location = new System.Drawing.Point(451, 58);
            this.labelRightFile.Name = "labelRightFile";
            this.labelRightFile.Size = new System.Drawing.Size(453, 41);
            this.labelRightFile.TabIndex = 6;
            this.labelRightFile.Text = "右工站";
            this.labelRightFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRight
            // 
            this.labelRight.BackColor = System.Drawing.Color.Silver;
            this.labelRight.Location = new System.Drawing.Point(451, 9);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(453, 41);
            this.labelRight.TabIndex = 6;
            this.labelRight.Text = "右工站";
            this.labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRight.DoubleClick += new System.EventHandler(this.labelRight_DoubleClick);
            // 
            // labelLeftFile
            // 
            this.labelLeftFile.BackColor = System.Drawing.Color.Silver;
            this.labelLeftFile.Location = new System.Drawing.Point(9, 58);
            this.labelLeftFile.Name = "labelLeftFile";
            this.labelLeftFile.Size = new System.Drawing.Size(434, 41);
            this.labelLeftFile.TabIndex = 6;
            this.labelLeftFile.Text = "左工站";
            this.labelLeftFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeft
            // 
            this.labelLeft.BackColor = System.Drawing.Color.Silver;
            this.labelLeft.Location = new System.Drawing.Point(9, 9);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(434, 41);
            this.labelLeft.TabIndex = 6;
            this.labelLeft.Text = "左工站";
            this.labelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeft.DoubleClick += new System.EventHandler(this.labelLeft_DoubleClick);
            // 
            // tabResult
            // 
            this.tabResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabResult.Controls.Add(this.productDatabaseControl1);
            this.tabResult.Location = new System.Drawing.Point(4, 28);
            this.tabResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResult.Size = new System.Drawing.Size(911, 627);
            this.tabResult.TabIndex = 1;
            this.tabResult.Text = "结果查询";
            // 
            // productDatabaseControl1
            // 
            this.productDatabaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatabaseControl1.BackColor = System.Drawing.Color.White;
            this.productDatabaseControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productDatabaseControl1.Location = new System.Drawing.Point(7, 7);
            this.productDatabaseControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productDatabaseControl1.Name = "productDatabaseControl1";
            this.productDatabaseControl1.Size = new System.Drawing.Size(897, 610);
            this.productDatabaseControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonLamp);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 659);
            this.panel2.TabIndex = 1;
            // 
            // buttonLamp
            // 
            this.buttonLamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonLamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLamp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLamp.FlatAppearance.BorderSize = 0;
            this.buttonLamp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLamp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLamp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLamp.Location = new System.Drawing.Point(0, 156);
            this.buttonLamp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLamp.Name = "buttonLamp";
            this.buttonLamp.Size = new System.Drawing.Size(86, 52);
            this.buttonLamp.TabIndex = 12;
            this.buttonLamp.Text = "日光灯";
            this.buttonLamp.UseVisualStyleBackColor = false;
            this.buttonLamp.Click += new System.EventHandler(this.buttonLamp_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(0, 104);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 52);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = " 停止";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(0, 52);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 52);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "复位";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 52);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "启动";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(225, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 70);
            this.label1.TabIndex = 21;
            this.label1.Text = "高度通用量测";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DevMainForm";
            this.TabText = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DevMainForm_FormClosed);
            this.Load += new System.EventHandler(this.DevMainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSummry.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSummry;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lbOpLvl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonLamp;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelRightFile;
        private System.Windows.Forms.Label labelLeftFile;
        private ThermoProductDisplayControl _thermoProductDisplayControl1;
        private ThermoProductDisplayControl _thermoProductDisplayControl2;
        private ProductDatabaseControl productDatabaseControl1;
        private System.Windows.Forms.Label label1;
    }
}