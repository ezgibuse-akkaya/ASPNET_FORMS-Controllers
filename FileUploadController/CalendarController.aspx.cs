using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class CalendarController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
             }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible = true)
            {
                Calendar1.Visible = false;
                Button1.Visible = false;
            }
            else { 
            Calendar1.Visible = true;
}
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString("d");
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write(DateTime.Now.ToString("d")+"<br/>");
            //Response.Write(DateTime.Now.ToString("D") + "<br/>");
            //Response.Write(DateTime.Now.ToString("dd/MM/yyyy") + "<br/>");
            //Response.Write(DateTime.Now.ToString("dd/MMMM/yy") + "<br/>");
            //Response.Write(DateTime.Now.ToString("dd/MMMM/yyyy") + "<br/>");
            //Response.Write(DateTime.Now.ToString("MM/dd/yy") + "<br/>");

            //Response.Write(DateTime.Now.ToString()+"<br/>");
            //Response.Write(DateTime.Now.ToShortDateString() + "<br/>");
            //Response.Write(DateTime.Now.ToLongTimeString() + "<br/>");
            //Response.Write(DateTime.Now.ToLongDateString() + "<br/>");
            //Response.Write(DateTime.Now.ToShortDateString() + "<br/>");
            //Response.Write(DateTime.Now.ToShortTimeString() + "<br/>");

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth || e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;
            }
          //  Response.Write(e.Day.DayNumberText + "<br/>");
        }
    }
}