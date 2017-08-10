<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeptEdit.aspx.cs" Inherits="ContosoWeb.Departments.DeptEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Dept Edit</h4>

    <div class="form-group">
        <label for="txtDName">Department Name</label>
        <asp:TextBox runat ="server" MaxLength ="50" ID="txtDName" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqDName" ErrorMessage="Department Name is required" ControlToValidate="txtDName" runat="server" CssClass="text-danger" />
    </div>

    <div class="form-group">
        <label for="txtBudget">Budget</label>
        <asp:TextBox runat ="server" MaxLength ="50" ID="txtBudget" CssClass="form-control"></asp:TextBox>
        
    </div>

     <div class="form-group">
        <label for="txtSDate">Start Date</label>
        <asp:TextBox runat ="server" ID="txtSDate" CssClass="form-control"></asp:TextBox>
    </div>

      <div class="form-group">
        <label for="txtInsId">Instructor ID</label>
        <asp:TextBox runat ="server" ID="txtInsId" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button Text="Save Changes" runat="server" ID="btnChanges" OnClick ="btnChanges_Click" CssClass ="btn btn-primary" />
</asp:Content>
