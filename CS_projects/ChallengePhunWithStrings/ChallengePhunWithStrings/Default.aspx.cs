using System;
using System.Collections.Generic;
using System.Globalization;
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
            /*
            string[] namesArray = names.Split(',');
            Array.Reverse(namesArray);

            resultLabel.Text = String.Join(",", namesArray);
            */

            // 3. Use the sequence to create ascii art:
            // *****luke*****  5,4,5
            // *****leia*****  5,4,5
            // *****han******  5,3,6
            // **Chewbacca***  2,9,3

            
            string[] split = names.Split(',');
            /*string result = "";
            for (int i = 0; i < split.Length; i++)
            {
                int padLeft = (14 - split[i].Length) / 2;
                string temp = split[i].PadLeft(split[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";

            }
             resultLabel.Text = result;
             */
            //not padding Chewbacca correctly. Need to revisit. 
            /*
            foreach (string s in split)
            {
                resultLabel.Text += s.ToString().PadRight(((14 - split.Length) / 2) + split.Length,'*').PadLeft(14, '*') + "<br />";
            }
            */

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.


            string firstLetterUpper = puzzle.Substring(0, 1);
            string sentence = puzzle.Remove(9, 9).Replace("Z", "T").ToLower(new CultureInfo("en-US", false)).Substring(1);
            resultLabel.Text = firstLetterUpper + sentence;
            
        }
    }
}