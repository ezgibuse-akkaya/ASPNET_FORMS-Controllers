using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class WizardController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if(e.NextStepIndex == 2)
            {
                lblFirstName.Text =txtFirstName.Text;
                lblLastName.Text =txtLastName.Text;
                lblGender.Text=ddlGender.Text;
                lblMobile.Text =txtMobile.Text;
                lblEmail.Text =txtEmail.Text;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("~/MultiviewPage.aspx");
        }
    }
}