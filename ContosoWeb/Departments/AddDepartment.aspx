<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="ContosoWeb.Departments.AddDepartment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtName">Name</label>
        <asp:TextBox runat ="server" ID="txtName" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtBudget">Budget</label>
        <asp:TextBox runat ="server" ID="txtBudget" CssClass="form-control"></asp:TextBox>
    </div>

     <div class="form-group">
        <label for="txtStartDate">StartDate</label>
        <asp:TextBox runat ="server" ID="txtStartDate" CssClass="form-control"></asp:TextBox>
    </div>

     <div class="form-group">
        <label for="txtInstructorId">InstructorId</label>
        <asp:TextBox runat ="server" ID="txtInstructorId" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button Text="SaveDepartment" runat="server" ID="btnSave" OnClick ="btnSave_Click" CssClass ="btn btn-primary" />
</asp:Content>
