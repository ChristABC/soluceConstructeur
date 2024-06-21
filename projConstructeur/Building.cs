using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projConstructeur
{
    internal class Building
    {
        private int _floors;
        private double _height;

        // Constructeur qui initialise le bâtiment avec le nombre d'étages et la hauteur
        public Building(int floors, double height)
        {
            this._floors = floors;
            this._height = height;
        }
        public Building(int floors) 
        {
            this._floors = floors;
            this._height=3*this._floors;

        }

        public int Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }

        public double Size
        {
            get { return _height; }
            set { _height = value; }
        }
        public int GetFloorMaxSize()
        {
            return (int)(_height/_floors);
        }

        public double Height()
        {
            return _height;
        }
    }
}