<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fotoalbum.aspx.cs" Inherits="fotoalbum" %>
<%@ Register Src="~/album.ascx"  TagPrefix="Alb" TagName="Album"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="album_panel" runat="server">
        <Alb:Album ID="album" runat="server" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
