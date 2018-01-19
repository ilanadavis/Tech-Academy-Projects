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

                double[] rigged = new double[0];
                double[] acts = new double[0];
                string[] name = new string[0];

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

            Array.Resize(ref rigged, rigged.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);
            Array.Resize(ref name, name.Length + 1);

            int newrigged = rigged.GetUpperBound(0);
            int newacts = acts.GetUpperBound(0);
            int newasset = name.GetUpperBound(0);

            rigged[newrigged] = double.Parse(riggedTextBox.Text);
            acts[newacts] = double.Parse(actsTextBox.Text);
            name[newasset] = nameTextBox.Text;

            ViewState["Elections Rigged"] = rigged;
            ViewState["Acts of Subterfuge"] = acts;
            ViewState["Asset Name"] = name;

            riggedTextBox.Text = String.Empty;
            actsTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})",
                rigged.Sum(),
                acts.Average(),
                name.Last());
        }
    }
}