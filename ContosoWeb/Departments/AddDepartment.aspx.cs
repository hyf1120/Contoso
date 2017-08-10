using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Model;
using Contoso.Service;

namespace ContosoWeb.Departments
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contoso.Model.Departments dept = new Contoso.Model.Departments
            {
                Name = txtName.Text,
                Budget = Convert.ToInt32(txtBudget.Text),
                StartDate = Convert.ToDateTime(txtStartDate.Text),
                InstructorId = Convert.ToInt32(txtInstructorId.Text)
            };
            DepartmentService service = new DepartmentService();
            service.SaveDepartment(dept);

        }
    }
}