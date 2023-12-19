# aspnet-alert-scriptmanager-js
apart from AlertMessage mrthod to show a pop up alert message at the top to notify certain important message to the user, but here if we redirect to other page then it wont work as the thread will be abanded, so we can use server side method using JavaScipt to render HTML code and send the alert prompt to the user which works even with redirect

Snippet page refernce  
https://www.codeproject.com/Tips/284507/how-to-show-the-message-and-redirect-to-other-page

### `using System.Web.UI;` name space is required

## 3 Types of ScriptManager codes

### 1. Alert message and Redirect
showing alert message to user and then redirecting from `Home` to `Welcome`  
`Home.aspx.cs`
```
//redirect with only message
string message = "Welcome Mr. " + txtName.Text.ToUpper() + ", Please carry on !";
string href = "Welcome.aspx";
string script = $"alert('{message}');location.href = '{href}';";
ScriptManager.RegisterStartupScript(this, this.GetType(), "messageScript", script, true);
```

### 2. Alert message and Redirect with parameters in URL
showing alert message to user and then redirecting from `Home2` to `Welcome2` while passing parameters in the url so to use those parameters in redirected page (for fetching the user details, etc)  
`Home2.aspx.cs`
```
// redirect with message and with parameter
string name = "Milind";
string address = "Panvel";
string state = "maharashtra";
string message = "Data updated successfully. You will now be redirected to the search page.";
string redirectUrl = $"Welcome2.aspx?name={name}&address={address}&state={state}";

string script = $"alert('{message}');location.href = '{redirectUrl}';";
ScriptManager.RegisterStartupScript(this, this.GetType(), "messageScript", script, true);
```  
`Welcome2.aspx.cs`  
```
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
```

### 3. Alert message and Redirect with parameters in URL with User confirmation (OK / Cancel)
showing alert message to user and then redirecting from `Home3` to `Welcome3` while passing parameters in the url so to use those parameters in redirected page, only when user clicks on `OK` button and if `cancel` button is clicked then redirecting stops  
`Home3.aspx.cs`  
```
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
```  
`Welcome3.aspx.cs`  
```
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
```
