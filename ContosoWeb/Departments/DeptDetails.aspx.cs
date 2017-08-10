using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Model;

namespace ContosoWeb.Departments
{
    public partial class DeptDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var deptId = Convert.ToInt32(Request.QueryString["id"]);
                DepartmentService service = new DepartmentService();
                Contoso.Model.Departments dept = service.GetById(deptId);
                lbDeptName.Text = dept.Name;
                lbBudget.Text = dept.Budget.ToString();

            }
        }
    }
}