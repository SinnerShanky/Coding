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
    protected void HPL_signin_Click(object sender, EventArgs e)
    {
        lbtn_signin.Visible = false;
        Server.Transfer("Home.aspx");
    }
    protected void lbtn_signout_Click(object sender, EventArgs e)
    {
        Session["userName"] = null;
        Server.Transfer("Logout.aspx");
    }
}
