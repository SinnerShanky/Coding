using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using com.ideone;
using System.Xml;
public class CodeRunner
{
    Ideone_Service_v1Service codeRunner;
    Dictionary<string, string> result; 
    private const string UserName = "sinnershanky",
                         Password = "shashank";
    private string selectedLanguage,
                    source,
                    input,
                    submissionId;
    Dictionary<string, int> languages = new Dictionary<string, int>();
	public CodeRunner()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public CodeRunner(string selectedLanguage, string source, string input)
    {
        codeRunner = new Ideone_Service_v1Service();
        this.selectedLanguage = selectedLanguage;
        this.source = source;
        this.input = input;
        languages.Add("C++", 44);
        languages.Add("C", 11);
        languages.Add("JAVA", 10);
    }
    public void runCode()
    {
        result = new Dictionary<string, string>();
        Object[] returnVal = codeRunner.createSubmission(UserName,Password,source,languages[selectedLanguage],input,true,true);
        foreach (object o in returnVal)
        {
            if (o is XmlElement)
            {
                XmlNodeList x = ((XmlElement)o).ChildNodes;
                result.Add(x.Item(0).InnerText, x.Item(1).InnerText);
            }
        }
        submissionId = result["link"];
    }
    public string getOutput()
    {
        Object[] returnVal = codeRunner.getSubmissionStatus(UserName, Password, submissionId);
        result = new Dictionary<string, string>();
        foreach (object o in returnVal)
        {
            if (o is XmlElement)
            {
                XmlNodeList x = ((XmlElement)o).ChildNodes;
                result.Add(x.Item(0).InnerText, x.Item(1).InnerText);
            }
        }
        if(!result["error"].Equals("OK"))
        {
            return "Error!";
        }
        else
        {
            result = new Dictionary<string, string>();
            returnVal = codeRunner.getSubmissionDetails(UserName, Password, submissionId,false,false,true,true,true);
            foreach (object o in returnVal)
            {
                if (o is XmlElement)
                {
                    XmlNodeList x = ((XmlElement)o).ChildNodes;
                    result.Add(x.Item(0).InnerText, x.Item(1).InnerText);
                }
            }
            return result["output"];
        }
    }
}