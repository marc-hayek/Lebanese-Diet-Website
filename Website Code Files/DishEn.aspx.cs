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

public partial class food_DishEn : System.Web.UI.Page
{
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
        //Label15.Visible = false;
        Label16.Visible = false;
        //Label17.Visible = false;
        ListBox2.Visible = false;

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
            //Label15.Visible = true;
            Label16.Visible = true;
            //Label17.Visible = true;
            ListBox2.Visible = true;

            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
            SqlCommand cmd5 = new SqlCommand("SELECT * FROM Dish WHERE DishNameEn ='" + ingsel + "'", conn5);
            conn5.Open();
            SqlDataReader reader5 = cmd5.ExecuteReader();

            //SqlConnection conn = new SqlConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM ingredient WHERE ingredientEn=ingsel", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            while (reader5.Read()) //loop on all rows of table
            {
                Label13.Text = reader5["Calories"].ToString();
                Label14.Text = reader5["Vitamins"].ToString();
                //Label15.Text = reader5["Units"].ToString();
                Label16.Text = reader5["HealthBenEn"].ToString();
                Literal1.Text= reader5["InstructionsEn"].ToString();
                Image1.ImageUrl = "C:/Users/Najwa/Documents/Visual Studio 2005/WebSites/EECE 433 Project/food/leb/gif";

                

            }
            reader5.Close();
            //SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodDBConnectionString1"].ConnectionString);
            SqlCommand cmd6 = new SqlCommand("SELECT Dish_ID from Dish where DishNameEn='" + ingsel + "'", conn5);
           
            SqlDataReader reader3 = cmd6.ExecuteReader();
            reader3.Read();
            string idish =reader3.GetValue(0).ToString();
            
            int iddish = int.Parse(idish);
            //int iddish = reader3.GetValue(0);

            //Label15.Text = iddish.ToString();
            reader3.Close();
            SqlCommand cmd7 = new SqlCommand("Select I.IngredientNameEn from ingredients I where I.Ingredient_ID in(Select c.ingredient_id from contained c where c.dish_id =" + iddish + ")", conn5);
            //ListBox2.Items.Clear();

            SqlDataReader reader4 = cmd7.ExecuteReader();
            while (reader4.Read())
            {
                ListBox2.Items.Add(reader4.GetValue(0).ToString());


            }

           
            reader4.Close();
            conn5.Close();
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
        SqlCommand cmd4 = new SqlCommand("SELECT DishNameEn FROM Dish ORDER BY DishNameEn", conn4);

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

