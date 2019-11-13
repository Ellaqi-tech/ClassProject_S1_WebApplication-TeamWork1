<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h1>Classes</h1>
    <div id="classes_list" class="_table" runat="server">
        <div class="listitem">
            <div class="col6">CLASS CODE</div>
            <div class="col6">TEACHER ID</div>
            <div class="col6">START DATE</div>
            <div class="col6">FINISH DATE</div>
            <div class="col6">CLASS NAME</div>
            <div class="col6last">VIEW</div>

           
        </div>
    </div>
</asp:Content>