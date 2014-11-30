using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.IO;
//imports System.IO.DirectoryInfo;


public partial class Upload : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)Master.FindControl("lbtn_signin");
        lbtn.Visible = false;
        if (!this.IsPostBack)
        {
            FillFiles();
        }

        if (Session["userName"] != null)
        {
            LinkButton lbtn1 = (LinkButton)Master.FindControl("lbtn_signout");
            lbtn1.Visible = true;
            HyperLink hp = (HyperLink)Master.FindControl("HPL_UserDashboard");
            hp.Visible = true;
            Label l1 = (Label)Master.FindControl("hello");

            l1.Visible = true;
            LinkButton lbtn12 = (LinkButton)Master.FindControl("lbtn_signin");
            lbtn12.Visible = false;

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
    protected void FillFiles()
    {
        Common c = new Common();
        c.openConnection();
        string fsqry = " Select * from folderName";
        DataTable dataTable =  c.getTable(fsqry);

        ddl_ftype.DataSource = dataTable;
        ddl_ftype.DataTextField = "BV_fol_name";
        ddl_ftype.DataValueField = "BV_fol_id";
        ddl_ftype.DataBind();
        c.closeConnection();
    }

    

    protected void btn_submit_Click(object sender, EventArgs e)
    {

        lbl_mssg.Text = "";
        if (txt_fname.Text =="")
        { lbl_mssg.Text = "Please add file name"; return; }
        if (txt_file.PostedFile.FileName == "")
        { lbl_mssg.Text = " please select a file "; return; }
        Common c = new Common();
        c.openConnection();

        string[] validExtensions = { ".xls", ".doc", ".txt", ".jpg", ".bmp", ".pdf", ".jpeg", ".msg", ".xlsx", ".docx", ".zip", ".rar", ".ppt", ".pptx" };
        string filePath = txt_file.PostedFile.FileName;
        string fileName = Path.GetFileName(filePath);
        string fileExtension = Path.GetExtension(filePath);

        bool valid = false;

        foreach (string extn in validExtensions)
        {
            valid = fileExtension.Equals(extn);
            if (valid)
                break;
        }

        if (valid)
        {

            string userName = Session["userName"].ToString();
            string uploadLocation = "C:/Attachments/" + userName + "/" + ddl_ftype.SelectedItem.ToString() + "/";
            string path = uploadLocation + fileName;
            bool available = File.Exists(path);

            if (!available)
            {
                if (Directory.Exists(uploadLocation))
                {
                    txt_file.SaveAs(uploadLocation + fileName);
                }
                else
                {
                    Directory.CreateDirectory(uploadLocation);
                    txt_file.SaveAs(uploadLocation + fileName);
                }

                string fsqry = " insert into attachDetails (BV_attach_path, BV_attach_name, BV_fol_id, BV_uname) values ";
                fsqry += " ('" + path + "','" + txt_fname.Text + "'," + ddl_ftype.SelectedValue + ",'" + userName + "')";

                int a = c.executeNonQuery(fsqry);
                if (a == 1)
                {
                    lbl_mssg.Text = "File Uploaded ";
                }
                else
                { lbl_mssg.Text = " Error while uploading File "; }

            }
            else
            { lbl_mssg.Text = " File Already Exisits ";  }
        }
        else { lbl_mssg.Text = "Invalid File. Please try again"; }
        txt_fname.Text = "";
        ddl_ftype.ClearSelection();
       
    }

}