<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Yaz_Okulu_Dersler.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form ıd="form1" runat="server">

        <div class="form-group container">
            <div>
                <asp:Label for="TextBox1" runat="server" Font-Bold="true" Text="Öğrenci Adı: "></asp:Label>
                <asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox2" runat="server" Font-Bold="true" Text="Öğrenci Soyadı: "></asp:Label>
                <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox3" runat="server" Font-Bold="true" Text="Öğrenci Numara: "></asp:Label>
                <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox4" runat="server" Font-Bold="true" Text="Öğrenci Şifre: "></asp:Label>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox5" runat="server" Font-Bold="true" Text="Öğrenci Fotograf: "></asp:Label>
                <asp:TextBox ID="txtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextBox6" runat="server" Font-Bold="true" Text="Öğrenci Bakiye: "></asp:Label>
                <asp:TextBox ID="txtBakiye" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <div class="container" >
            <asp:Button ID="Button1" runat="server" Font-Bold="true" Text="Kaydet" OnClick="btnOgrEkle_Click" CssClass="btn btn-info" />
        </div>

    </form>


</asp:Content>
