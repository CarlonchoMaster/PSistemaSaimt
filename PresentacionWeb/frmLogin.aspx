﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/LoginInt.Master" CodeBehind="frmLogin.aspx.vb" Inherits="PresentacionWeb.frmLogin" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table id="TablaLogin">
        <tr>
            <td align="right">
                Usuario:
            </td>
            <td align="left">
                <cc1:saimtaspxtextbox ID="txtUsuario" runat="server" Width="170px">
                </cc1:saimtaspxtextbox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Password:
            </td>
            <td align="left">
                <cc1:saimtaspxtextbox ID="txtPassword" runat="server" Width="170px" 
                    Password="True">
                </cc1:saimtaspxtextbox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <cc1:saimtaspxcheckbox ID="chkRecordarContraseña" runat="server" 
                    Text="Recordar Contraseña">
                </cc1:saimtaspxcheckbox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="center">
                <cc1:saimtaspxbutton ID="btnIniciarSesion" runat="server" Text="Ingresar">
                </cc1:saimtaspxbutton>
            </td>
        </tr>
    </table>
</asp:Content>