using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projConstructeur
{
    public class Building
    {
        double floors;// Le choix du type double vient que plus loin, il va falloir vers un rapport
        double height;

        // Constructeur qui initialise le bâtiment avec le nombre d'étages et la hauteur
        public Building(double floors, double height)
                {
                    this.floors = floors;
                    this.height = height;
                }
        public Building(double floors)  : this(floors,3*floors)
                {
                }

        public double GetFloorCount()
                {
                    return floors;
                }

        
         public double GetFloorMaxSize()
            {
            return height / floors;
        }

        public double GetSize()
        {
            return height;
        }
    }
}