using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Funciones
    {
        public string GetUserName()
        {
            //return "SQLConnection Select Nombre From Users where Email = email";
            return "bienvenido profe";
        }
        public int[] GetWelcomePosition(int WindowSize1,int WindowSize2)
        {
            int[] Posicion = { WindowSize1/2, WindowSize2/2 };

            return Posicion;

        }
    }

}
