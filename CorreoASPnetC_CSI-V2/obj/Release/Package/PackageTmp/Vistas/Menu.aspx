<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CorreoaspC_CSI.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background= "/Css/2.jpg">
 
       <center>   <h1 class="bg-primary" class="whitetext">Menu</h1>
               
        <a href="DatosPersonales.aspx"> <img src="../Css/imageusu.png" alt=""  width="250" height="250"  /></a>
        <br>
        <label>Ingresar un Usuario</label>
        <br>
        <a href="Mensaje.aspx">  <img src="../Css/MetroUI_Mail.png" alt=""  width="250" height="250" alt=""/></a>
        <br>
        <label>Enviar un Correo</label>
    </center>
   
    
    &nbsp;&nbsp;&nbsp;&nbsp;
    <input type="submit" value="Cerrar Sesion" class="btn btn-danger" onclick= "self.location.href = 'login.aspx'"/>

  
</body>
</html>
