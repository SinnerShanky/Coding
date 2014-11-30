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
    private string selectedLanguage = "C";
    private string code = "";
    private string input = "";
    private string output = "";
    private CodeRunner codeRun;
    private int problemID;
    private string expectedOutput;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        code = Code.Text;
        selectedLanguage = LanguageSelection.SelectedValue;
        int.TryParse(TextBox1.Text, out problemID);
        Common c = new Common();
        c.openConnection();
        string query = "select input,output from problems where Id=" + problemID;
        SqlDataReader data = c.executeReader(query);
        data.Read();
        input = data.GetString(0);
        expectedOutput = data.GetString(1);
        data.Close();
        codeRun = new CodeRunner(selectedLanguage, code, input);
        codeRun.runCode();
        System.Threading.Thread.Sleep(15000);
        output = codeRun.getOutput();
        Output.Text = "Output:\n" + output + "\n\nResult: ";
        if (output.Equals(expectedOutput))
            Output.Text += "Accepted";
        else
            Output.Text += "Wrong Answer";
        c.closeConnection();
    }
    protected void LanguageSelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedLanguage = LanguageSelection.DataValueField;
    }
}