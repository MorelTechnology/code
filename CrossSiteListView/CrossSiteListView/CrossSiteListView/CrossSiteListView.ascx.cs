using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.Utilities;
using System.Text;

namespace CrossSiteListView.CrossSiteListView
{
    [ToolboxItemAttribute(false)]
    public partial class CrossSiteListView : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public CrossSiteListView()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            EnsureChildControls();
            if (!this.Page.IsPostBack)
            {
                RenderContents();
            }
        }


        protected void RenderContents()
        {
            
            // Create a new client script instance on the page.
            String scriptName = "Invoke_" + ID; // this needs to be unique, in order to support multiple instances per page.
            Type scriptType = this.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager scriptInstance = Page.ClientScript;
            // Check to see if the script is already registered.
            if (!scriptInstance.IsStartupScriptRegistered(scriptType, scriptName))
            {
                StringBuilder scriptPayload = new StringBuilder();
                if (_includeJQuery) // determine if JQuery library needs to be referenced.
                {
                    scriptPayload.Append("<script type=text/javascript ");
                    scriptPayload.Append("charset='utf8' ");
                    scriptPayload.Append("src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.1.0.min.js'>");
                    scriptPayload.Append("</script>");
                }
                scriptPayload.Append("<script type=text/javascript>");
                scriptPayload.Append("LoadAnyListView('");
                scriptPayload.Append(_sourceSiteUrl + "','" + _listName + "','" + _listViewTitle + "','" + ClientID + "',");
                if (_linksInNewWindow) { scriptPayload.Append("1,"); } else { scriptPayload.Append("0,"); } //problem passing t/f boolean?
                if (_NormalizeTable) { scriptPayload.Append("1"); } else { scriptPayload.Append("0"); } //problem passing t/f boolean?
                scriptPayload.Append(");</script>");
                scriptInstance.RegisterStartupScript(scriptType, scriptName, scriptPayload.ToString());
            }

        }
        [WebBrowsable(true),
        WebDisplayName("Source Site URL"),
        WebDescription("Enter the URL of the site which contains the list or library that you wish to import."),
        Personalizable(PersonalizationScope.Shared),
        Category("Data Source Settings")]
        public string _sourceSiteUrl { get; set; }

        [WebBrowsable(true),
        WebDisplayName("Source list/library name"),
        WebDescription("Enter the name of the list or library which contains data that you wish to import. (Case Sensitive)"),
        Personalizable(PersonalizationScope.Shared),
        Category("Data Source Settings")]
        public string _listName { get; set; }

        [WebBrowsable(true),
        WebDisplayName("Existing View Title (Case Sensitive)"),
        WebDescription("Enter the name of a view from the list or library to display."),
        Personalizable(PersonalizationScope.Shared),
        Category("Data Source Settings")]
        public string _listViewTitle { get; set; }

        private Boolean _lnkNW = false;
        [WebBrowsable(true),
         WebDisplayName("Force any links to open in new tab/window."),
         WebDescription("This option will modify any links in the data to open " +
            "in a new tab or window, based on browser setting."),         
         Personalizable(PersonalizationScope.Shared),
         Category("Advanced Rendering Settings")]
        public Boolean _linksInNewWindow
        {
            get { return _lnkNW; }
            set { _lnkNW = value; }
        }

        private Boolean _nrmTbl = false;
        [WebBrowsable(true),
         WebDisplayName("Normalize Table"),
         WebDescription("This option will modify the view display to show " +
            "only the data, suppressing column headers, item selection checkboxes and " + 
            "remove the extra whitespace padding between entries."),
         Personalizable(PersonalizationScope.Shared),
         Category("Advanced Rendering Settings")]
        public Boolean _NormalizeTable
        {
            get { return _nrmTbl; }
            set { _nrmTbl = value; }
        }

        private Boolean _incJQ = false;
        [WebBrowsable(true),
         WebDisplayName("Include JQuery Reference"),
         WebDescription("This webpart requires JQuery.  " +
            "Select this option only if your page does not already import a JQuery library. "+
            "*Warning: Multiple references may break your page!")
         Personalizable(PersonalizationScope.Shared),
         Category("Advanced Rendering Settings")]
        public Boolean _includeJQuery
        {
            get { return _incJQ; }
            set { _incJQ = value; }
        }

    }
   


}
