<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCard.aspx.cs" Inherits="BilleteraVirtual.Views.AddCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />

    <link href="../Style/StyleAddCard.css" rel="stylesheet"/>

    <title>Add Credit Card To The Virtual Wallet</title>

</head>

<body>
    <form id="form1" runat="server">
            
         <%--OFFCANVA--%>

        <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Billetera Virtual</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarColor01">
                    <ul class="navbar-nav me-auto">
                        <li class="nav-item">
                            <a class="nav-link active" href="Inicio.aspx">Home
                                 <span class="visually-hidden">(current)</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <%--OFFCANVA--%>

        <%--Agregar Tarjeta--%>

        <div class="card text-white bg-primary mb-3 mx-auto" style="max-width: 80rem;">
            <div class="card-header">Billetera Virtual</div>
            <div class="card-body">
                <h4 class="card-title">Enter a new payment method</h4>

                <fieldset>
                    <div class="form-group">
                        <label for="SelectBanco" class="form-label mt-4">Select your bank</label>
                        <select class="form-select" id="SelectBanco" runat="server">
                            <option>Banco Nacional de Costa Rica</option>
                            <option>Banco de Costa Rica</option>
                            <option>Banco Popular</option>
                            <option>ScotiaBank</option>
                            <option>BAC Credomatic</option>
                        </select>
                    </div>

                    <div class="form-group">
                        <label for="SelectEntidad" class="form-label mt-4">Select your issuing entity</label>
                        <select class="form-select" id="SelectEmisor" runat="server">
                            <option>Master Card</option>
                            <option>Visa</option>
                        </select>
                    </div>

                    <div class="form-group">
                        <label for="inputCVV" class="form-label mt-4">CVV</label>
                        <input runat="server" type="password" class="form-control" id="inputCodigoCVV" placeholder="CVV" maxlength="3" pattern="[0-9]{3}" title="Debe ingresar solo 3 números sin espacios" required/>
                    </div>

                    <div class="form-group">
                        <label for="inputDueno" class="form-label mt-4">Dueño de la Tarjeta:</label>
                        <input runat="server" type="text" class="form-control" placeholder="Escriba el nombre de propietario" id="inputDueno"/>
                    </div>

                    <div class="form-group">
                        <label for="inputNTarjeta" class="form-label mt-4">Numero de la tarjeta:</label>
                        <input runat="server" type="text" class="form-control" placeholder="**** **** **** ****" id="inputNumeroTarjeta" pattern="[0-9]{16}" title="Maximum of 16 numbers" maxlength="16" required/>
                    </div>

                    <div class="form-group">
                        <label for="inputExp" class="form-label mt-4">Fecha de Expiración:</label>
                        <input runat="server" type="date" class="form-control" placeholder="00/00/00" id="inputFechaExpiracion"/>
                    </div>

                    <div class="text-center">
                        <asp:Button runat="server" Text="Guardar" CssClass="btn btn-info btn-sm"
                            Style="background-color: white; color: black; border-color: white"
                            OnClick="btnSave_OnClick" />
                        <asp:Label runat="server" ID="lblMensaje" CssClass="text-success"></asp:Label>
                    </div>
                </fieldset>
            </div>
        </div>

        <%--Agregar Tarjeta--%>



    </form>
</body>
</html>
