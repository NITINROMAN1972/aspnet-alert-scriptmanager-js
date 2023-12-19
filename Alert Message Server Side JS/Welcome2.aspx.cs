using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve query parameters
        string name = Request.QueryString["name"];
        string address = Request.QueryString["address"];
        string state = Request.QueryString["state"];

        BindTextBox(name, address, state);
    }

    protected void BindTextBox(string name, string address, string state)
    {
        txtName.Text = name;
        txtAddrss.Text = address;
        txtState.Text = state;
    }
}