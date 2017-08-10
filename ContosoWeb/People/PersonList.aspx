<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonList.aspx.cs" Inherits="ContosoWeb.People.PersonList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>List of People</h4>
    <hr />
    <a href="AddPerson.aspx">Add Person</a>
    <asp:Repeater runat="server" ID="repPerson" OnItemCommand="repPerson_ItemCommand">
        <HeaderTemplate>
            <table class ="table table-bordered">
                <tr>
                    <td>ID</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>E-mai</td>
                    <td>Phone Number</td>
                    <td>Actions</td>
                </tr>
            
        </HeaderTemplate>
        
        <ItemTemplate>  
            <tr class ="info alert-info">
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="lbId"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("FirstName") %>' runat="server" ID="lbFName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("LastName") %>' runat="server" ID="lbLName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Email") %>' runat="server" ID="lbEmail"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Phone") %>' runat="server" ID="lbPhone"/>
                </td>
                <td>
                    <asp:Button Text="Edit" runat="server" ID="btnEdit" CssClass="btn btn-primary" CommandName ="edit" CommandArgument ='<%# Eval("Id") %>'/>
                    <asp:Button Text="Delete" runat="server" ID="btnDelete" CssClass="btn btn-danger" CommandName ="delete" CommandArgument ='<%# Eval("Id") %>'/>
                    <asp:Button Text="Details" runat="server" ID="btnDetails" CssClass="btn btn-success" CommandName ="details" CommandArgument ='<%# Eval("Id") %>'/>
                </td>
            </tr>

        </ItemTemplate>
        
        <FooterTemplate>
          </table>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>
