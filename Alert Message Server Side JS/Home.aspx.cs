using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //redirect with only message
        string message = "Welcome Mr. " + txtName.Text.ToUpper() + ", Please carry on !";
        string href = "Welcome.aspx";
        string script = $"alert('{message}');location.href = '{href}';";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "messageScript", script, true);
    }
}