using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    class Case
    {
        private Point point;
        private int typeID;
        public enum type
        {
            vide = 0,
            hutte = 1,
            temple = 2
        }
        public Case(Point p)
        {
            this.point = p;
            this.typeID = (int)type.vide; // = 0
        }

        internal Point Point { get => point; set => point = value; }
    }
}
