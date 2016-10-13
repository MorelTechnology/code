function LoadAnyListView(sourceSiteUrl, listName, listViewTitle, displayLocation, openLinksInNewWindow, normalizeTable) {

    if (!window.jQuery) //JQuery Check
    { document.getElementById("A2O_Webpart_Status").innerHTML = ("<b style='color:red;'>Warning: JQuery Required. </b><br />" +
            "This page does not appear to have a JQuery reference.  Unless you plan to add one elsewhere, be sure to select " +
            "<em>Include JQuery Reference</em> in this webpart's settings.");
      throw new Error("Missing JQuery Reference."); }

    var promise = $.ajax({
        url: sourceSiteUrl + "/_api/web/lists/getbytitle('"
            + listName + "')/views/getbytitle('"
            + listViewTitle + "')/renderAsHtml()",
        type: "GET",
        dataType: "json", 
        headers: {
            Accept: "application/json;odata=verbose"
        }
    });
    promise.done(function (data, textStatus, jqXHR) {
        $('#'+displayLocation).html(data.d.RenderAsHtml);
        if (openLinksInNewWindow) { $('#' + displayLocation + ' a').attr('target', '_blank'); }
        if (normalizeTable)
        {
            $('#' + displayLocation).prepend('<style> #' + displayLocation + ' th,.ms-vb-firstCell{display:none;} ' +
                '#' + displayLocation + ' .ms-listviewtable .ms-itmhover {height: 0px;!important;} </style>');
        }
    });
    promise.fail(function (jqXHR, textStatus, errorThrown) {
        $('#' + displayLocation).html("<b>Error:</b> Please check webpart configuration settings.<br /><br />" +
            "<b>Additional information:</b> " + jqXHR.status + " " + errorThrown + ".<br /><em>" + jqXHR.responseText + "</em><br /><br />" +
            "<b>This Webpart element id:</b> #"+displayLocation);
    });
}
