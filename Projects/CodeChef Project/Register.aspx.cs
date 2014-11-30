using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        Common c = new Common();
        string userID = user.Text;
        string password = pass.Text;
        string q = "insert into Users values ('" + userID + "','" + password + "',0)";
        c.openConnection();
        int val = c.executeNonQuery(q);
        c.closeConnection();
        Server.Transfer("Login.aspx");
    }
    protected void user_TextChanged(object sender, EventArgs e)
    {

    }
    protected void pass_TextChanged(object sender, EventArgs e)
    {

    }
}