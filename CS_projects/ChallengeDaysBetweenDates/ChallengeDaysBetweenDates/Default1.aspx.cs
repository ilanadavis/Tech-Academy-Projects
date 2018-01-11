using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firstCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void secondCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*
            TimeSpan difference;
            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                difference = firstCalendar.SelectedDate - secondCalendar.SelectedDate;
            }
            else
            {
                difference = secondCalendar.SelectedDate - firstCalendar.SelectedDate;
            }
            resultLabel.Text = difference.TotalDays.ToString();

            */

            TimeSpan difference = (firstCalendar.SelectedDate - secondCalendar.SelectedDate).Duration();
            resultLabel.Text = difference.TotalDays.ToString();
        }
    }
}