using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUCE_DALTUDXD_68TH1_0298968.Model
{
    public class BeamModel
    {
        public string Mark { get; set; }  ///Mã hiệu Dầm
        public double  Lx{ get; set; }
        public double Ly { get; set; }
        public double h { get; set; }
        public double bf { get; set; } // Chiều rộng của dầm
        public double tf { get; set; }
        public double hw { get; set; }
        public double tw { get; set; }
        public double M { get; set; }
        public double Q { get; set; }
        public MaterialModel Material { get; set; } //Vật liệu của dầm  - quan hệ 1-1 (1 dầm chỉ có 1 vật liệu)

        public double As { get; set; }
        public double lo { get; set; }
        public double xichma { get; set; }
        public double to { get; set; }
        public double ungsuat_td { get; set; }
        public double KiemTraBen { get; set; }
    }
}
