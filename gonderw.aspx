<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gonderw.aspx.cs" Inherits="gonder" %>
<%@ Register assembly="SharpPieces.Web.Controls" namespace="SharpPieces.Web.Controls" tagprefix="piece" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <piece:Upload ID="Upload1" runat="server" BrowseText="Dosyaları Seç" 
            onfilereceived="Upload1_FileReceived" onload="Upload1_Load" />
    </div>
    </form>
</body>
</html>
