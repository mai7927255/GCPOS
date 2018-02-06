using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //FormsAuthentication.SignOut();
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
                    FormsIdentity id =
                                  (FormsIdentity)HttpContext.Current.User.Identity;
                    FormsAuthenticationTicket ticket = id.Ticket;

                    // Get the stored user-data, in this case, our roles
                    string userData = ticket.UserData;

                    Response.Write(id.Ticket.Name);
                    Response.Write(id.Ticket.UserData);
        }

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if ((UserEmail.Text == "peerawat") &&
            (UserPass.Text == "peerawat"))
        {
            FormsAuthentication.SetAuthCookie(
                     UserEmail.Text, false);

            

            FormsAuthenticationTicket ticket1 =
               new FormsAuthenticationTicket(
                    1,                                   // version
                   UserEmail.Text,   // get username  from the form
                    DateTime.Now,                        // issue time is now
                    DateTime.Now.AddMinutes(10),         // expires in 10 minutes
                    false,     // cookie is not persistent
                    "HR"                              // role assignment is stored
                // in userData
                    );
            HttpCookie cookie1 = new HttpCookie(
              FormsAuthentication.FormsCookieName,
              FormsAuthentication.Encrypt(ticket1));
            Response.Cookies.Add(cookie1);

            // 4. Do the redirect. 
            String returnUrl1;
            // the login is successful
            if (Request.QueryString["ReturnUrl"] == null)
            {
                returnUrl1 = "/index.aspx";
            }

            //login not unsuccessful 
            else
            {
                returnUrl1 = Request.QueryString["ReturnUrl"];
            }
            Response.Redirect(returnUrl1);
        }
       
    }
}