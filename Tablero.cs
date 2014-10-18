using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
  

    class Tablero
    {
        public static Tablero Instance;
        public int DimensionX = 8;
        public int DimensionY = 8;
        public Celda[,] TableroCelda;

        public Tablero(int dimensionX, int dimensionY)
        {
            Instance = this;
            this.DimensionX = dimensionX;
            this.DimensionY = dimensionY;
            TableroCelda = new Celda[DimensionX, DimensionY];

        }

        public Tablero()
        {
            Instance = this;
            TableroCelda = new Celda[DimensionX, DimensionY];
        }




    }
}
