using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2021
{
    class Tablettenform : Medikamentenform
    {
        private double pulverKoemungInUm;

        public double PulverKoemungInUm
        {
            get { return pulverKoemungInUm; }
            set { pulverKoemungInUm = value; }
        }

        public Tablettenform(double pulverKoemungInUm, double gewichtInG, double laengeInMm, double breiteInMm, long id)
            :base( gewichtInG,  laengeInMm,  breiteInMm,  id)
        {
            this.pulverKoemungInUm = pulverKoemungInUm;
        }
        
        public override string wirkstofffreisetzung()
        {
            return "Freisetzung des Wirkstoffes durch Zersetzung der Tablette. " +
                "Pulverkoernung in Mikrometer: " + this.pulverKoemungInUm;
        }

       

    }
}
