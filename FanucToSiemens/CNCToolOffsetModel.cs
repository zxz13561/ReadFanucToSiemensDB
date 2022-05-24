using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucToSiemens
{
    public class CNCToolOffsetModel
    {
        public double T_NO { get; set; }

        public double X_Wear  { get; set; }

        public double Z_Wear  { get; set; }

        public double R_Wear  { get; set; }

        public double X_Geom  { get; set; }

        public double Z_Geom  { get; set; }

        public double R_Geom  { get; set; }

        public double Tip { get; set; }
    }
}
