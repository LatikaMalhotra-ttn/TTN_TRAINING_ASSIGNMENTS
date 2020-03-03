using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Ques_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\Latika Malhotra\Desktop\ADO_ASSIGNMENT\Ques_9\XMLFile1.xml");
            Response.Write("<div class='container'>");
            Response.Write("<h3 class='mt-3'><center>Names<center></h3>");
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "name":
                                Response.Write("<div class='alert alert-info'>");
                                break;
                            default:
                                Response.Write("<b>");
                                break;
                        }
                        break;
                    case XmlNodeType.Text:
                        Response.Write(xmlReader.Value + " ");
                        break;
                    case XmlNodeType.EndElement:
                        switch (xmlReader.Name)
                        {
                            case "name":
                                Response.Write("</div>");
                                break;
                            default:
                                Response.Write("</b>");
                                break;
                        }
                        break;

                }
            }
            Response.Write("</div>");
        }
    }
}