using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsMegaChallenge
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PapaBobsDbEntitiesConnection db = new PapaBobsDbEntitiesConnection();
            var ordermanagers = db.OrderManagers;
            

            string result = "";

            ordermanagementGridView.DataSource = ordermanagers.ToList();
            ordermanagementGridView.DataBind();

            resultLabel.Text = result;
        }
    }
}