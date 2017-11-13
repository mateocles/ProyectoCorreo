using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogicaModelo;
namespace CorreoASPnetC_CSI_V2.Interfaces
{
    interface IPersona
    {
        bool Agregar_persona(string Cedulo, string Nombre, string Apellido, string NombreUsuario, string ContraseñaUsuario);
        DataTable Consultar_Persona(Persona objeto);
        DataTable Consultar_NombreUsuario(string NombreUsuario);

        bool Editar_Persona(string Cedula, string Nombre, string Apellido);

        DataTable Consultarid(string Cedula);


    }
}
