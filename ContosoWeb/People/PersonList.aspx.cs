using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWeb.People
{
    public partial class PersonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PeopleService service = new PeopleService();
                repPerson.DataSource = service.GetAllPersons();
                repPerson.DataBind();
            }
        }

        protected void repPerson_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var personId = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "edit")
            {
                Response.Redirect("PersonEdit.aspx?id=" + personId );
            }
            if (e.CommandName == "delete")
            {
                PeopleService service = new PeopleService();
                service.DeletePerson(personId);
                Response.Redirect("PersonList.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("PersonDetails.aspx?id=" + personId);
            }
        }
    }
}