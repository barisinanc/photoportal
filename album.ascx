<%@ Control Language="C#" AutoEventWireup="true" CodeFile="album.ascx.cs" Inherits="album" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Sipariş Ver" />
<asp:Button ID="Sil" runat="server" Text="Seçili Öğeleri Sil" 
    onclick="Sil_Click" />
<asp:Button ID="CevirSol" runat="server" Text="Sola Çevir" 
    onclick="CevirSol_Click" />
<asp:Button ID="CevirSag" runat="server" Text="Sağa Çevir" 
    onclick="CevirSag_Click" />
    
<asp:ListView ID="ListView1" runat="server" DataKeyNames="id" 
    GroupItemCount="4">
    <EmptyItemTemplate>
        <td runat="server" />
        </EmptyItemTemplate>
        <ItemTemplate>
            <td runat="server" style="">
                <div style="width:100px;height:auto">
                   <asp:Image ID="image" runat="server" ImageUrl='<%# string.Format("icerik/mini/{0}",Eval("dosya")) %>' /></div>
                <br />
                <asp:CheckBox ID="sec" runat="server" Text='<%# Eval("ad") %>' />
                <asp:Label ID="id" runat="server" Visible="false" Text='<%# Eval("id") %>'></asp:Label>
            </td>
        </ItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        Herhangi bir dosya bulunamadı.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">
                dosya:
                <asp:TextBox ID="dosyaTextBox" runat="server" Text='<%# Bind("dosya") %>' />
                <br />
                album_id:
                <asp:TextBox ID="album_idTextBox" runat="server" 
                    Text='<%# Bind("album_id") %>' />
                <br />
                tarih:
                <asp:TextBox ID="tarihTextBox" runat="server" Text='<%# Bind("tarih") %>' />
                <br />
                kul_id:
                <asp:TextBox ID="kul_idTextBox" runat="server" Text='<%# Bind("kul_id") %>' />
                <br />
                album:
                <asp:TextBox ID="albumTextBox" runat="server" Text='<%# Bind("album") %>' />
                <br />
                kullanici:
                <asp:TextBox ID="kullaniciTextBox" runat="server" 
                    Text='<%# Bind("kullanici") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                    Text="Insert" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Clear" />
                <br />
            </td>
        </InsertItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="groupPlaceholderContainer" runat="server" border="0" style="">
                            <tr ID="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <EditItemTemplate>
            <td runat="server" style="">
                id:
                <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                <br />
                dosya:
                <asp:TextBox ID="dosyaTextBox" runat="server" Text='<%# Bind("dosya") %>' />
                <br />
                album_id:
                <asp:TextBox ID="album_idTextBox" runat="server" 
                    Text='<%# Bind("album_id") %>' />
                <br />
                tarih:
                <asp:TextBox ID="tarihTextBox" runat="server" Text='<%# Bind("tarih") %>' />
                <br />
                kul_id:
                <asp:TextBox ID="kul_idTextBox" runat="server" Text='<%# Bind("kul_id") %>' />
                <br />
                album:
                <asp:TextBox ID="albumTextBox" runat="server" Text='<%# Bind("album") %>' />
                <br />
                kullanici:
                <asp:TextBox ID="kullaniciTextBox" runat="server" 
                    Text='<%# Bind("kullanici") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                    Text="Update" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Cancel" />
                <br />
            </td>
        </EditItemTemplate>
        <GroupTemplate>
            <tr ID="itemPlaceholderContainer" runat="server">
                <td ID="itemPlaceholder" runat="server">
                </td>
            </tr>
        </GroupTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="">
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                dosya:
                <asp:Label ID="dosyaLabel" runat="server" Text='<%# Eval("dosya") %>' />
                <br />
                album_id:
                <asp:Label ID="album_idLabel" runat="server" Text='<%# Eval("album_id") %>' />
                <br />
                tarih:
                <asp:Label ID="tarihLabel" runat="server" Text='<%# Eval("tarih") %>' />
                <br />
                kul_id:
                <asp:Label ID="kul_idLabel" runat="server" Text='<%# Eval("kul_id") %>' />
                <br />
                album:
                <asp:Label ID="albumLabel" runat="server" Text='<%# Eval("album") %>' />
                <br />
                kullanici:
                <asp:Label ID="kullaniciLabel" runat="server" Text='<%# Eval("kullanici") %>' />
                <br />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    
