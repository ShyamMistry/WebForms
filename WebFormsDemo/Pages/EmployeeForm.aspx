<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="WebFormsDemo.Pages.EmployeeForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
        <h1>Web Forms Ex 05 By Shyam Mistry</h1>
    </div>
     <div class="row">
        <div class="col-md-12 alert alert-info">
            This is Ex 05 basic web form construction, data collection with validation, and display, but no database.
        </div>
    </div>
<div class="row">
        <div class="col-md-4 text-right">
                <asp:Label ID="Label1" runat="server" Text="ID"
                     AssociatedControlID="ID"></asp:Label>
        </div>
        <div class="col-md-4 text-left">
                <asp:TextBox ID="ID" runat="server" ></asp:TextBox>
        </div>
    </div>
<div class="row">
        <div class="col-md-4 text-right">
                  <asp:Label ID="Label2" runat="server" Text="Name"
                     AssociatedControlID="Name"></asp:Label>
        </div>
        <div class="col-md-4 text-left">
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </div>
    </div>
<div class="row">
        <div class="col-md-4 text-right">
                <asp:Label ID="LabelPhone" runat="server" Text="Phone"
                     AssociatedControlID="Phone"></asp:Label>
        </div>
        <div class="col-md-4 text-left">
                <asp:TextBox ID="Phone" runat="server" ></asp:TextBox>
        </div>
    </div>
<br />
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4 text-left">
            <asp:Button ID="Add1" runat="server" OnClick="Add_Click" Text="Add Person"/>&nbsp;&nbsp;
            <asp:Button ID="Clear1" runat="server" OnClick="Clear_Click" Text="Clear" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-4"></div>
        <div class="col-8">
            <label id="MessageLabel1" runat="server" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-4"></div>
        <div class="col-8">
            <asp:GridView ID="EmployeeGridView" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>