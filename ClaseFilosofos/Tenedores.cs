using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseFilosofos
{
    public class Tenedores
    {
        bool[] cantidadDeTenedores = new bool[int.Parse(ConfigurationManager.AppSettings["NumeroDeFilosofos"])];

        public void obtenerTenedores(int tenedorIzquierda, int tenedorDerecha)
        {
            //El siguiente bloque de instrucciones, ser marca como una sección crítica (acceso a recurso compartido), 
            //	utilizando el bloqueo de exclusión mutua (sentencia 'lock'). El bloque se libera cuando finaliza su ejecución.
            //Si otro subproceso intenta acceder, esperará hasta que el objeto se libere (sincronización)
            lock (this)
            {
                //Espera a que los 2 tenedores estén libres (ambos igual a false)
                while (cantidadDeTenedores[tenedorIzquierda] || cantidadDeTenedores[tenedorDerecha])
                  Monitor.Wait(this);

                //Asigna true para especificar que el recurso está ocupado
                cantidadDeTenedores[tenedorIzquierda] = true;
                cantidadDeTenedores[tenedorDerecha] = true;
            }
        }

        public void liberarTenedor(int tenedorIzquierda, int tenedorDerecha)
        {
            lock (this)
            {
                //Asigna false para especificar que el recurso está liberado
                cantidadDeTenedores[tenedorIzquierda] = false;
                cantidadDeTenedores[tenedorDerecha] = false;
                //Avisa a los demás procesos el cambio de estatus del recurso compartido
                Monitor.PulseAll(this);
            }
        }
    }
}
