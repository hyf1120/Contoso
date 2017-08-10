using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Model;
using Contoso.Utility;


namespace ContosoWeb.People
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var personId = Convert.ToInt32(Request.QueryString["id"]);
                PeopleService service = new PeopleService();
                Contoso.Model.People person = service.GetById(personId);
                txtFName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtAge.Text = person.Age.ToString();
                txtEmail.Text = person.Email;
                txtMiddleName.Text = person.MiddleName;
                txtAddress1.Text = person.AddressLine1;
                txtAddress2.Text = person.AddressLine2;
                txtZipCode.Text = person.ZipCode.ToString();
                txtApt.Text = person.UnitOrApartmentNumber.ToString();
                txtCity.Text = person.City;
                txtPhone.Text = person.Phone.ToString();
                ddlStates.SelectedValue = person.State;
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
        }

        protected void btnChanges_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Contoso.Model.People person = new Contoso.Model.People
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]),
                    FirstName = txtFName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Email = txtEmail.Text,
                    Phone = Convert.ToInt32(txtPhone.Text),
                    AddressLine1 = txtAddress1.Text,
                    AddressLine2 = txtAddress2.Text,
                    UnitOrApartmentNumber = Convert.ToInt32(txtApt.Text),
                    City = txtCity.Text,
                    State = ddlStates.SelectedValue,
                    ZipCode = Convert.ToInt32(txtZipCode.Text)
                };
                PeopleService service = new PeopleService();
                service.UpdateById(person);
            }
        }
    }
}