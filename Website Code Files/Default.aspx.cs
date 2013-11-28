using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{static  bool logged = false;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        butgoarab.Visible = false;
        butgoeng.Visible = false;
      

    }
    protected void butgoeng_Click(object sender, EventArgs e)
    {
        //Response.Redirect("English.aspx");
    }
    protected void butgoarab_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Arabic.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label3.Text = "";
        string user = TextBox1.Text;
        string pass = TextBox2.Text;
        int foundu = 0;
        int foundp=0;
        SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        SqlCommand cmd4 = new SqlCommand("SELECT Username, Password FROM Users", conn4);
        conn4.Open();
        SqlDataReader reader2 = cmd4.ExecuteReader();
        while (reader2.Read())
        {
            if (reader2.GetValue(0).ToString() == user)
            {
                foundu = 1;

            }        

        }

        if (foundu = 1)
        {
            SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
            SqlCommand cmd4 = new SqlCommand("SELECT Password FROM Users where username ='"+user+"'", conn4);
            conn4.Open();
            SqlDataReader reader2 = cmd4.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2.GetValue(0).ToString() == pass)
                {
                    foundp
                        = 1;

                }

            }

        }

        conn4.Close();

        if (foundu = 1 && foundp = 0)
        {
            Label2.Text = "Incorrect Password";
        }
        else if (foundu = 0)
        {
            Label2.Text = "Incorrect Username";
        }
        else if (foundu = 1 && foundp = 1)
        {
            Label2.Text="Logged in as "+user;

            logged = true;

            LinkButton1.Visible = false;
            LinkButton3.Visible=true;
        }

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton3.Visible = false;
        LinkButton1.Visible = true;
        logged = false;
        Label2.Text = "";
        Label3.Text = "";

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Label3.Text = "";
        int check = 0;
        SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        SqlCommand cmd4 = new SqlCommand("SELECT Username FROM Users", conn4);
        conn4.Open();
        SqlDataReader reader2 = cmd4.ExecuteReader();
        while (reader2.Read())
        {
            if (reader2.GetValue(0).ToString() == user)
            {
                check = 1;

            }

        }
        conn4.Close();

        if (check == 1)
        {
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
            SqlCommand cmd2 = new SqlCommand("Insert into Users (Username, Password) Values (@Username, @Password)", conn2);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@Username", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Password", TextBox2.Text);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            Label2.Text = "Logged in as " + TextBox1.Text;

            logged = true;

            LinkButton1.Visible = false;
            LinkButton3.Visible = true;
        }
        else
        {
            Label3.Text = "Username Already Exists, Please Choose Another";
        }
    }
}
