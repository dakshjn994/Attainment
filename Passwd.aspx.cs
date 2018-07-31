using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Passwd : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniprojectCS"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = (string)Request.QueryString["Id"], email = (string)Request.QueryString["Email"];
        if (id != null && email != null)
        {

        }
        else
        {
            Response.Redirect("Register.aspx");
        }
    }
    protected void email_ServerClick(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Update Login Set Password=@pass Where UserId=@u And Email=@p";
            cmd.Parameters.AddWithValue("@u", Request.QueryString["Id"].TrimEnd());
            cmd.Parameters.AddWithValue("@p", Request.QueryString["Email"].TrimEnd());
            cmd.Parameters.AddWithValue("@pass", pwd.Value.TrimEnd());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("index.aspx");
        }
        catch (Exception i)
        {
            Response.Write(i.Message);
        }
    }
}