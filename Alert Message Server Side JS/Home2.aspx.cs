using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // redirect with message and with parameter
        string name = "Milind";
        string address = "Panvel";
        string state = "maharashtra";
        string message = "Data updated successfully. You will now be redirected to the search page.";
        string redirectUrl = $"Welcome2.aspx?name={name}&address={address}&state={state}";

        string script = $"alert('{message}');location.href = '{redirectUrl}';";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "messageScript", script, true);
    }
}