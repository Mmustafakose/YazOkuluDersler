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
    public partial class dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                List<EntityDers> entityDers = BllDersler.BllListele();
                DropDownList1.DataSource = entityDers;
                DropDownList1.DataTextField = "dersAd" ;
                DropDownList1.DataValueField = "ID" ;
                DropDownList1.DataBind();

            }
        }


        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm entityBasvuruForm = new EntityBasvuruForm();
            entityBasvuruForm.BasvuruogrId =TextBox1.Text;
            entityBasvuruForm.Basvurudersid = DropDownList1.SelectedValue;

            BllDersler.TalepEkleBll(entityBasvuruForm);

            
        }
    }
}