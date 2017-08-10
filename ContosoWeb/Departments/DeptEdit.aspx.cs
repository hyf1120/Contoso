using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWeb.Departments
{
    public partial class DeptEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var deptId = Convert.ToInt32(Request.QueryString["id"]);
                DepartmentService service = new DepartmentService();
                Contoso.Model.Departments dept = service.GetById(deptId);
                txtDName.Text = dept.Name;
                txtBudget.Text = dept.Budget.ToString();
                txtSDate.Text = dept.StartDate.ToString();
                txtInsId.Text = dept.InstructorId.ToString();
            }
        }

        protected void btnChanges_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Contoso.Model.Departments dept = new Contoso.Model.Departments
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]),
                    Name = txtDName.Text,
                    Budget = Convert.ToInt32(txtBudget.Text),
                    StartDate = Convert.ToDateTime(txtSDate.Text),
                    InstructorId = Convert.ToInt32(txtInsId.Text)
                };
                DepartmentService service = new DepartmentService();
                service.Update(dept);

            }

        }
    }
}