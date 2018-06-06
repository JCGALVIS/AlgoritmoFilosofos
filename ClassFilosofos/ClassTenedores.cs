using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFilosofos
{
    public class ClassTenedores
    {
        bool[] cantidadDeTenedores = new bool[int.Parse(ConfigurationManager.AppSettings["NumeroDeFilosofos"])];

        public void obtenerTenedores(int tenedorIzquierda, int tenedorDerecha)
        {

        }
    }
}
