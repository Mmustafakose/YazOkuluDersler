using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayers;
using DataAccessLayers;
using BusinnesLogicLayer;

namespace Yaz_Okulu_Dersler
{
    public partial class ogrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci>OgrList = BllOgrenci.BllListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}