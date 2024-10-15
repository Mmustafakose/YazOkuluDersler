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
    public partial class ogrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int x = Convert.ToInt32(Request.QueryString["ıd"]);
                TextId.Text = x.ToString();
                TextId.Enabled = false;

                EntityOgrenci entityOgrenci = new EntityOgrenci();
                List<EntityOgrenci> OgrList = BllOgrenci.BllDetayListele(x);
                txtAd.Text = OgrList[0].Ad.ToString();
                txtSoyad.Text = OgrList[0].Soyad.ToString();
                txtNumara.Text = OgrList[0].Numara.ToString();
                txtSifre.Text = OgrList[0].Sifre.ToString();
                txtFotograf.Text = OgrList[0].Fotograf.ToString();
                

            }
        }

        protected void btnGuncelle(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();

            entityOgrenci.Ad = txtAd.Text;
            entityOgrenci.Soyad = txtSoyad.Text;
            entityOgrenci.Sifre = txtSifre.Text;
            entityOgrenci.Numara = txtNumara.Text;
            entityOgrenci.Fotograf = txtFotograf.Text;
            entityOgrenci.Id1 = Convert.ToInt32(TextId.Text);

            BllOgrenci.OgrenciGuncelleBll(entityOgrenci);
            Response.Redirect("ogrenciListesi.aspx");
        }
    }
}