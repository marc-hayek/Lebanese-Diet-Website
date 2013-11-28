<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DishEn.aspx.cs" Inherits="food_DishEn" %>

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
    <form id="form2" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" BackColor="SeaShell" Height="75px" Style="font-size: 50pt;
            left: 208px; position: absolute; top: 23px" Text="Healthy Lebanese Diet" Width="615px" ForeColor="LimeGreen"></asp:Label>
        &nbsp;
        <asp:Panel ID="Panel1" runat="server" BackColor="SeaShell" Height="877px" Style="border-left-color: black;
            left: 272px; border-bottom-color: black; border-top-style: groove; border-top-color: black;
            border-right-style: groove; border-left-style: groove; position: absolute; top: 113px;
            border-right-color: black; border-bottom-style: groove" Width="610px" ForeColor="LavenderBlush">
            &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Button ID="addingbut" runat="server" OnClick="addingbut_Click" Style="left: 154px;
                position: absolute; top: 4px" Text="Add New Dish" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="left: 30px;
            position: absolute; top: 5px" Text="View Dishes" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </asp:Panel>
        &nbsp;
        <asp:Panel ID="Panel3" runat="server" Height="365px" Style="border-left-color: #000000;
            left: 317px; border-bottom-color: #000000; border-top-style: groove; border-top-color: #000000;
            border-right-style: groove; border-left-style: groove; position: absolute; top: 604px;
            background-color: activeborder; border-right-color: #000000; border-bottom-style: groove"
            Width="541px">
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True"
                Style="left: 87px; position: absolute; top: 23px" Text="Add New Dish"></asp:Label>
            <table style="left: 43px; width: 354px; position: absolute; top: 53px; height: 1px">
                <tr>
                    <td style="width: 193px; height: 15px">
                        <asp:Label ID="Label8" runat="server" Text="Dish Name in English"></asp:Label></td>
                    <td style="width: 173px; height: 15px">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            &nbsp; <asp:RequiredFieldValidator 
             id="RequiredFieldValidator1" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox5" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px; height: 26px">
                        <asp:Label ID="Label18" runat="server" Text="Dish Name in Arabic"></asp:Label></td>
                    <td style="width: 173px; height: 26px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp; <asp:RequiredFieldValidator 
             id="RequiredFieldValidator2" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox1" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px">
                        <asp:Label ID="Label9" runat="server" Text="Calories"></asp:Label></td>
                    <td style="width: 173px">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator6" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox6" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px">
                        <asp:Label ID="Label19" runat="server" Text="Units"></asp:Label></td>
                    <td style="width: 173px">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator3" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox2" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px">
                        <asp:Label ID="Label20" runat="server" Text="Vitamins"></asp:Label></td>
                    <td style="width: 173px">
                        <asp:TextBox ID="TextBox3"  runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator4" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox3" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px">
                        <asp:Label ID="Label10" runat="server" Text="Health Benefits (English)"></asp:Label></td>
                    <td style="width: 173px">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator7" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox7" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px; height: 27px;">
                        <asp:Label ID="Label21" runat="server" Text="Health Benefits (Arabic)"></asp:Label></td>
                    <td style="width: 173px; height: 27px;">
                        <asp:TextBox ID="TextBox4"  runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator5" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox4" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px; height: 27px">
                        <asp:Label ID="Label11" runat="server" Text="Instructions (English)"></asp:Label></td>
                    <td style="width: 173px; height: 27px">
                        <asp:TextBox ID="TextBox8"  runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator8" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox8" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px; height: 27px">
                        <asp:Label ID="Label22" runat="server" Text="Instructions (Arabic)"></asp:Label></td>
                    <td style="width: 173px; height: 27px">
                        <asp:TextBox ID="TextBox9"  runat="server"></asp:TextBox>
                        &nbsp; 
                        <asp:RequiredFieldValidator 
             id="RequiredFieldValidator9" validationgroup="InfoGroup" runat="server" 
             ErrorMessage="Required!" 
             ControlToValidate="TextBox9" style="position: absolute">
            </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 193px; height: 32px;">
                    </td>
                    <td style="width: 173px; height: 32px;">
                        <asp:Button ID="Button1" 
      causesvalidation="true"
      validationgroup="InfoGroup" runat="server" OnClick="Button1_Click" Text="Add" Height="30px" Width="100px" /></td>
               
     
                </tr>
            </table>
        </asp:Panel>
        <table style="left: 127px; position: absolute; top: 111px; height: 207px">
            <tr>
                <td style="width: 127px">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Underline="False"
                        ForeColor="Black" NavigateUrl="~/food/Default.aspx">Home</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 127px">
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True">About Us</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 127px">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Underline="False" ForeColor="Black" NavigateUrl="~/food/DishEn.aspx">Healthy Meals</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 127px">
                    <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" Font-Underline="False"
                        ForeColor="Black" NavigateUrl="~/food/English.aspx">Ingredients</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="width: 127px">
                    <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True">Contact Us</asp:HyperLink></td>
            </tr>
        </table>
        <asp:HyperLink ID="HyperLink6" runat="server" Font-Bold="True" Style="left: 832px;
            position: absolute; top: 67px">عربي</asp:HyperLink>
        <asp:HyperLink ID="HyperLink7" runat="server" Style="left: 833px; position: absolute;
            top: 36px">English</asp:HyperLink>
        &nbsp; &nbsp;
        <table style="left: 305px; position: absolute; top: 153px; height: 294px" id="TABLE1" onclick="return TABLE1_onclick()">
            <tr>
                <td style="width: 141px; height: 21px">
                    <asp:Label ID="Label2" runat="server" Text="Dishes:"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 141px; height: 149px">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="148px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"
                        Width="141px"></asp:ListBox>&nbsp;
                </td>
                <td style="width: 100px; height: 149px">
                </td>
            </tr>
            <tr>
                <td style="width: 141px; height: 21px;">
                    <asp:Label ID="Label3" runat="server" Text="Calories:"></asp:Label></td>
                <td style="width: 100px; height: 21px;">
                    <asp:Label ID="Label13" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 141px">
                    <asp:Label ID="Label4" runat="server" Text="Vitamins:"></asp:Label></td>
                <td style="width: 100px">
                    <asp:Label ID="Label14" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 141px">
                    <asp:Label ID="Label6" runat="server" Text="Health Benefits:"></asp:Label></td>
                <td style="width: 100px">
                    <asp:Label ID="Label16" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 141px; height: 21px">
                    <asp:Label ID="Label12" runat="server" Text="Instructions:"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
            </tr>
            <tr>
                <td style="width: 141px; height: 21px">
                    <asp:Label ID="Label5" runat="server" Text="Ingredients:"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 141px; height: 21px">
                    <asp:ListBox ID="ListBox2" runat="server" Width="140px"></asp:ListBox></td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;
        
        <asp:Image ID="Image1" runat="server" Height="143px" Style="left: 613px; position: absolute;
            top: 298px" Width="234px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="left: 611px; width: 240px; position: absolute; top: 125px">
            <tr>
                <td style="width: 71px">
                    Username</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 71px">
                    Password</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Label ID="Label24" runat="server" Height="43px" Style="left: 716px; color: red;
            position: absolute; top: 190px" Width="134px"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Style="left: 658px;
            position: absolute; top: 191px">Register</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Style="left: 612px;
            position: absolute; top: 191px" Visible="False">Logout</asp:LinkButton>
        <asp:Label ID="Label23" runat="server" Style="left: 611px; color: red; position: absolute;
            top: 216px" Width="160px"></asp:Label>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Style="left: 612px;
            position: absolute; top: 191px">Login</asp:LinkButton>
    </div>
    </form>
</body>
</html>
