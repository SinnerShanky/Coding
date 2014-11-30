using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)Master.FindControl("lbtn_signin");
        lbtn.Visible = false;

        HyperLink hpl = (HyperLink)Master.FindControl("HPL_Dashboard");
        hpl.Visible = true;

        if (Session["userName"] != null)
        {
            
            LinkButton lbtn1 = (LinkButton)Master.FindControl("lbtn_signout");
            lbtn1.Visible = true;
            HyperLink hp = (HyperLink)Master.FindControl("HPL_UserDashboard");
            hp.Visible = true;
            Label l1 = (Label)Master.FindControl("hello");

            HyperLink hp1 = (HyperLink)Master.FindControl("HPL_Home");
            hp1.Visible = false;
            HyperLink hp12 = (HyperLink)Master.FindControl("HPL_Home");
            hp12.Visible = false;


            l1.Visible = true;
            LinkButton lbtn12 = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn12.Visible = false;

            string text1 = Session["userName"].ToString();
            l1.Text = " Hello " + text1;

        }
        else
        {

        }
  
     
    }
    protected void lbtn_viewUsers_Click(object sender, EventArgs e)
    {
        gv_view.Visible = true;
        lbl_add_fol.Visible = false;
        btn_add_fol.Visible = false;
        txt_add_fol.Visible = false;

        btn_add_QZ.Visible = false;
        lbl_add_QZ.Visible = false;
        txt_add_QZ.Visible = false;

        lbl_mssg.Text = " ";
        Common c = new Common();
        c.openConnection();
        String fsqry = "Select * from userDetails ";
        SqlDataReader dataReader = c.executeReader(fsqry);
        fillGridView(dataReader);
    }
    protected void lbtn_Folder_Click(object sender, EventArgs e)
    {
    
        lbl_add_fol.Visible=true;
        btn_add_fol.Visible=true;
        txt_add_fol.Visible = true;

        btn_add_QZ.Visible = false;
        lbl_add_QZ.Visible = false;
        txt_add_QZ.Visible = false;

        lbl_mssg.Text = " ";

        gv_view.Visible = true;

        Common c = new Common();
        c.openConnection();
        String fsqry = "Select BV_fol_id as ID, BV_fol_name as FolderName from folderName ";
        SqlDataReader dataReader = c.executeReader(fsqry);
        fillGridView(dataReader);

        lbl_add_fol.Text = "Add Folder";
        btn_add_fol.Text = " Add Folder";

        c.closeConnection();
    }
    protected void lbtn_qz_Click(object sender, EventArgs e)
    {
        gv_view.Visible = true;
        Common c = new Common();
        c.openConnection();
        String fsqry = "Select BV_qz_id as ID,BV_qz as Security_Question from forgotPasswordQZ ";
        SqlDataReader dataReader = c.executeReader(fsqry);
        fillGridView(dataReader);
        lbl_add_QZ.Text = "Add Security Question";
        btn_add_QZ.Text = "Add Question";

        btn_add_QZ.Visible = true;
        lbl_add_QZ.Visible = true;
        txt_add_QZ.Visible = true;
        lbl_add_fol.Visible = false;
        btn_add_fol.Visible = false;
        txt_add_fol.Visible = false;
        lbl_mssg.Text = " ";
        c.closeConnection();

    }
    protected void fillGridView(SqlDataReader dataReader)
    {
        gv_view.DataSource = dataReader;
        gv_view.DataBind();
    }

    protected void btn_add_QZ_Click(object sender, EventArgs e)
    {
        if (txt_add_QZ.Text == "")
        { lbl_mssg.Text = "Please enter valid question"; return; }
        Common c = new Common();
        c.openConnection();
        string fsqry = "Select count(BV_qz) from forgotPasswordQZ where BV_qz like '"+ txt_add_QZ.Text +"' ";
        int a = c.executeScalar(fsqry);
        if (a==0)
        {
            fsqry = "insert into forgotPasswordQZ (BV_qz) values('"+ txt_add_QZ.Text +"')";
            c.executeNonQuery(fsqry);
            lbl_mssg.Text = " Question Added Successfully";

        }
        else {lbl_mssg.Text = "Question is already Present" ;}

         fsqry = "Select BV_qz_id as ID,BV_qz as Security_Question from forgotPasswordQZ ";
        SqlDataReader dataReader = c.executeReader(fsqry);
        fillGridView(dataReader);
        txt_add_QZ.Text = "";
        c.closeConnection();
    }
protected void btn_add_fol_Click(object sender, EventArgs e)
{
    if(txt_add_fol.Text == "")
    { lbl_mssg.Text = "Please enter valid folder name"; return; }
    Common c = new Common();
    c.openConnection();
    string fsqry = "Select count(BV_fol_name) from folderName where BV_fol_name like '" + txt_add_fol.Text + "' ";
    int a = c.executeScalar(fsqry);
    if (a == 0)
    {
        fsqry = "insert into folderName (BV_fol_name) values('" + txt_add_fol.Text + "')";
        c.executeNonQuery(fsqry);
        lbl_mssg.Text = " Folder Added Successfully";

    }
    else { lbl_mssg.Text = "Folder already exists"; }

    fsqry = "Select BV_fol_id as ID, BV_fol_name as FolderName from folderName  ";
    SqlDataReader dataReader = c.executeReader(fsqry);
    fillGridView(dataReader);
    txt_add_fol.Text = " ";
    c.closeConnection();
}
}
