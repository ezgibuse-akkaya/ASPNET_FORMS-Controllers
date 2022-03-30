using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class PanelController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = false;
                //HideAdminControls();
                //HideNonAdminControls();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "-1")
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = false;

            }
            else if (DropDownList1.SelectedValue == "Admin")
            {
                AdminPanel.Visible = true;
                NonAdminPanel.Visible = false;
            }
            else
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = true;
            }
            //if (DropDownList1.SelectedValue == "-1")
            //{
            //    HideAdminControls();
            //    HideNonAdminControls();

                //}
                //else if (DropDownList1.SelectedValue == "Admin")
                //{
                //    ShowAdminControls();
                //    HideNonAdminControls();
                //}
                //else
                //{
                //    HideAdminControls();
                //    ShowNonAdminControls();
                //}

        }
        //private void ShowAdminControls()
        //{
        //    AdminGreeting.Visible = true;
        //    AdminNameLabel.Visible = true;
        //    AdminNameTextBox.Visible = true;
        //    AdminRegionLabel.Visible = true;
        //    AdminRegionTextBox.Visible = true;
        //    AdminActionsLabel.Visible = true;
        //    AdminActionsTextBox.Visible = true;

        //}
        //private void HideAdminControls()
        //{
        //    AdminGreeting.Visible = false;
        //    AdminNameLabel.Visible = false;
        //    AdminNameTextBox.Visible = false;
        //    AdminRegionLabel.Visible = false;
        //    AdminRegionTextBox.Visible = false;
        //    AdminActionsLabel.Visible = false;
        //    AdminActionsTextBox.Visible = false;

        //}
        //private void ShowNonAdminControls()
        //{
        //    NonAdminGreeting.Visible = true;
        //    NonAdminNameLabel.Visible = true;
        //    NonAdminNameTextBox.Visible = true;
        //   // NonAdminRegionLabel.Visible = true;
        //    NonAdminRegionTextBox.Visible = true;
        //    NonAdminCityLabel.Visible = true;
        //    NonAdminCityTextBox.Visible = true;
        //}
        //private void HideNonAdminControls()
        //{
        //    NonAdminGreeting.Visible = false;
        //    NonAdminNameLabel.Visible = false;
        //    NonAdminNameTextBox.Visible = false;
        //   // NonAdminRegionLabel.Visible = false;
        //    NonAdminRegionTextBox.Visible = false;
        //    NonAdminCityLabel.Visible = false;
        //    NonAdminCityTextBox.Visible = false;
        //}

    }
}