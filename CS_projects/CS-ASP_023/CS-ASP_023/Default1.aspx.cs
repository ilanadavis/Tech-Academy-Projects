using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_023
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
 
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);

            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            //to resize array and add one to the length
            Array.Resize(ref hours, hours.Length + 1);

            int newestItem = hours.GetUpperBound(0);

            hours[newestItem] = double.Parse(hoursTextBox.Text);

            ViewState["Hours"] = hours;

            resultLabel.Text = String.Format("Total Hours: {0}<br />Most Hours: {1}<br />Least Hours: {2}<br />Average Hours: {3:N2}",
                hours.Sum(),
                hours.Max(),
                hours.Min(),
                hours.Average());
        }
    }
}