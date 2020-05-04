using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        { Label2.Text = "Page_PreInit";}   //first is PreInit event .It  this event happens just before page initialization event starts. 

        protected void Page_Init(object sender, EventArgs e)
        { Label3.Text = "Page_Init"; } //then init event happens, this event occurs after the Init event, of all the individual controls on the webform

        protected void Page_InitComplete(object sender, EventArgs e)
        { Label4.Text = "Page_InitComplete";  } //then initComplete event happens,  this event gets raised immediately after page initialization

        protected void Page_PreLoad(object sender, EventArgs e)
        { Label5.Text = "Page_PreLoad";  } //then Preload event happens, this happens just before the Page Load event.

        protected void Page_LoadComplete(object sender, EventArgs e)
        { Label6.Text = "Page_LoadComplete"; } //then loadComplete happens, this occurs before the load event of all the individual controls on that webform. 

        protected void Page_PreRender(object sender, EventArgs e)
        { Label7.Text = "Page_PreRender";  } // then preRender happens,  This event is raised just before the rendering stage of the page. 


        protected void Page_PreRenderComplete(object sender, EventArgs e)
        { Label8.Text = "Page_PreRenderComplete"; } //then PreRenderComplete happens, it Raised immediately after the PreRender event.

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br/>");   //this events does not take place because it happens after unload of page and page is destroyed at that time.
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
    }
}