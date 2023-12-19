using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // redirect with message and with parameter only on user cinfirmation
        string name = "Milind";
        string address = "Panvel";
        string state = "Maharashtra";
        string message = "Data updated successfully. You will now be redirected to the search page.";
        string redirectPage = "Welcome3.aspx";

        // Construct the URL with query parameters
        string redirectUrl = $"{redirectPage}?name={name}&address={address}&state={state}";

        // Construct the JavaScript code
        string script = $@"var r = confirm('{message}');
                  if (r == true) {{
                      location.href = '{redirectUrl}';
                  }}";

        // Register the JavaScript code
        ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectScript", script, true);
    }
}