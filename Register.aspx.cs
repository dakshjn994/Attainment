using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniprojectCS"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void email_ServerClick(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Count(*) From Login Where UserId=@u And Email=@p";
            cmd.Parameters.AddWithValue("@u", Userid.Value.TrimEnd());
            cmd.Parameters.AddWithValue("@p", mail.Value.TrimEnd());
            con.Open();
            int num = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (num == 1)
            {
                cmd.CommandText = "Select Password From Login Where UserId=@u";
                con.Open();
                string pass = (string)(cmd.ExecuteScalar().ToString());
                con.Close();
                if(pass!=(DBNull.Value.ToString()))
                {
                    string var = "User Id Already Exists";
                    Response.Write("<script language=javascript>alert('" + var + "');</script>");
                }
                else
                {
                    SendEmail123 a = new SendEmail123();
                    string message = "Hello Respected User,<br/><br/> Please Follow Go To This Link To Register: <a href='http://localhost:1249/Mailreg.aspx?Id=" + Userid.Value + "&Email=" + mail.Value + "'>Register</a>";
                    a.sendEMail(((mail.Value).Trim()), message, "Register Yourself");
                    string var = "Email Has Been Sent";
                    Response.Write("<script language=javascript>alert('" + var + "');</script>");
                    mail.Value = "";
                    Userid.Value = "";
                }
            }
            else
            {
                string var = "User Id Doesent Exist Or Wrong Email";
                Response.Write("<script language=javascript>alert('" + var + "');</script>");
            }
    }
}