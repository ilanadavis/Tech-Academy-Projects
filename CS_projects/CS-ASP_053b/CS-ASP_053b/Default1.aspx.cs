using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_053b
{
    public partial class Default1 : System.Web.UI.Page
    {
        const string fileExtension = ".html";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //Constant locals
            const int hoursPerDay = 24;

            //Calculate Constant
            const double daysPerWeek = (double)Calendar.days / (double)Calendar.weeks;

            string result = "";
            for (int i = 1; i <= daysPerWeek; i++)
            {
                for (int j = 0; j < hoursPerDay; j++)
                {
                    result += string.Format("<p><a href='report - {0} - {1}.{2}'>Day: {0} -- Hour: {1}</a></p>", i, j, fileExtension);
                }
            }
            resultLabel.Text = result;
        }
    }
}