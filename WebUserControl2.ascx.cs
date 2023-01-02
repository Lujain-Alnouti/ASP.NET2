using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1_2_1
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["voting"] != null)
            {
                string ee = Request.Cookies["voting"]["nuex"];
                string[] ex = ee.Split(',');
                double exn = ex.Length;
                double tot ;
               
                string vv = Request.Cookies["voting"]["nuvg"];
                string[] vg = vv.Split(',');
                double vgn = vg.Length;
               
                string gg = Request.Cookies["voting"]["nug"];
                string[] g = gg.Split(',');
                double gn = g.Length;
                
                string pp = Request.Cookies["voting"]["nup"];
                string[] p = pp.Split(',');
                double pn = p.Length;
               
                string aa = Request.Cookies["voting"]["nua"];
                string[] a = aa.Split(',');
                int an = a.Length;
                tot = exn+an+ vgn+ gn+ pn;
                
                double xxe = (exn / tot);
                int exavg=Convert.ToInt32(xxe*100);
                exp.Width = exavg + '%';
                exp.Text= Convert.ToString(exavg)+'%';
                //////
                double xxv = (vgn / tot);
                int vavg = Convert.ToInt32(xxv * 100);
                vgp.Width = vavg + '%';
                vgp.Text = Convert.ToString(vavg)+'%';
                //////
                double xxg = (gn / tot);
                int gavg = Convert.ToInt32(xxg* 100);
                gp.Width = gavg + '%';
                gp.Text = Convert.ToString(gavg)+'%';
                //////
                double xxp = (pn / tot);
                int pavg = Convert.ToInt32(xxp * 100);
                ppp.Width = pavg + '%';
                ppp.Text = Convert.ToString(pavg)+'%';
                /////
                double xxa = (an / tot);
                int aavg = Convert.ToInt32(xxa * 100);
                ap.Width = aavg + '%';
                ap.Text = Convert.ToString(aavg)+'%';

            }
        }
    }
}