using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class FileUploadedü : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string FileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (FileUpload1.HasFile == true)
            {
                if (FileExtension.ToLower() != ".doc" && FileExtension.ToLower() != ".docx")
                {
                    lblMessage.Text = "Only Files With .doc or .docx Extesion are Allowed";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 20097152)
                    {
                        lblMessage.Text = "Maximum file size (2MB) exceeded";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        lblMessage.Text = "File Uploaded";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Please Select A File To Uploaded";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }


        }

    }
}
