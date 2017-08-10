<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentList.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>List of Departments</h4>
    
    <hr />
    <a href="AddDepartment.aspx">Add Deparment</a>
    <asp:Repeater runat="server" ID="repDept" OnItemCommand="repDept_ItemCommand">
        <HeaderTemplate>
            <table class ="table table-bordered">
                <tr>
                    <td>ID</td>
                    <td>Department Name</td>
                    <td>Budget</td>
                    <td>Start Date</td>
                    <td>Instructor Id</td>
                    <td>Actions</td>
                </tr>
            
        </HeaderTemplate>
        
        <ItemTemplate>  
            <tr class ="info alert-info">
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="lbId"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="lbDName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Budget") %>' runat="server" ID="lbBudget"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("StartDate") %>' runat="server" ID="lbSDate"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("InstructorId") %>' runat="server" ID="lbInsId"/>
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
