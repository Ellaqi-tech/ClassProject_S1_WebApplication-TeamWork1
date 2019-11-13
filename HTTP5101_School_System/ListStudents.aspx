<%@ Page Title="Students" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
    <div id="students_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col5">FIRST NAME</div>
            <div class="col5">LAST NAME</div>
            <div class="col5">STUDENT NUMBER</div>
            <div class="col5">ENROLMENT DATE</div>
            <div class="col5last">VIEW</div>
        </div>
    </div>
</asp:Content>
