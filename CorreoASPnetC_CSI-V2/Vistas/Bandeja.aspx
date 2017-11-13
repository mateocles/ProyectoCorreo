<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bandeja.aspx.cs" Inherits="CorreoASPnetC_CSI_V2.Vistas.Bandeja" %>

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
    <title>Bandeja</title>
</head>
 <center>
        <body background= "/Css/2.jpg">
            <h1 class="bg-primary">Bandeja</h1>
    <form id="form1" runat="server">
  <table border="0" width="10" class="table" style="width:80%" cellspacing="1">
                    <thead>
                        <tr>
                            <th>IDENTIFICACION</th>
                               <td><asp:TextBox ID="TextIdRemitente"  size="50" runat="server"></asp:TextBox><asp:Button ID="BuscarPersonaRe"  class="btn btn-primary" runat="server" Text="Buscar" OnClick="BuscarPersonaRe_Click"></asp:Button>&nbsp;<asp:Label ID="LabelRemitente" class="label label-default" runat="server" Text=""></asp:Label></td>

                        </tr>
                    </thead>
                    <tbody>

                        <tr>
                            <th>MENSAJE</th>
                            <td><asp:GridView ID="GridView1" class="table table-striped" runat="server"  readonly="readonly" rows="5" cols="60"  style="margin: 0px; " Height="216px" Width="518px"></asp:GridView>
                         
                            </td>

                        </tr>
                    </tbody>
                </table>

            </form>  

                                <br>
            <input type="submit" value="Volver" class="btn btn-danger" onclick= "self.location.href = 'Mensaje.aspx'"   name="Mensaje" />

        </body></center>

</html>
