using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class English : System.Web.UI.Page
{
  static  bool logged = false;
  
   
   
    //private SqlConnection conn;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string ingname;
        Panel3.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label12.Visible = false;
        Label13.Visible = false; 
        Label14.Visible = false; 
        Label15.Visible = false; 
        Label16.Visible = false; 
        Label17.Visible = false;

       

        //SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        //SqlCommand cmd4 = new SqlCommand("SELECT IngredientNameEn FROM Ingredients ORDER BY IngredientNameEn", conn4);

        //conn4.Open();
        //SqlDataReader reader2 = cmd4.ExecuteReader();
        //ListBox1.Items.Clear();
        //while (reader2.Read())
        //{
        //    ListBox1.Items.Add(reader2.GetValue(0).ToString());
        //    //testlbl.Text = reader2.GetValue(0).ToString();

        //    // ingname = reader2["IngredientNameEn"].ToString();
        //    //ListItem i = new ListItem(ingname);

        //    //ListItem item = new ListItem();
        //    //  item.Text = reader2["IngredientNameEn"].ToString();


        //    //ListBox1.Items.Add(i);
        //    //ListBox1.DataSource = reader2;
        //    //ListBox1.Items.Add(reader2["IngredientNameEn"].ToString());

        //}
        //conn4.Close();
       


    }
    
 
    protected void addingbut_Click(object sender, EventArgs e)
    {
        
        Panel1.Enabled = false;
        Panel3.Visible = true;
    }
 
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        SqlCommand cmd2 = new SqlCommand("Insert into Ingredients (IngredientNameEn, IngredientNameAr, Units, CaloriesPerUnit, Vitamins, HealthBenEn, HealthBenAr, HealthDisbEn, HealthDisbAr) Values (@IngredientNameEn, @IngredientNameAr, @Units, @Calories, @Vitamins, @HealthBenEn, @HealthBenAr, @HealthDisbEn, @HealthDisbAr)", conn2);
        cmd2.CommandType = CommandType.Text;
        cmd2.Parameters.AddWithValue("@IngredientNameEn", TextBox5.Text);
        cmd2.Parameters.AddWithValue("@Calories", TextBox6.Text);
        cmd2.Parameters.AddWithValue("@HealthBenEn", TextBox7.Text);
        cmd2.Parameters.AddWithValue("@HealthDisbEn", TextBox8.Text);
        cmd2.Parameters.AddWithValue("@IngredientNameAr", TextBox1.Text);
        cmd2.Parameters.AddWithValue("@Vitamins", TextBox3.Text);
        cmd2.Parameters.AddWithValue("@HealthBenAr", TextBox4.Text);
        cmd2.Parameters.AddWithValue("@HealthDisbAr", TextBox9.Text);
        cmd2.Parameters.AddWithValue("@Units", TextBox2.Text);
        conn2.Open();
        cmd2.ExecuteNonQuery();


        //SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        //SqlCommand cmd3 = new SqlCommand("SELECT Ingredient=IngredientNameEn, Calories=CaloriesPerUnit, HealthBenefits=HealthBenEn, HealthDisbenefits=HealthDisbEn FROM Ingredients ORDER BY IngredientNameEn", conn3);
        //conn3.Open();
        //SqlDataReader reader = cmd3.ExecuteReader();
        //GridView1.DataSource = reader;
        //GridView1.DataBind();
        Panel1.Enabled = true;
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {


      
        string ingsel;
       // string imagestr;
        
      //  ingsel = ListBox1.SelectedValue.ToString();
        //ingsel = "butter";
        //testlbl.Text = ingsel;
        ingsel = ListBox1.SelectedItem.ToString();
      

        try
        {
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label12.Visible = true;
            Label13.Visible = true;
            Label14.Visible = true;
            Label15.Visible = true;
            Label16.Visible = true;
            Label17.Visible = true;

            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
            SqlCommand cmd5 = new SqlCommand("SELECT * FROM Ingredients WHERE IngredientNameEn ='" + ingsel  + "'", conn5);
            conn5.Open();
            SqlDataReader reader5 = cmd5.ExecuteReader();
          
            //SqlConnection conn = new SqlConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM ingredient WHERE ingredientEn=ingsel", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            while (reader5.Read()) //loop on all rows of table
            {
                Label13.Text = reader5["CaloriesPerUnit"].ToString();
                Label14.Text = reader5["Vitamins"].ToString();
                Label15.Text = reader5["Units"].ToString();
                Label16.Text = reader5["HealthBenEn"].ToString();
                Label17.Text = reader5["HealthDisbEn"].ToString();
               // imagestr=reader5["Image"].ToString();
               // Image1.ImageUrl="C:/Users/Najwa/Documents/Visual Studio 2005/WebSites/EECE 433 Project/food/leb.gif";
                Image1.ImageUrl="~/food/Lebanese Food (thats good food).jpeg";
               // Image1.ImageUrl = reader5["Image"].ToString();
                //calorieslbl.Text = reader.GetValue(5).ToString();
                //vitaminslbl.Text = reader.GetValue(7).ToString();
                //units = reader.GetValue(3).ToString();
                //HBlbl.Text = reader.GetValue(8).ToString();
                //HDlbl.Text = reader.GetValue(10).ToString();
                //calorieslbl.Text = calorieslbl.Text + " per " + units;

            }
            reader5.Close();

        }
        catch (Exception)
        {

            throw;
        }

      //  Button2_Click(Button2, e);
        
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
        SqlCommand cmd4 = new SqlCommand("SELECT IngredientNameEn FROM Ingredients ORDER BY IngredientNameEn", conn4);

        conn4.Open();
        SqlDataReader reader2 = cmd4.ExecuteReader();
        ListBox1.Items.Clear();
        while (reader2.Read())
        {
            ListBox1.Items.Add(reader2.GetValue(0).ToString());
            //testlbl.Text = reader2.GetValue(0).ToString();

            // ingname = reader2["IngredientNameEn"].ToString();
            //ListItem i = new ListItem(ingname);

            //ListItem item = new ListItem();
            //  item.Text = reader2["IngredientNameEn"].ToString();


            //ListBox1.Items.Add(i);
            //ListBox1.DataSource = reader2;
            //ListBox1.Items.Add(reader2["IngredientNameEn"].ToString());

        }
        conn4.Close();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Label23.Text = "";
        string user = TextBox10.Text;
        string pass = TextBox11.Text;
        int foundu = 0;
        int foundp = 0;
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
            SqlCommand cmd4 = new SqlCommand("SELECT Password FROM Users where username ='" + user + "'", conn4);
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
            Label24.Text = "Incorrect Password";
        }
        else if (foundu = 0)
        {
            Label24.Text = "Incorrect Username";
        }
        else if (foundu = 1 && foundp = 1)
        {
            Label24.Text = "Logged in as " + user;

            logged = true;

            LinkButton2.Visible = false;
            LinkButton3.Visible = true;
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton3.Visible = false;
        LinkButton2.Visible = true;
        logged = false;
        Label24.Text = "";
        Label23.Text = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label23.Text = "";
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
            cmd2.Parameters.AddWithValue("@Username", TextBox10.Text);
            cmd2.Parameters.AddWithValue("@Password", TextBox11.Text);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            Label2.Text = "Logged in as " + TextBox10.Text;

            logged = true;

            LinkButton2.Visible = false;
            LinkButton3.Visible = true;
        }
        else
        {
            Label23.Text = "Username Already Exists, Please Choose Another";
        }
    }
    }

