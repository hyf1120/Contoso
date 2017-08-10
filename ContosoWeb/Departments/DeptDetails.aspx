<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeptDetails.aspx.cs" Inherits="ContosoWeb.Departments.DeptDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Department Details</h4>

    <hr />
    <dl class ="dl-horizontal">
        <dt>
            Department Name
        </dt>
        <dd>
            <asp:Label Text="" ID ="lbDeptName" runat="server" />
        </dd>

        <dt>
            Budget
        </dt>
        <dd>
            <asp:Label Text="" ID ="lbBudget" runat="server" />
        </dd>
        </dl>
</asp:Content>
