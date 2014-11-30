using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e) {
        string UserID = user.Text;
        string Password = password.Text;
        Common c = new Common();
        c.openConnection();
        string query = "select * from Users where userID='" + UserID+"'";//; + "and password=" + Password;
        
        SqlDataReader ps=c.executeReader(query);
        if(ps.Read())
        {
            if(ps["password"].Equals(Password))
            {
            Session["userName"] = UserID;
            try
            {
                //MasterPage mp = (MasterPage)Page.Master;
                //mp.valuesSet(UserID);
                Server.Transfer("ProblemList.aspx");
                //Response.Redirect("ProblemList.aspx");
            }
            catch (Exception errr) { }
            
            }
        }
    }
    protected void Register_Click(object sender, EventArgs e)
    {
        Server.Transfer("Register.aspx");
    }
}