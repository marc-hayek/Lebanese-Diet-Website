<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>
</head>
<body bgcolor="seashell">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" BackColor="SeaShell" Height="75px" Style="font-size: 50pt;
            left: 75px; position: absolute; top: 77px" Text="Healthy Lebanese Diet" Width="615px" ForeColor="LimeGreen"></asp:Label>
        &nbsp;&nbsp;
        <table style="left: 82px; position: absolute; top: 235px; height: 196px; width: 124px;">
            <tr>
                <td style="width: 100px">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Overline="False"
                        Font-Underline="False" ForeColor="Black" NavigateUrl="~/food/Default.aspx">Home</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px">
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True">About Us</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Underline="False" ForeColor="Black" NavigateUrl="~/food/DishEn.aspx">Healthy Meals</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" Font-Underline="False"
                        ForeColor="Black" NavigateUrl="~/food/English.aspx">Ingredients</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True">Contact Us</asp:HyperLink></td>
            </tr>
        </table>
        <asp:Image ID="Image1" runat="server" Height="375px" Style="left: 227px; position: absolute;
            top: 234px" Width="503px" ImageUrl="~/food/Lebanese Food (thats good food).jpeg" />
        &nbsp;
        <asp:HyperLink ID="HyperLink7" runat="server" Font-Bold="True" Style="left: 701px;
            position: absolute; top: 131px">عربي</asp:HyperLink>
        <asp:HyperLink ID="HyperLink6" runat="server" Style="left: 701px; position: absolute;
            top: 102px">English</asp:HyperLink>
        &nbsp;
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FoodDBConnectionString1 %>"
            DeleteCommand="DELETE FROM [Dish] WHERE [Dish_ID] = @Dish_ID" InsertCommand="INSERT INTO [Dish] ([DishNameEn], [DishNameAr], [Calories], [InstructionsEn], [InstructionsAr], [HealthBenEn], [HealthBenAr], [Vitamins]) VALUES (@DishNameEn, @DishNameAr, @Calories, @InstructionsEn, @InstructionsAr, @HealthBenEn, @HealthBenAr, @Vitamins)"
            ProviderName="<%$ ConnectionStrings:FoodDBConnectionString1.ProviderName %>"
            SelectCommand="SELECT [Dish_ID], [DishNameEn], [DishNameAr], [Calories], [InstructionsEn], [InstructionsAr], [HealthBenEn], [HealthBenAr], [Vitamins] FROM [Dish]"
            UpdateCommand="UPDATE [Dish] SET [DishNameEn] = @DishNameEn, [DishNameAr] = @DishNameAr, [Calories] = @Calories, [InstructionsEn] = @InstructionsEn, [InstructionsAr] = @InstructionsAr, [HealthBenEn] = @HealthBenEn, [HealthBenAr] = @HealthBenAr, [Vitamins] = @Vitamins WHERE [Dish_ID] = @Dish_ID">
            <DeleteParameters>
                <asp:Parameter Name="Dish_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DishNameEn" Type="String" />
                <asp:Parameter Name="DishNameAr" Type="String" />
                <asp:Parameter Name="Calories" Type="String" />
                <asp:Parameter Name="InstructionsEn" Type="String" />
                <asp:Parameter Name="InstructionsAr" Type="String" />
                <asp:Parameter Name="HealthBenEn" Type="String" />
                <asp:Parameter Name="HealthBenAr" Type="String" />
                <asp:Parameter Name="Vitamins" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="DishNameEn" Type="String" />
                <asp:Parameter Name="DishNameAr" Type="String" />
                <asp:Parameter Name="Calories" Type="String" />
                <asp:Parameter Name="InstructionsEn" Type="String" />
                <asp:Parameter Name="InstructionsAr" Type="String" />
                <asp:Parameter Name="HealthBenEn" Type="String" />
                <asp:Parameter Name="HealthBenAr" Type="String" />
                <asp:Parameter Name="Vitamins" Type="String" />
                <asp:Parameter Name="Dish_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        &nbsp;
        <table id="TABLE1" style="left: 80px; width: 465px; position: absolute; top: 163px;
            height: 31px" onclick="return TABLE1_onclick()">
            <tr>
                <td style="height: 23px">
                    Username:</td>
                <td style="width: 254px; height: 23px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="155px"></asp:TextBox></td>
                <td style="width: 101px; height: 23px">
                    Password:</td>
                <td style="width: 290px; height: 23px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Style="left: 83px;
            position: absolute; top: 203px">Login</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Style="left: 83px;
            position: absolute; top: 203px" Visible="False">Logout</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Style="left: 138px;
            position: absolute; top: 203px">Register</asp:LinkButton>
        <asp:Label ID="Label2" runat="server" Height="48px" Style="left: 549px; color: red;
            position: absolute; top: 163px" Width="140px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="Label3" runat="server" Style="left: 200px; color: red; position: absolute;
            top: 204px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    </form>
</body>
</html>
