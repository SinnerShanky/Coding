using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] != null)
        {
            Common c = new Common();
            c.openConnection();
            string query = "select id,problemStatement from problems";
            SqlDataReader probList = c.executeReader(query);
            grid1.DataSource = probList;
            grid1.DataBind();
           // int count = 1;
           /* while (probList.Read())
            {
                Problems.Text += count + ". " + probList["problemStatement"] + "<br>";
                count++;
            }*/
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Submission.aspx");
    }
}