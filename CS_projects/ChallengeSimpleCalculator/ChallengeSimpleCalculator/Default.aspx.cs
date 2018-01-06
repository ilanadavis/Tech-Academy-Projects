using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber + secondNumber;
            resultsLabel.Text = result.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber - secondNumber;
            resultsLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber * secondNumber;
            resultsLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            Decimal result = (Decimal) firstNumber / secondNumber;
            resultsLabel.Text = result.ToString();
        }
    }
}