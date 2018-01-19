using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string resultMax = "";
            string resultMin = "";

            //start at index 0 and if the result in index is less than the total length then proceed, add one next time to look at next value
            for (int index = 0; index < numbers.Length; index++) 
            {
                //if the position of the index value in a given array is equal to the max number then give result below. If not equal to max, skip to the next if statement
                if (numbers[index] == numbers.Max())
                    {
                    resultMax = String.Format("Most battles belong to: {0} (Value: {1})", names[index], numbers[index]);
                    }
                //if the position of the index value in a given array is equal to the min number then give result below. If not equal to min, skip to the next if statement
                if (numbers[index] == numbers.Min())
                {
                    resultMin = String.Format("Least battles belong to: {0} (Value: {1})", names[index], numbers[index]);
                }
            }


            resultLabel.Text = resultMax + "<br />" + resultMin;
        }
    }
}