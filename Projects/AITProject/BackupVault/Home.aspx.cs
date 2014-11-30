using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Home : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    
{
        lbl_mssg.Text = " ";
        lbl_mssg2.Text = " ";
        lbl_mssg3.Text = " ";
        if(!this.IsPostBack)
        {
            FillDropDown();
        }
        if(Session["userName"] != null)
        {
            LinkButton lbtn1 = (LinkButton)Master.FindControl("lbtn_signout");
            lbtn1.Visible = true;
            HyperLink hp = (HyperLink)Master.FindControl("HPL_UserDashboard");
            hp.Visible = true;
            Label l1 = (Label)Master.FindControl("hello");

            

            l1.Visible = true;
            LinkButton lbtn = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn.Visible = false;

            string text1 = Session["userName"].ToString();
            l1.Text = " Hello " + text1;

        }
        else
        {

        }
     

    }
    protected void btn_Login_Click(object sender, EventArgs e)
    {
       int z = validateLogin();
       if (z == 0)
       { return; }
     
        string text="";
        lbl_mssg.Text = " ";
        tbl_SignIN.Visible = true;
        tbl_forgot.Visible = false;
        Common c = new Common();
        c.openConnection();
        String fsqry = "Select count(BV_uname) from userNameTable where BV_uname like '"+ txt_Uname.Text +"' and BV_pass like '"+ txt_Pass.Text +"'   ";
        int a = c.executeScalar(fsqry);
        if(a==1)
        {
            fsqry = "Select BV_name from userDetails where BV_uname like '" + txt_Uname.Text + "' ";
            SqlDataReader dataReader = c.executeReader(fsqry);
            if (dataReader.HasRows)
            {
                dataReader.Read();
                text = dataReader["BV_name"].ToString();
                Session["userName"] = txt_Uname.Text;
               
            }
            if (txt_Uname.Text.Contains("admin"))
            { Server.Transfer("Admin.aspx"); }
            else { Server.Transfer("Dashboard.aspx");  }
        }
        else if (a!=1)
        { lbl_mssg.Text = "Please check username/password "; }
        c.closeConnection();
      
    }
    protected int validateLogin()
    {
        if (txt_Uname.Text == "")
        {
            lbl_mssg.Text = "Enter Username";
            return 0;
        }
        if (txt_Pass.Text == "")
        { lbl_mssg.Text = "Enter Password"; return 0; }
        return 1;

    }
    protected void lbtn_Pass_Click(object sender, EventArgs e)
    {
        tbl_SignIN.Visible = false;
        tbl_forgot.Visible = true;
    }
    protected void btn_again_Click(object sender, EventArgs e)
    {
        int z = validateForgot();
        if(z==0)
        { return; }
        lbl_mssg2.Text = " ";
        Common c = new Common();
        c.openConnection();
        string fsqry = "Select count(BV_uname) from userNameTable where BV_uname like '" + txt_uname2.Text + "' ";
        int a = c.executeScalar(fsqry);
        if(a==1)
        {
            
            fsqry = " Update userNameTable set BV_pass = '"+ txt_newPass.Text +"' where BV_uname like '" + txt_uname2.Text + "' ";
            int b = c.executeNonQuery(fsqry);
            if (b==1)
            { lbl_mssg2.Text = "Password changed"; }
            else {lbl_mssg2.Text = "Password change unsuccessfull"; }
        }
        else
        { lbl_mssg2.Text = "Please check username.Try again"; }

        c.closeConnection();
    }

    protected int validateForgot()
    {
        if(txt_uname2.Text=="")
        { lbl_mssg2.Text = " Enter Username "; return 0; }
        if (txt_newPass.Text=="")
        { lbl_mssg2.Text = "Enter password"; return 0; }
        if(txt_again.Text=="")
        { lbl_mssg2.Text = "Enter password"; return 0; }
        if(txt_newPass.Text==txt_again.Text)
        { lbl_mssg2.Text = "Both passwords should match"; return 0; }
        return 1;
    }
    protected void btn_login2_Click(object sender, EventArgs e)
    {
        tbl_SignIN.Visible = true;
        tbl_forgot.Visible = false;
    }
    protected void btn_SignUp_Click(object sender, EventArgs e)
    {
        int z= ValidateSignUp();
        if(z==0)
        { return; }
        if (Convert.ToInt32(ViewState["flag"]) == 0) { lbl_mssg3.Text = "Please change username"; return; }
        Common c = new Common();
        c.openConnection();
        string fsqry = " insert into userDetails (BV_uname,BV_name,BV_dob,BV_gender,BV_email,BV_phone) values";
        fsqry += " ('" + txt_Uname1.Text + "','" + txt_Name.Text + "','" + txt_DOB.Text + "', '" + rdb_gen.SelectedValue + "', ";
        fsqry += "  '" + txt_email.Text + "','" + txt_Phone.Text + "')";
        int a = c.executeNonQuery(fsqry);
            if(a==1)
            {
                fsqry = "insert into userNameTable (BV_uname,BV_pass,BV_qz_id,BV_qz_ans) values";
                fsqry += "('" + txt_Uname1.Text + "','" + txt_Pass1.Text + "','" + ddl_SecretQz.SelectedIndex + "','" + txt_Ans.Text + "') ";
                int b = c.executeNonQuery(fsqry);
                if(b==1)
                { lbl_mssg3.Text = " Account Made. Login Now "; }
             }
            else
            {
                lbl_mssg3.Text = " Error while creating Account. Try Again ";
            }
            txt_Uname1.Text = "";
            txt_Ans.Text = "";
            txt_Name.Text = "";
            txt_DOB.Text = "";
            txt_email.Text = "";
            rdb_gen.ClearSelection();
            txt_Phone.Text = "";
            
    }
    protected int ValidateSignUp()
    {
        if(txt_Name.Text=="")
        { lbl_mssg3.Text = "Enter Name "; return 0; }
        if(txt_DOB.Text=="")
        { lbl_mssg3.Text = "Enter DOB "; return 0; }
        if(rdb_gen.SelectedValue=="" )
        { lbl_mssg3.Text = "Select Gender "; return 0; }
        if(txt_email.Text=="")
        { lbl_mssg3.Text = "Enter valid email "; return 0; }
        if(txt_Phone.Text=="")
        { lbl_mssg3.Text = "Enter valid phone "; return 0; }
        if(txt_Uname1.Text=="")
        { lbl_mssg3.Text = "Enter username "; return 0; }
        if(txt_Pass1.Text=="")
        { lbl_mssg3.Text = "Enter Password "; return 0; }
        if(txt_Repass1.Text=="")
        { lbl_mssg3.Text = "Re-enter Password "; return 0; }
        if(txt_Ans.Text=="")
        { lbl_mssg3.Text = "Enter Answer "; return 0; }
        if(txt_Pass1.Text!=txt_Repass1.Text)
        { lbl_mssg3.Text = "Passwords should match "; return 0; }
        return 1;
    }
    protected void btn_chk_Click(object sender, EventArgs e)
    {
        lbl_chk.Text = "";
        Common c = new Common();
        c.openConnection();
        string fsqry = " Select count(BV_uname) from userNameTable where BV_uname like '" + txt_Uname1.Text + "' ";
        int a = c.executeScalar(fsqry);
        if (a==0)
        { lbl_chk.Text = "Username available"; ViewState["flag"] = 1; }
        else
        { lbl_chk.Text = " Username already exists "; ViewState["flag"]=0;}
        c.closeConnection();
    }
    protected void FillDropDown()
    {
        Common c = new Common();
        c.openConnection();
        string fsqry = " Select * from forgotPasswordQZ";
        DataTable dataTable =  c.getTable(fsqry);
        ddl_SecretQz.DataSource = dataTable;
        ddl_SecretQz.DataTextField = "BV_qz";
        ddl_SecretQz.DataValueField = "BV_qz_id";
        ddl_SecretQz.DataBind();
        c.closeConnection();
    }
}