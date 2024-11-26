<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reparaciones.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.Reparaciones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Electronica</title>
    <style>
        /* Estilo general para el cuerpo */
        body {
            font-family: Arial, sans-serif;
            background-image: url('https://www.example.com/fondo.jpg'); /* Cambia esta URL por tu imagen de fondo */
            background-size: cover;
            background-position: center;
            margin: 0;
            padding: 0;
            color: #333;
            text-align: center;
        }

        /* Estilo para el contenedor principal */
        .form-container {
            background-color: rgba(255, 255, 255, 0.9); /* Fondo blanco con opacidad */
            width: 70%;
            margin: 30px auto;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        /* Estilo para los encabezados */
        h2 {
            color: #2f4f4f;
            font-size: 1.8em;
            margin-bottom: 20px;
        }

        /* Estilo para los campos de texto */
        .form-input {
            width: 100%;
            max-width: 300px;
            padding: 10px;
            margin: 10px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
            font-size: 16px;
            box-sizing: border-box;
        }

        /* Estilo para los botones */
        .form-button {
            padding: 10px 20px;
            margin: 10px 5px;
            border: none;
            border-radius: 5px;
            background-color: #4CAF50; /* Verde */
            color: white;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-button:hover {
            background-color: #45a049; /* Verde más oscuro al pasar el ratón */
        }

        /* Estilo para la tabla GridView */
        .grid-view {
            width: 100%;
            margin-top: 30px;
            border-collapse: collapse;
        }

        .grid-view th, .grid-view td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
        }

        .grid-view th {
            background-color: #4CAF50; /* Color de fondo de los encabezados de la tabla */
            color: white;
        }

        .grid-view tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .grid-view tr:hover {
            background-color: #ddd;
        }

        /* Estilo para el texto de error o éxito */
        .message {
            margin-top: 20px;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border-radius: 5px;
            display: none; /* Inicialmente oculto */
        }

        .message.error {
            background-color: #f44336; /* Rojo para los errores */
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Pagina de Reparaciones</h2>

            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view"></asp:GridView>

            <div>
                <label for="tEquipoID">EquipoID</label>
                <asp:TextBox ID="tEquipoID" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tFechaSolicitud">Fecha Solicitud</label>
                <asp:TextBox ID="tFechaSolicitud" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tEstado">Estado</label>
                <asp:TextBox ID="tEstado" runat="server" CssClass="form-input"></asp:TextBox>

                <div>
                    <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="form-button" />
                    <asp:Button ID="Borrar" runat="server" Text="Borrar" CssClass="form-button" />
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="form-button" />
                </div>
            </div>

            <!-- Mensajes de éxito o error -->
            <div id="messageBox" class="message"></div>
        </div>
    </form>
</body>
</html>
