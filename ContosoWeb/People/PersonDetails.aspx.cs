using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWeb.People
{
    public partial class PersonDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var personId = Convert.ToInt32(Request.QueryString["id"]);
                PeopleService service = new PeopleService();
                var person = service.GetById(personId);
                lbFirstName.Text = person.FirstName;
                lbLastName.Text = person.LastName;
            }
            
        }
    }
}