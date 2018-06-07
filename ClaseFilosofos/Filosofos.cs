using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseFilosofos
{
    public class Filosofos
    {
        int tenedorIzquierda;
        int tenedorDerecha;
        int idDelProceso;

        Tenedores tenedores;

        internal event EventHandler ManejadorEstado;
        public enum Estado { Pensando, Esperando, Comiendo };


        public Filosofos(int idDelProceso, Tenedores tenedores, EventHandler manejadorEstado)
        {
            int numFilosofos = int.Parse(ConfigurationManager.AppSettings["NumeroDeFilosofos"]);

            this.tenedores = tenedores;
            this.idDelProceso = idDelProceso;
            ManejadorEstado = manejadorEstado;
            tenedorIzquierda = idDelProceso == 0 ? numFilosofos - 1 : idDelProceso - 1;
            tenedorDerecha = idDelProceso;

            //Inicia la ejecucion del proceso en un hilo independiente
            Thread proceso = new Thread(new ThreadStart(Iniciar));

            proceso.Start();
        }

        public void Iniciar()
        {
            Random aleatorio = new Random();
            int tiempoMaxPensar = int.Parse(ConfigurationManager.AppSettings["TiempoMaximoSegundoPensar"]) * 1000;
            int tiempoMaxComer = int.Parse(ConfigurationManager.AppSettings["TiempoMaximoSegundoComer"]) * 1000;
            int tiempo = 0;

            while (true)
            {
                //Notifica que el filósofo cambio su estado a: Pensando
                if (ManejadorEstado != null)
                    ManejadorEstado(new Argumentos() { EstadoEnEjecucion = Estado.Pensando, IdProceso = idDelProceso }, new EventArgs());

                //Espera un tiempo aleatorio
                tiempo = aleatorio.Next(1000, tiempoMaxPensar);
                Thread.Sleep(tiempo);

                //Notifica que el filósofo cambio su estado a: Esperando
                if (ManejadorEstado != null)
                    ManejadorEstado(new Argumentos() { EstadoEnEjecucion = Estado.Esperando, IdProceso = idDelProceso }, new EventArgs());

                //Intenta obtener el recurso compartido,
                //	si ya está ocupado, espera a que el recurso se libere
                tenedores.obtenerTenedores(tenedorIzquierda, tenedorDerecha);

                //Notifica que el filósofo cambio su estado a: Comiendo
                if (ManejadorEstado != null)
                    ManejadorEstado(new Argumentos() { EstadoEnEjecucion = Estado.Comiendo, IdProceso = idDelProceso }, new EventArgs());

                //Espera un tiempo aleatorio
                tiempo = aleatorio.Next(1000, tiempoMaxComer);
                Thread.Sleep(tiempo);
                //Libera el recurso compartido
                tenedores.liberarTenedor(tenedorIzquierda, tenedorDerecha);
            }
        }
    }
}
