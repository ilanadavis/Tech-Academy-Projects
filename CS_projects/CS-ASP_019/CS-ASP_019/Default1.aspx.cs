﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = string.Format("Thank you, {0}, for your business", nameTextBox.Text);

            int ssn = int.Parse(ssnTextBox.Text);
            //String result = String.Format("Thank you, {0}, for your business. <br /> Your Social Security Number is: {1:000-00-0000}", nameTextBox.Text, ssn);

            int phone = int.Parse(phoneTextBox.Text);
            //string result = String.Format("Thank you, {0}, for your business. <br /> Your Social Security Number is: {1:000-00-0000} <br />Phone: {2:(000) 000-0000}", nameTextBox.Text, ssn, phone);


            /* string result = String.Format("Thank you, {0}, for your business." +
                 "<br /> Your Social Security Number is: {1:000-00-0000}" +
                 "<br />Phone: {2:(000) 000-0000}" +
                 "<br />Loan Date: {3:ddd -- d, M, yy}",
                 nameTextBox.Text, ssn, phone, loanDateCalendar.SelectedDate);
             */

            double salary = double.Parse(salaryTextBox.Text);

            string result = String.Format("Thank you, {0}, for your business." +
               "<br /> Your Social Security Number is: {1:000-00-0000}" +
               "<br />Phone: {2:(000) 000-0000}" +
               "<br />Loan Date: {3:ddd -- d, M, yy}" +
               "<br />Salary:{4:C}",
               nameTextBox.Text, ssn, phone, loanDateCalendar.SelectedDate, salary);

            resultLabel.Text = result;
        }
    }
}