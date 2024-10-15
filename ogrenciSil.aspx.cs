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
    public partial class ogrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(Request.QueryString["ıd"]);
            Response.Write(x);

            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.Id1 = x;
            BllOgrenci.OgrenciSilBll(entityOgrenci.Id1);
            Response.Redirect("ogrenciListesi.aspx");

        }
    }
}