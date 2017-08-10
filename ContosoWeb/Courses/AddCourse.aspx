<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="ContosoWeb.Courses.AddCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtTitle">Course Title</label>
        <asp:TextBox runat ="server" ID="txtTitle" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtCredit">Credit</label>
        <asp:TextBox runat ="server" ID="txtCredit" CssClass="form-control"></asp:TextBox>
    </div>

     <div class="form-group">
        <label for="txtDepartmentId">DepartmentId</label>
        <asp:TextBox runat ="server" ID="txtDepartmentId" CssClass="form-control"></asp:TextBox>
    </div>

     

    <asp:Button Text="SaveCourse" runat="server" ID="btnSave" OnClick ="btnSave_Click" CssClass ="btn btn-primary" />
</asp:Content>
