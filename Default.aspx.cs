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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOgrEkle_Click(object sender, EventArgs e)
        {
            EntityOgrenci entogrenci= new EntityOgrenci();
            entogrenci.Ad = txtAd.Text;
            entogrenci.Soyad = txtSoyad.Text;
            entogrenci.Numara = txtNumara.Text;
            entogrenci.Sifre = txtSifre.Text;
            entogrenci.Fotograf = txtFotograf.Text;
            entogrenci.Bakiye= Convert.ToDouble( txtBakiye.Text);

            BllOgrenci.OgrenciEkleBll(entogrenci);
        }
    }
}