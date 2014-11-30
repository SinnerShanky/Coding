using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void loginLink_Click(object sender, EventArgs e)
    {
        Server.Transfer("Login.aspx");
    }
    protected void logoutLink_Click(object sender, EventArgs e)
    {
        Session["userName"] = null;
        Server.Transfer("Logout.aspx");
    }
    protected void problemsLink_Click(object sender, EventArgs e)
    {
        Server.Transfer("ProblemList.aspx");
    }
    public void valuesSet(string user)
    {
        userID.Text = user;
        userID.Visible = true;
        loginLink.Visible = false;
        logoutLink.Visible = true;
        problemsLink.Visible = true;
    }
}
