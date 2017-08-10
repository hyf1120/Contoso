using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Model;
using Contoso.Service;

namespace ContosoWeb.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //check the server side control because the user/browser can disable the javascript.
            if(Page.IsValid)
            {
                Contoso.Model.People person = new Contoso.Model.People
                {

                    FirstName = txtFName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    AddressLine1 = txtAddress1.Text,
                    AddressLine2 = txtAddress2.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    State = ddlStates.SelectedValue

                };
                PeopleService service = new PeopleService();
                service.SavePerson(person);
            }
        } 
    }
}