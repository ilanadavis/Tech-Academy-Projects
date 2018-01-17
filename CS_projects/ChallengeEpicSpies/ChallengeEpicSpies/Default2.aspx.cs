using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                endOldAssignmentCalednar.SelectedDate = DateTime.Today;
                startNewAssignmentCalednar.SelectedDate = DateTime.Today.AddDays(14);
                endNewAssignmentCalednar.SelectedDate = DateTime.Today.AddDays(21);
            }
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void endOldAssignmentCalednar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void startNewAssignmentCalednar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void endNewAssignmentCalednar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            double cost = 500; /* each day on assignment cost $500 */
            double fee = 0; /* fee associated if over 21 days or 3 weeks */
            double budget = 0;
            double BetweenEndStart = (startNewAssignmentCalednar.SelectedDate - endOldAssignmentCalednar.SelectedDate).TotalDays;
            double BetweenStartEnd = (endNewAssignmentCalednar.SelectedDate - startNewAssignmentCalednar.SelectedDate).TotalDays;

            if (BetweenEndStart < 14)
            {
                resultLabel.Text = "Error: Must allow atleast two weeks between previous assignment and new assignment.";
                //following sets the fault of the new assignment calendar back to 14 days from today. Showing the soonest possible date for the manager
                DateTime earliestNewAssignment = endOldAssignmentCalednar.SelectedDate.AddDays(14);
                startNewAssignmentCalednar.SelectedDate = earliestNewAssignment;
                startNewAssignmentCalednar.VisibleDate = earliestNewAssignment;
            }
            else
            {
               if (BetweenStartEnd > 21)
                {
                    fee = 1000;
                }
                else
                {
                    fee = 0;
                }

               cost = cost * BetweenStartEnd;
               budget = cost + fee;
                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", codeNameTextBox.Text, assignmentNameTextBox.Text, budget);
                  // alternate resultlabel.text = "Assignment of " + codeNameTextBox.Text + " to assignment " + assignmentNameTextBox.Text + " is authorized. Budget total: " + budget;

            }

        }

    }
}