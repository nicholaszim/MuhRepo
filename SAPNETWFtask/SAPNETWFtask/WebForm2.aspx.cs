using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAPNETWFtask
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page LastPage = (Page)Context.Handler;
                if (LastPage is WebForm1)
                {
                    LabelName2.Text = ((WebForm1)LastPage).Name;
                    LabelLName2.Text = ((WebForm1)LastPage).LName;
                    LabelEmail2.Text = ((WebForm1)LastPage).Email1;
                    LabelWE2.Text = ((WebForm1)LastPage).WorkExp;
                    LabelEdu2.Text = ((WebForm1)LastPage).Educations;
                }
                //LabelName2.Text = ((TextBox)LastPage.FindControl("FNameTB")).Text;
                //LabelLName2.Text = ((TextBox)LastPage.FindControl("LNameTB")).Text;
                //LabelEmail2.Text = ((TextBox)LastPage.FindControl("Email")).Text;
                //LabelWE2.Text = ((TextBox)LastPage.FindControl("WorkingExp")).Text;
                //LabelEdu2.Text = ((TextBox)LastPage.FindControl("Education")).Text;
            }
        }
    }
}