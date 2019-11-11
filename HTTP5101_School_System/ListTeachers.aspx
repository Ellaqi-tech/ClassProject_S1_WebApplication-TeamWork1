<%@ Page Title="Teachers" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>
<asp:Content ID="list_teachers" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div id="teachers_list" class="_table" runat="server">
        <div class="listitem">
            <div class="col5">FIRST NAME</div>
            <div class="col5">LAST NAME</div>
            <div class="col5">EMPLOYEE NUMBER</div>
            <div class="col5">HIRE DATE</div>
            <div class="col5last">SALARY</div>
        </div>
    </div>
</asp:Content>
