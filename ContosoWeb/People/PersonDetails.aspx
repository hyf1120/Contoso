<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonDetails.aspx.cs" Inherits="ContosoWeb.People.PersonDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Person Details</h4>
    <hr />
    <dl class ="dl-horizontal">
        <dt>
            First Name
        </dt>
        <dd>
            <asp:Label Text="" ID ="lbFirstName" runat="server" />
        </dd>

        <dt>
            Last Name
        </dt>
        <dd>
            <asp:Label Text="" ID ="lbLastName" runat="server" />
        </dd>


    </dl>
</asp:Content>
