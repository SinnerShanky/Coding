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
public partial class Download : System.Web.UI.Page
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

            string text1 = Session["userName"].ToString();
            l1.Text = " Hello " + text1;

            HyperLink hp12 = (HyperLink)Master.FindControl("HPL_Home");
            hp12.Visible = false;
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
    protected void FillTreeView()
    {
        TreeNode tnode;
        string text = Session["userName"].ToString();
        string fsqry;
        fsqry = " Select count(Bv_attach_id) from attachDetails where BV_uname like '"+ text +"' ";
         Common c = new Common();
         c.openConnection();
         int a = c.executeScalar(fsqry);
        if(a>0)
        {
            lbl_Mssg12.Text = " Files Found = " + a.ToString();
            fsqry = " Select (BV_fol_id) from attachDetails where BV_uname like '" + text + "' group by(BV_fol_id)";
            DataTable dataTable = new DataTable();
            dataTable = c.getTable(fsqry);
           

            foreach (DataRow datarow in dataTable.Rows)
            {
                c.openConnection();
                tnode = new TreeNode();
                fsqry = " Select Bv_fol_name from folderName where BV_fol_id= "+ datarow["BV_fol_id"].ToString() +"  ";
                SqlDataReader dataReader;
                dataReader = c.executeReader(fsqry);
                dataReader.Read();
                tnode.Text = dataReader["BV_fol_name"].ToString();
                tnode.Value = datarow["BV_fol_id"].ToString();
                TreeView.Nodes.Add(tnode);
                LoadDocs(tnode);
                c.closeConnection();
            }
            

        }
        else
        {
            lbl_Mssg12.Text = " No records found ";
        }

    }
    protected void LoadDocs(TreeNode tnode)
    {
        string a= tnode.Value;
        TreeNode subnode;
        string fsqry;
        string text = Session["userName"].ToString();
        fsqry = " Select BV_attach_path,BV_attach_name from attachDetails where BV_fol_id='"+ a +"' and BV_uname like '" + text + "' ";
        Common c = new Common();
        c.openConnection();

        DataTable dataTable = new DataTable();
        dataTable = c.getTable(fsqry);
        foreach (DataRow datarow in dataTable.Rows)
        {
            c.openConnection();
            subnode = new TreeNode();
            subnode.Text = datarow["Bv_attach_name"].ToString();
            subnode.Value = datarow["BV_attach_path"].ToString();
            tnode.ChildNodes.Add(subnode);
            c.closeConnection();
        }


    }

    protected void find_Click(object sender, EventArgs e)
    {
        FillTreeView();
    }
    protected void TreeView_SelectedNodeChanged(object sender, EventArgs e)
    {
        ViewState["value"] = TreeView.SelectedNode.Value;
        String path = ViewState["value"].ToString();
        if(path.Contains("C:"))
        { FileDownload(path); }
        else 
        {
            lbl_Mssg12.Text = "Please select a File";}
    }
    protected void FileDownload(String path12)
    {

        String filePath;
        String lsfileType;
        filePath = path12.Substring(path12.LastIndexOf(";") + 1);
        lsfileType = filePath.Substring(filePath.LastIndexOf(".") + 1);

        System.IO.FileInfo file = new System.IO.FileInfo(filePath);

        if(file.Exists)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/vnd." + lsfileType;
            Response.WriteFile(file.FullName);
        }

        TreeView.Focus();

    }
}
