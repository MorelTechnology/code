﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrossSiteListView.CrossSiteListView {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class CrossSiteListView {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink ScriptLink1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(CrossSiteListView target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlScriptLink1() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.ScriptLink1 = @__ctrl;
            @__ctrl.ID = "ScriptLink1";
            @__ctrl.Name = "/_layouts/15/CrossSiteListView/js/dataRetrievalFunctions.js";
            @__ctrl.Localizable = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::CrossSiteListView.CrossSiteListView.CrossSiteListView @__ctrl) {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl1;
            @__ctrl1 = this.@__BuildControlScriptLink1();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            parameterContainer.Controls[0].RenderControl(@__w);
            @__w.Write("\r\n<div id=\"A2O_Webpart_Status\">\r\n\r\n");
   if ((SPContext.Current.FormContext.FormMode == SPControlMode.Edit) || (HttpContext.Current.Request.Url.ToString().Contains("?PageView=")))
    { // Shell to Raw HTML//
            @__w.Write(@"
        <h3>This Page is in edit mode.<br />Save the page to view the results.</h3>
        <br />
        <b style=""color:red;"">Note:</b> This webpart has a few known 'bugs'.  
        <a href =""../_layouts/15/CrossSiteListView/defect-tracker.htm"" target=""_blank""><u>Read about them here.</u></a>
        <p><em><sub>This element id: #");
                              @__w.Write(ClientID);

            @__w.Write("</sub></em></p>\r\n");
  //ASPNET// 
    }
    else
    {// Shell to Raw HTML//
            @__w.Write("\r\n         <img src=\'../_layouts/15/images/CrossSiteListView/loading.gif\' style=\'" +
                    "width: 100px; height: 50px; padding: 25px;\'/>\r\n");
  //ASPNET// 
    }
    //ASPNET Closed//

            @__w.Write("\r\n</div>\r\n\r\n");
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
