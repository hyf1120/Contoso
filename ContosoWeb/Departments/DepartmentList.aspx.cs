using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWeb.Departments
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DepartmentService service = new DepartmentService();
                repDept.DataSource = service.GetAllDepartments();
                repDept.DataBind();
            }
        }

        protected void repDept_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var deptId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                Response.Redirect("DeptEdit.aspx?id=" + deptId);
            }
            if (e.CommandName == "delete")
            {
                DepartmentService service = new DepartmentService();
                service.DeleteDeptById(deptId);
                Response.Redirect("DepartmentList.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("DeptDetails.aspx?id=" + deptId);
            }
        }
    }
}