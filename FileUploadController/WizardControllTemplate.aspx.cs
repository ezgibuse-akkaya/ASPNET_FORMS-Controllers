using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class WizardControllTemplate : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if(Wizard1.ActiveStepIndex== 0)
            {
                Step1TextBox.Focus();
            }
           else if (Wizard1.ActiveStepIndex == 1)
            {
                Step2TextBox.Focus();
            }
          else  if (Wizard1.ActiveStepIndex == 2)
            {
                Step3TextBox.Focus();
            }
          
        }
        //Wizard1$StartNavigationTemplateContainerID$StartNextButton
        protected void Page_Load(object sender, EventArgs e)
        {
            Button btn=(Button)  Wizard1.FindControl("StepNavigationTemplateContainer").FindControl("StepNextButton");
            btn.OnClientClick="return confirm('Are You Sure You Want To Go To Next Step')";
        }
    }
}