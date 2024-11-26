<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.Asignaciones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Electronica</title>
    <style type="text/css">
        /* Estilos generales para el cuerpo */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9; /* Fondo suave */
            margin: 0;
            padding: 0;
            color: #333;
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

        /* Estilo para el encabezado */
        h1 {
            background-color: violet;
            color: white;
            padding: 20px;
            text-align: center;
            margin-top: 0;
            font-size: 2.5em;
            border-radius: 10px;
        }

        /* Estilo para los encabezados secundarios */
        h2 {
            text-align: center;
            color: #555;
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

        /* Estilo para las etiquetas de los campos de texto */
        .form-label {
            font-weight: bold;
            color: #444;
            margin-top: 10px;
            display: inline-block;
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

        .grid-view th, .grid-view td {
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
            <h1>Sistema Mantenimiento</h1>
            <h2>Pagina de Asignaciones</h2>
            
            <!-- GridView para mostrar las asignaciones -->
            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view"></asp:GridView>
            
            <!-- Campos de entrada para asignación -->
            <div>
                <label for="tReparacionID" class="form-label">ReparacionID</label>
                <asp:TextBox ID="tReparacionID" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tTecnicoID" class="form-label">TecnicoID</label>
                <asp:TextBox ID="tTecnicoID" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tFechaAsignacion" class="form-label">Fecha Asignacion</label>
                <asp:TextBox ID="tFechaAsignacion" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tFechaFinal" class="form-label">Fecha Final</label>
                <asp:TextBox ID="tFechaFinal" runat="server" CssClass="form-input"></asp:TextBox>
                
                <!-- Botones para agregar, borrar y modificar -->
                <div>
                    <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="form-button" />
                    <asp:Button ID="Borrar" runat="server" Text="Borrar" CssClass="form-button" />
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="form-button" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

