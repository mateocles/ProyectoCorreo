using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CorreoASPnetC_CSI_V2.Interfaces
{
    interface IMensaje
    {
       bool EnviarMensaje();
        DataTable consultarBandeja(string Destinatario);
        DataTable consultarEnviados(string Remitente);
        List<DataRow> buscarBandeja(string Destinario);
    }
}
