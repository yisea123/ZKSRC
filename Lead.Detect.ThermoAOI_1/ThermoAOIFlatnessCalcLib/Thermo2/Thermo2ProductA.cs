﻿using System.Collections.Generic;
using System.Data;
using System.Text;
using Lead.Detect.ThermoAOIProductLib.Thermo;

namespace Lead.Detect.ThermoAOIProductLib.Thermo2
{
    public class Thermo2ProductA : ThermoProduct
    {
        public List<double> RawData { get; set; } = new List<double>();


        public override string CsvHeaders()
        {
            var sb = new StringBuilder();

            sb.Append(base.CsvHeaders());

            sb.Append("CAMERA,");
            for (int i = 0; i < RawData.Count; i++)
            {
                sb.Append($"RawData{i},");
            }
            return sb.ToString();
        }

        public override string CsvValues()
        {
            var sb = new StringBuilder();

            sb.Append(base.CsvValues());

            sb.Append("CAMERA,");
            for (int i = 0; i < RawData.Count; i++)
            {
                sb.Append(RawData[i].ToString("F3"));
                sb.Append(',');
            }

            return sb.ToString();
        }


        public override DataTable ToDataTable()
        {
            var dt = base.ToDataTable();

            for (int i = 0; i < RawData.Count; i++)
            {
                var row = dt.Rows.Add();
                row[0] = $"Raw{i}";
                row[1] = RawData[i].ToString("F3");
            }

            return dt;

        }
    }
}