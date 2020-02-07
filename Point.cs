using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExtraProbs
{
    class Point
    {
        #region fields
        private int x;
        private int y;

        #endregion fields

        #region properties
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        #endregion properties

        #region constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion constructor

        #region methods
        public override string ToString()
        {
            return $"\nYou have created a point object ({x},{y}).";
        }
        #endregion methods
    }
}
