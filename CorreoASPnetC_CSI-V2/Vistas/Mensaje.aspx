<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="CorreoASPnetC_CSI_V2.Vistas.Mensaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script> 
        
        <link href="Css/estilos_1_1.css" rel="stylesheet" />
        <style>
            textarea {
                resize: vertical;
                
            }
        </style>
    <title>Mensaje</title>
</head>
<body background= "/Css/2.jpg"><center>
     <h1 class="bg-primary">Mensaje</h1>
    <form id="form1" runat="server">
   
      
        

            <table border="0" width="10" class="table" style="width:40%" cellspacing="1">
                <thead>
                    <tr>
                        <th>IDENTIFICACION REMITENTE</th>
                        <td><asp:TextBox ID="TextIdRemitente"  size="50" runat="server"></asp:TextBox><asp:Button ID="BuscarPersonaRe"  class="btn btn-primary" runat="server" Text="Buscar" OnClick="BuscarPersonaRe_Click"></asp:Button>&nbsp;<asp:Label ID="LabelRemitente" class="label label-default" runat="server" Text=""></asp:Label></td>


                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th>IDENTIFICACION DESTINATARIO</th>
                        <td><asp:TextBox ID="TextIdDestinatario" runat="server" size="50"></asp:TextBox><asp:Button ID="BuscarPersona"  class="btn btn-primary" runat="server" Text="Buscar" OnClick="BuscarPersona_Click"></asp:Button>
                         &nbsp;<asp:Label ID="LabelNombreDestini" class="label label-default" runat="server" Text=""></asp:Label></td>

                    </tr>


                    <tr>
                        <th>MENSAJE</th>
                 <td><textarea id="Mensajecuerpo" type="text" runat="server" rows="2" cols="20" style="margin: 0px; width: 765px; height: 272px;"></textarea></td>

                    </tr>

                </tbody>
            </table>

<asp:Button ID="EnviarMensaje" runat="server" class="btn btn-success" Text="Enviar Mensaje" OnClick="EnviarMensaje_Click"></asp:Button>
          
        <br>
      
        <br>
<asp:Button ID="MensajesEnviados" runat="server" class="btn btn-primary" Text="Mensajes enviados" OnClick="MensajesEnviados_Click"></asp:Button>
<asp:Button ID="Bandeja" runat="server" class="btn btn-primary" Text="Bandeja" OnClick="Bandeja_Click"></asp:Button>
<asp:Button ID="Volver" runat="server" class="btn btn-danger" Text="Volver" OnClick="Volver_Click"></asp:Button>

   
    </form>
</body></center>
</html>
