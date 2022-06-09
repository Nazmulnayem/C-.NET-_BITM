using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealProjectB2.AdminLayout
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUsername.Text = Session["Username"].ToString();
                string userImg = Session["UserImg"].ToString();

                imgUser.ImageUrl = "~/Assets/img/Users/"+userImg;
            }
        }
    }
}