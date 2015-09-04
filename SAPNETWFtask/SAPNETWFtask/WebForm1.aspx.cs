using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAPNETWFtask
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string Name 
        {
            get
            {
                return FNameTB.Text;
            }
        }

        public string LName
        {
            get
            {
                return LNameTB.Text;
            }
        }
        public string Email1
        {
            get
            {
                return Email.Text;
            }
        }
        public string WorkExp
        {
            get
            {
                return WorkingExp.Text;
            }
        }
        public string Educations
        {
            get
            {
                return Education.Text;
            }
        }
        public string ForeignLangs
        {
            get
            {
                return CheckBoxListFl;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDisplay_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");
        }
    }
}