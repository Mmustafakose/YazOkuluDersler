<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ogrenciListesi.aspx.cs" Inherits="Yaz_Okulu_Dersler.ogrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <table class="table table-bordered table-hover">
            <tr>
                <th>Öğrenci Id</th>
                <th>Öğrenci Ad</th>
                <th>Öğrenci Soyad</th>
                <th>Öğrenci Numara</th>
                <th>Öğrenci Şifre</th>
                <th>Öğrenci Fotoğraf</th>
                <th>Öğrenci Bakiye</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Id1") %></td>
                            <td><%#Eval("Ad") %></td>
                            <td><%#Eval("Soyad") %></td>
                            <td><%#Eval("Numara") %></td>
                            <td><%#Eval("Sifre") %></td>
                            <td><%#Eval("Fotograf") %></td>
                            <td><%#Eval("Bakiye") %></td>
                            <td>

                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"~/ogrenciSil.aspx?ıd="+Eval("Id1") %>'>Sil</asp:HyperLink>

                                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"~/ogrenciGuncelle.aspx?ıd="+Eval("Id1") %>'>Güncelle</asp:HyperLink>

                                <%--2. Yol--%>
                                <%--                            <a  href="ogrenciSil.aspx?ıd=<%#Eval("Id1") %>">Sil</a>
                            <a  href="ogrenciGuncelle.aspx?ıd=<%#Eval("Id1") %>">Güncelle</a>--%>


                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
