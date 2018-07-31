using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterHome : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UserId"]!=null)
        {
            name.InnerText = (string)Session["Name"];
        }
        else
        {
            Response.Redirect("index.aspx");
        }
    }
    protected void Logout_Click(object sender, EventArgs e)
    {
        Session["UserId"] = null;
        Response.Redirect("index.aspx");
    }
}
