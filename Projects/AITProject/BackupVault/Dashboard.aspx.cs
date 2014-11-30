using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
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

            l1.Visible = true;
            LinkButton lbtn = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn.Visible = false;

            HyperLink hp12 = (HyperLink)Master.FindControl("HPL_Home");
            hp12.Visible = false;

            string text1 = Session["userName"].ToString();
            l1.Text = " Hello " + text1;

            if (text1.Contains("admin"))
            {
                HyperLink lbt = (HyperLink)Master.FindControl("HPL_Dashboard");
                lbt.Visible = true;
            }

        }
        else
        {

        }
    }
    protected void upload_Click(object sender, EventArgs e)
    {
        Server.Transfer("Upload.aspx");
    }
    protected void download_Click(object sender, EventArgs e)
    {
        Server.Transfer("Download.aspx");
    }

    
}