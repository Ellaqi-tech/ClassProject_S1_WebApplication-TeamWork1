<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddingStudents.aspx.cs" Inherits="HTTP5101_School_System.AddingStudents" %>

<asp:Content ID="AddingStudents" ContentPlaceHolderID="body" runat="server">
    <form id="Students_Adding" runat="server">
          <div>
            <label for="student_fname">First name:</label>
            <asp:Textbox runat="server" ID="student_fname" placeholder="John"></asp:Textbox>
            <label for="student_lname">Last name:</label>
            <asp:Textbox runat="server" ID="student_lname" placeholder="Smith"></asp:Textbox>
            <label for="student_number">Student Number:</label>
            <asp:Textbox runat="server" ID="student_number" placeholder="n1400"></asp:Textbox>
            <asp:Button runat="server" text="Submit" />
            <div id="AddingSummary"></div>
         </div>
    </form>       
</asp:Content>
