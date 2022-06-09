using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealProjectB2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                divMsg.Visible = false;
            }
            else
            {
                divMsg.Visible = true;
                lblMsg.Text = "Username or password can't be empty";
            }
           
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text !="" && txtPassword.Text!="")
            //{
            //    if(txtUsername.Text == "admin" && txtPassword.Text == "123")
            //    {
            //        Response.Redirect("~/Dashboard.aspx");
            //    }

            //}
            if (CheckFieldValue() == false)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    Session["UserId"] = "1";
                    Session["UserName"] = "Batch 2";
                    Session["UserImg"] = "userimg.png";
                    Response.Redirect("~/Dashboard.aspx");
                }
                else
                {
                    lblMsg.Text = "Incorrect Username or password";
                    divMsg.Visible = true;
                    
                }
            }
        }
        private bool CheckFieldValue()
        {
            bool IsReq = false;
            if (txtUsername.Text == "")
            {
                lblMsg.Text = "Username can't be empty";
                txtUsername.Focus();
                IsReq = true;
            }
            else if (txtPassword.Text == "")
            {
                lblMsg.Text = "Password can't be empty";
                txtPassword.Focus();
                IsReq = true;
            }
            if(IsReq == true)
            {
                divMsg.Visible = true;
            }
            else
            {
                divMsg.Visible = false;
            }
            return IsReq;
        }
    }
}