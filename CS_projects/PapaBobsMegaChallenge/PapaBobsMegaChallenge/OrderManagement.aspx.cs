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
            var orderid = db.OrderManagers;
            

            string result = "";

            foreach (var orderID in orderid)
            {
                result += "<p>" + orderID.Order_ID + "</p>";
            }
            resultLabel.Text = result;
        }
    }
}