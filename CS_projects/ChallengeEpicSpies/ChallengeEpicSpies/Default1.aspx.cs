using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            
            {
                //default dates where ending current assignment is today. 
                //Starting new assignment is 14 days from today.
                //Ending 21 days from today
                DateTime today = System.DateTime.Today;
                endOldAssignmentCalendar.SelectedDate = DateTime.Today;
                startNewAssignmentCalendar.SelectedDate = DateTime.Today.AddDays(14);
                endNewAssignmentCalendar.SelectedDate = DateTime.Today.AddDays(21);

            }
            Page.MaintainScrollPositionOnPostBack = true; /* prevents page from jumping around with postback */
        }

        protected void endOldAssignmentCalendar_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void startNewAssignmentCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void endNewAssignmentCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan breakAssignments = (startNewAssignmentCalendar.SelectedDate - endOldAssignmentCalendar.SelectedDate).Duration();
            TimeSpan assignmentLength = (endNewAssignmentCalendar.SelectedDate - startNewAssignmentCalendar.SelectedDate).Duration();
            int TotalDays = assignmentLength.Days;
            int fee = 0;
            int budget = 0 ;

            if (breakAssignments.TotalDays < 14)
            {
                //must have at least 14 days between assignments
                resultsLabel.Text = "Error: Must allow atleast two weeks between previous assignment and new assignment.";
            }
            else
            {
                if (assignmentLength.TotalDays > 21)
                {
                    //fee associated if assignment length is greater than 21 days
                    fee = fee + 1000;
                
                }
                //spies cost $500 per day
                budget = fee + (TotalDays * 500);
                resultsLabel.Text = "Assignment of " + codeNameTextBox.Text + " to assignment " + assignmentNameTextBox.Text + " is authorized. Budget total: " + budget.ToString("C");

            }

        }
    }
}