<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gonder.aspx.cs" Inherits="gonder" %>
<%@ Register assembly="SharpPieces.Web.Controls" namespace="SharpPieces.Web.Controls" tagprefix="piece" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<piece:Upload ID="Upload1" runat="server" BrowseText="Dosyaları Seç" 
            onfilereceived="Upload1_FileReceived" onload="Upload1_Load" />
</asp:Content>

