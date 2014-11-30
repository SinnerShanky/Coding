using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label l1 = (Label)Master.FindControl("hello");
        l1.Visible = false;
        LinkButton l2 = (LinkButton)Master.FindControl("lbtn_signin");
        l2.Visible = false;
        LinkButton l3 = (LinkButton)Master.FindControl("lbtn_signout");
        l3.Visible = false;
        HyperLink h1 = (HyperLink)Master.FindControl("HPL_Home");
        h1.Visible = false;
        HyperLink h2 = (HyperLink)Master.FindControl("HPL_UserDashboard");
        h2.Visible = false;
        HyperLink h3 = (HyperLink)Master.FindControl("HPL_Dashboard");
        h3.Visible = false;
        HyperLink h4 = (HyperLink)Master.FindControl("HPL_Features");
        h4.Visible = false;
        Session.Abandon();

    }
}