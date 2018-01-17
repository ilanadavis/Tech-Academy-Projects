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
                Validate();
            }
            endOldAssignmentCalednar.VisibleDate = DateTime.Today;
            startNewAssignmentCalednar.VisibleDate = DateTime.Today.AddDays(14);
            endNewAssignmentCalednar.VisibleDate = DateTime.Today.AddDays(21);
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
            if (DateTime.Today < DateTime.Today.AddDays(14))
                resultLabel.Text = "Error: Must allow atleast two weeks between previous assignment and new assignment.";
        }
        
       // resultLabel.Text = "Assignment of " + codeNameTextBox + "to assignment " + assignmentNameTextBox + "is authorized. Budget total: "
    }
}