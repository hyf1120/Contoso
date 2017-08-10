<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContosoWeb.People.AddPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h4>Add a person</h4>
    <hr />

    <div class="form-group">
        <label for="txtFirstName">First Name</label>
        <asp:TextBox runat ="server" MaxLength ="50" ID="txtFName" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqFName" ErrorMessage="FirstName is required" ControlToValidate="txtFName" runat="server" CssClass="text-danger" />
    </div>

    <div class="form-group">
        <label for="txtLastName">Last Name</label>
        <asp:TextBox runat ="server" MaxLength ="50" ID="txtLastName" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ErrorMessage="Last Name is requred" ControlToValidate="txtLastName" runat="server" CssClass="text-danger" />
    </div>

     <div class="form-group">
        <label for="txtMiddleName">Middle Name</label>
        <asp:TextBox runat ="server" ID="txtMiddleName" CssClass="form-control"></asp:TextBox>
    </div>

      <div class="form-group">
        <label for="txtEmail">E-mail</label>
        <asp:TextBox runat ="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqEmail" ErrorMessage="E-mail is required" ControlToValidate="txtEmail" runat="server" CssClass="text-danger" />
          <asp:RegularExpressionValidator ID="regEmail" ErrorMessage="E-mail is not valid" ControlToValidate="txtEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text-danger"/>
    </div>

     <div class="form-group">
        <label for="txtAge">Age</label>
        <asp:TextBox runat ="server" ID="txtAge" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtAddress1">Address Line 1</label>
        <asp:TextBox runat ="server" ID="txtAddress1" CssClass="form-control"></asp:TextBox>
    </div>

      <div class="form-group">
        <label for="txtAddress2">Address Line 2</label>
        <asp:TextBox runat ="server" ID="txtAddress2" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="">State</label>
        <asp:DropDownList runat="server" ID ="ddlStates" CssClass ="form-control ">
           
        </asp:DropDownList>
    </div>

    <asp:Button Text="SavePerson" runat="server" ID="btnSave" OnClick ="btnSave_Click" CssClass ="btn btn-primary" />

    <asp:Button Text="Cancel" runat="server" ID="btnCancel"  CausesValidation ="false" CssClass ="btn btn-primary" />
</asp:Content>
