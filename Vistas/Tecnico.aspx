<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tecnico.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.Tecnico" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Electronica</title>
    <style type="text/css">
        /* Estilo general para la página */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            color: #333;
        }

        /* Estilo para el encabezado */
        h1 {
            background-color: forestgreen;
            color: white;
            padding: 20px;
            text-align: center;
            margin: 0;
            font-size: 2.5em;
        }

        h2 {
            color: #444;
            text-align: center;
            font-size: 1.5em;
            margin-top: 10px;
        }

        /* Estilo para los campos de texto */
        .form-input {
            width: 250px;
            padding: 10px;
            margin: 10px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
            font-size: 16px;
        }

        /* Estilo para los botones */
        .form-button {
            padding: 10px 20px;
            margin: 10px 5px;
            border: none;
            border-radius: 5px;
            background-color: forestgreen;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }

        .form-button:hover {
            background-color: darkgreen;
        }

        /* Estilo para el contenedor del formulario */
        .form-container {
            width: 80%;
            max-width: 600px;
            margin: 20px auto;
            padding: 20px;
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        /* Estilo para el GridView */
        .grid-view {
            width: 100%;
            margin: 20px 0;
            border-collapse: collapse;
        }

        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }

        .grid-view th {
            background-color: #f4f4f4;
        }

        .grid-view tr:hover {
            background-color: #f9f9f9;
        }

        /* Estilo para la imagen */
        .auto-style2 {
            width: 84%;
            max-width: 600px;
            margin: 20px auto;
            display: block;
            border-radius: 10px;
            height: 347px;
        }

        /* Estilo para las etiquetas */
        .form-label {
            font-weight: bold;
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>SistemaMantenimiento</h1>
            <h2>Pagina de Tecnico</h2>

            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view"></asp:GridView>

            <div>
                <div class="form-label">TecnicoID</div>
                <asp:TextBox ID="tcodigoTecnico" runat="server" CssClass="form-input"></asp:TextBox>

                <div class="form-label">NombreTecnico</div>
                <asp:TextBox ID="tNombreTecnico" runat="server" CssClass="form-input"></asp:TextBox>

                <div class="form-label">Especialidad</div>
                <asp:TextBox ID="tEspecialidad" runat="server" CssClass="form-input"></asp:TextBox>

                <div>
                    <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="form-button" OnClick="Agregar_Click" />
                    <asp:Button ID="Borrar" runat="server" Text="Borrar" CssClass="form-button" OnClick="Borrar_Click" />
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="form-button" OnClick="Modificar_Click" />
                </div>
            </div>
        </div>
    </form>

    <p>
        <img src="../OIP.jpg" class="auto-style2" />
    </p>
</body>
</html>
