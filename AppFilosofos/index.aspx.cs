using ClaseFilosofos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
        }
    }

    private void procesoInicial(object sender, EventArgs e) {
        //Una sóla instancia del recurso compartido
        //	que se comparte entre los procesos
        Tenedores tenedores = new Tenedores();


        ////Se crean las instancias de los filosofos
        Filosofos filosofoCero = new Filosofos(0, tenedores, evento_CambioEstado);
        Filosofos filosofoUno = new Filosofos(1, tenedores, evento_CambioEstado);
        Filosofos filosofoDos = new Filosofos(2, tenedores, evento_CambioEstado);
        Filosofos filosofoTres = new Filosofos(3, tenedores, evento_CambioEstado);
        Filosofos filosofoCuatro = new Filosofos(4, tenedores, evento_CambioEstado);
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
        switch (proceso.IdProceso)
        {
            case 0:
                txtEstadoViejo.Text = proceso.EstadoEnEjecucion.ToString();
                break;
            case 1:
                txtEstadoLemus.Text = proceso.EstadoEnEjecucion.ToString();
                break;
            case 2:
                txtEstadoPepe.Text = proceso.EstadoEnEjecucion.ToString();
                break;
            case 3:
                txtEstadoHugo.Text = proceso.EstadoEnEjecucion.ToString();
                break;
            case 4:
                txtestadoArturo.Text = proceso.EstadoEnEjecucion.ToString();
                break;
            default:
                break;
        }
    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        //Una sóla instancia del recurso compartido
        //	que se comparte entre los procesos
        Tenedores tenedores = new Tenedores();


        ////Se crean las instancias de los filosofos
        Filosofos filosofoCero = new Filosofos(0, tenedores, evento_CambioEstado);
        Filosofos filosofoUno = new Filosofos(1, tenedores, evento_CambioEstado);
        Filosofos filosofoDos = new Filosofos(2, tenedores, evento_CambioEstado);
        Filosofos filosofoTres = new Filosofos(3, tenedores, evento_CambioEstado);
        Filosofos filosofoCuatro = new Filosofos(4, tenedores, evento_CambioEstado);
    }
}