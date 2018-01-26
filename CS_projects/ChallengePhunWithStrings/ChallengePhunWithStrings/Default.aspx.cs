using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            //string name = "Ilana Davis";
            // In my case, the result would be:
            // sivaD analI
            /* for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }
            */
            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            //string[] namesArray = names.Split(',');
            //Array.Reverse(namesArray);

            // resultLabel.Text = String.Join(",", namesArray);


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***


            string[] namesArray = names.Split(',');
          
           // for (int i = 0; i <= names.Length; i--)
            {
                resultLabel.Text += names;
            }


           // resultLabel.Text = namesArray.PadLeft(30, '#');




            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
    }
}