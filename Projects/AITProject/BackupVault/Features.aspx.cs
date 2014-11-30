using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] != null)
        {
            LinkButton lbtn1 = (LinkButton)Master.FindControl("lbtn_signout");
            lbtn1.Visible = true;
            HyperLink hp = (HyperLink)Master.FindControl("HPL_UserDashboard");
            hp.Visible = true;
            Label l1 = (Label)Master.FindControl("hello");
            HyperLink hp4 = (HyperLink)Master.FindControl("HPL_home");
            hp4.Visible = false;
            l1.Visible = true;
            LinkButton lbtn = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn.Visible = false;

            string text1 = Session["userName"].ToString();
            l1.Text = " Hello " + text1;
            if (text1.Contains("admin"))
            {
                HyperLink hp12 = (HyperLink)Master.FindControl("HPL_Dashboard");
                hp12.Visible = true;
            }

        }
        else
        {
            LinkButton lbtn1 = (LinkButton)Master.FindControl("lbtn_signout");
            lbtn1.Visible = false;
            LinkButton lbtn12 = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn12.Visible = true;
            Label l112 = (Label)Master.FindControl("hello");
            l112.Visible = false;
            HyperLink hp1 = (HyperLink)Master.FindControl("HPL_UserDashboard");
            hp1.Visible = false;
            HyperLink hp14 = (HyperLink)Master.FindControl("HPL_home");
            hp14.Visible = true;
            HyperLink hp123 = (HyperLink)Master.FindControl("HPL_Dashboard");
            hp123.Visible = false;
        }
     
    }
}