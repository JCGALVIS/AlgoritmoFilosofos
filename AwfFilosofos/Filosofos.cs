using ClaseFilosofos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwfFilosofos
{
    public partial class Filosofos : Form
    {
        private volatile bool cerrando = false;
        public Filosofos()
        {
            InitializeComponent();
        }

        private void evento_CambioEstado(object sender, EventArgs e)
        {
            ClaseFilosofos.Argumentos proceso = (ClaseFilosofos.Argumentos)sender;

            //Escribe en la consola para identificar al proceso y su estado
            //consola.Items.Add("Filosofo " + proceso.IdProceso + ": " + proceso.Estado);
            //Actualiza el gráfico del estado del proceso
            EstablecerEstado(proceso);
        }

        /// <summary>
        /// Actualiza el gráfico de estado de un proceso: Pensando (VERDE), Esperando (AMARILLO), Comiendo (ROJO)
        /// </summary>
        /// <param name="proceso">Clase que identifica al proceso que lanza el evento para notificar su cambio de estado</param>
        public void EstablecerEstado(ClaseFilosofos.Argumentos proceso)
        {
            if (!cerrando)
            {
                this.Invoke((MethodInvoker)delegate
                {

                    switch (proceso.IdProceso)
                    {
                        case 0:
                            lblFilosofo1.Text = proceso.EstadoEnEjecucion.ToString();
                            break;
                        case 1:
                            lblFilosofo2.Text = proceso.EstadoEnEjecucion.ToString();
                            break;
                        case 2:
                            lblFilosofo3.Text = proceso.EstadoEnEjecucion.ToString();
                            break;
                        case 3:
                            lblFolosofo4.Text = proceso.EstadoEnEjecucion.ToString();
                            break;
                        case 4:
                            lblFilosofo5.Text = proceso.EstadoEnEjecucion.ToString();
                            break;
                        default:
                            break;
                    }
                });
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Una sóla instancia del recurso compartido
            //	que se comparte entre los procesos
            Tenedores tenedores = new Tenedores();


            ////Se crean las instancias de los filosofos
            ClaseFilosofos.Filosofos filosofoCero = new ClaseFilosofos.Filosofos(0, tenedores, evento_CambioEstado);
            ClaseFilosofos.Filosofos filosofoUno = new ClaseFilosofos.Filosofos(1, tenedores, evento_CambioEstado);
            ClaseFilosofos.Filosofos filosofoDos = new ClaseFilosofos.Filosofos(2, tenedores, evento_CambioEstado);
            ClaseFilosofos.Filosofos filosofoTres = new ClaseFilosofos.Filosofos(3, tenedores, evento_CambioEstado);
            ClaseFilosofos.Filosofos filosofoCuatro = new ClaseFilosofos.Filosofos(4, tenedores, evento_CambioEstado);
        }

        private void Filosofos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cerrando = true;
        }
    }
}
