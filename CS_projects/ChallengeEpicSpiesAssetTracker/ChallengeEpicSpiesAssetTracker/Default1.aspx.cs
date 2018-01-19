using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                double[] rigged = new double[1];
                double[] acts = new double[1];
                string[] name = new string[1];

                ViewState.Add("Elections Rigged", rigged);
                ViewState.Add("Acts of Subterfuge", acts);
                ViewState.Add("Asset Name", name);

            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            double[] rigged = (double[])ViewState["Elections Rigged"];
            double[] acts = (double[])ViewState["Acts of Subterfuge"];
            string[] name = (string[])ViewState["Asset Name"];

            int elections = rigged.GetUpperBound(0);
            int subterfuge = acts.GetUpperBound(0);
         //   string asset = name.Last();

            rigged[elections] = double.Parse(riggedTextBox.Text);
            acts[subterfuge] = double.Parse(riggedTextBox.Text);
           // asset = nameTextBox.Text;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2}",
                rigged.Sum(),
                acts.Average(),
                name.Last());


            /*    Total Elections Rigged:
                Average Acts of Subterfuge per Asset: 
                (Last Asset you Added: )
            */
            //2 digits after decimal
            //
        }
    }
}