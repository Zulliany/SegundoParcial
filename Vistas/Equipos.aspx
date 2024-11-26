<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.Equipos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Electronica</title>
    <style type="text/css">
        /* Estilos generales para el cuerpo */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4; /* Fondo gris claro */
            margin: 0;
            padding: 0;
            color: #333;
            text-align: center;
        }

        /* Contenedor principal para el formulario */
        .form-container {
            background-color: white;
            width: 80%;
            max-width: 900px;
            margin: 30px auto;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        /* Estilo para el título de la página */
        h1 {
            background-color: deepskyblue;
            color: white;
            padding: 20px;
            text-align: center;
            margin-top: 0;
            font-size: 2.5em;
            border-radius: 10px;
        }

        /* Estilo para la imagen */
        .auto-style1 {
            width: 100%;
            max-width: 315px;
            height: 216px;
            margin: 20px 0 20px 0px;
        }

        /* Estilo para los campos de entrada */
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

        /* Estilo para las etiquetas de los campos de texto */
        .form-label {
            font-weight: bold;
            color: #444;
            margin-top: 10px;
        }

        /* Estilo para los botones */
        .form-button {
            padding: 10px 20px;
            margin: 10px 5px;
            border: none;
            border-radius: 5px;
            background-color: #4CAF50;
            color: white;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-button:hover {
            background-color: #45a049; /* Verde más oscuro al pasar el ratón */
        }

        /* Estilo para el GridView */
        .grid-view {
            width: 100%;
            margin-top: 20px;
            border-collapse: collapse;
        }

        .gridview th, .grid-view td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
        }

        .grid-view th {
            background-color: #4CAF50;
            color: white;
        }

        .grid-view tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .grid-view tr:hover {
            background-color: #ddd;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <img src="../servicio-tecnico.jpg" class="auto-style1" alt="Imagen Servicio Técnico" />

            <h1>Pagina de Equipos</h1>

            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1"></asp:GridView>

            <div>
                <label for="tTipoEquipo" class="form-label">TipoEquipo</label>
                <asp:TextBox ID="tTipoEquipo" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tModelo" class="form-label">Modelo</label>
                <asp:TextBox ID="tModelo" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tUsuarioID" class="form-label">UsuarioID</label>
                <asp:TextBox ID="tUsuarioID" runat="server" CssClass="form-input"></asp:TextBox>

                <div>
                    <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="form-button" OnClick="Agregar_Click1" />
                    <asp:Button ID="Borrar" runat="server" Text="Borrar" CssClass="form-button" />
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="form-button" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>


        