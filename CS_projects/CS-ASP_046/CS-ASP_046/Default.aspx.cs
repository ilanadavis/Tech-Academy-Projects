using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_046
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /*
            Car car1 = new Car("BMW", "528i", 2010, "Black");
            Car car2 = new Car("BMW", "745li", 2005, "Black");
            Car car3 = new Car("Ford", "Escape", 2008, "White");
            */
            
            List<Car> cars = new List<Car>();

            //Create new isntance of a car class but not give it a local variable name
            cars.Add(new Car { Make = "BMW", Model = "528i", Color = "Black", Year = 2010 });
            cars.Add(new Car { Make = "BMW", Model = "745li", Color = "Black", Year = 2005 });
            cars.Add(new Car { Make = "Ford", Model = "Escape", Color = "White", Year = 2008 });

            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }

            /*
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            */


            //Find all cars where color of car is white and when return, return as list of car
            //List<Car> whiteCars = cars.FindAll(p => p.Color == "White");

            //able to chancge all cars color to Silver
            //cars.ForEach(p => p.Color = "Silver");

            /*
            if (cars.Exists(p => p.Year == 2008))
                result += "We do have a 2008 model year in stock!";

            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }
            */

            resultLabel.Text = result;
        }
    }
}