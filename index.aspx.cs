using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniprojectCS"].ConnectionString);
    int nam;
    string user;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null)
        {
            Response.Redirect("Home.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Count(*) From Login Where UserId=@u And Password=@p";
            cmd.Parameters.AddWithValue("@u", txtUser.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@p", txtPwd.Text.TrimEnd());
            con.Open();
            nam = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (nam == 1)
            {
                SqlCommand com = new SqlCommand("Select Password from Login where UserId=@Email and  Password=@Password", con);
                com.Parameters.AddWithValue("@Email", txtUser.Text.TrimEnd());
                com.Parameters.AddWithValue("@Password", txtPwd.Text.TrimEnd());
                con.Open();
                string pass = Convert.ToString(com.ExecuteScalar().ToString());
                con.Close();
                if (txtPwd.Text == pass)
                {
                    SqlCommand cmm = new SqlCommand("Select UserId from Login where UserId=@Email and  Password=@Password", con);
                    cmm.Parameters.AddWithValue("@Email", txtUser.Text.TrimEnd());
                    cmm.Parameters.AddWithValue("@Password", txtPwd.Text.TrimEnd());
                    con.Open();
                    user = Convert.ToString(cmm.ExecuteScalar().ToString());
                    con.Close();
                    if (txtUser.Text == user)
                    {
                        SqlCommand cm = new SqlCommand("Select Name from Login where UserId=@Email and  Password=@Password", con);
                        cm.Parameters.AddWithValue("@Email", txtUser.Text.TrimEnd());
                        cm.Parameters.AddWithValue("@Password", txtPwd.Text.TrimEnd());
                        con.Open();
                        string name = Convert.ToString(cm.ExecuteScalar().ToString());
                        con.Close();
                        Session["UserId"] = txtUser.Text.TrimEnd();
                        Session["Name"] = name;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        string var = "User Id Doesent Exist";
                        Response.Write("<script language=javascript>alert('" + var + "');</script>");
                    }
                }
                else
                {
                    string var = "Wrong Password";
                    Response.Write("<script language=javascript>alert('" + var + "');</script>");
                }
            }
            else
            {
                string var = "Wrong Password/User Id";
                Response.Write("<script language=javascript>alert('" + var + "');</script>");
            }
        }
        catch (SqlException ie)
        {
            string v = ie.Message;
            Response.Write("<script language=javascript>alert('" + v + "')</script>");
        }
    }
}