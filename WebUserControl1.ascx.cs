using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Task1_2_1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("voting");
            cook.Values.Add("nuex", "1");
            cook.Values.Add("nuvg", "2");
            cook.Values.Add("nug", "3");
            cook.Values.Add("nua", "4");
            cook.Values.Add("nup", "5");



            if (excellent.Checked) {
                cook.Values.Add("vote","Excellent");
                cook.Values.Add("state", "true");
                if (Request.Cookies["voting"] != null) { 
                    string ex = Request.Cookies["voting"]["nuex"];
                cook.Values.Add("nuex", ex);
                }


            }
            else if (verygood.Checked)
            {
                cook.Values.Add("vote", "VeryGood");
                cook.Values.Add("state", "true");
                if (Request.Cookies["voting"] != null)
                {
                    string vg = Request.Cookies["voting"]["nuvg"];
                    cook.Values.Add("nuvg", vg);
                }

            }

            else if (good.Checked)
            {
                cook.Values.Add("vote", "Good");
                cook.Values.Add("state", "true");
                if (Request.Cookies["voting"] != null)
                {
                    string g = Request.Cookies["voting"]["nug"];
                    cook.Values.Add("nug", g);
                }

            }

            else if (poor.Checked)
            {
                cook.Values.Add("vote", "Poor");
                cook.Values.Add("state", "true");
                if (Request.Cookies["voting"] != null)
                {
                    string p = Request.Cookies["voting"]["nup"];
                    cook.Values.Add("nup", p);
                }

            }

            else if (acceptable.Checked)
            {
                cook.Values.Add("vote", "Acceptable");
                cook.Values.Add("state", "true");
                if (Request.Cookies["voting"] != null)
                {
                    string a = Request.Cookies["voting"]["nua"];
                    cook.Values.Add("nua", a);
                }


            }
            /////////////////////////
         cook.Expires = DateTime.Now.AddDays(100);

            Response.Cookies.Add(cook);
            //if (Request.Cookies["mylogin"] != null)
            //{
            //    string user1 = Request.Cookies["mylogin"]["name"];
            //    string user2 = Request.Cookies["mylogin"]["phone"];
            //    string user3 = Request.Cookies["mylogin"]["address"];
            //    string user4 = Request.Cookies["mylogin"]["email"];

            //    Label1.Text = user1 + " / " + user2 + " / " + user3 + " / " + user4 + " / ";
            //}
        }
    }
}