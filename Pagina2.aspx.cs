using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JosephOvarezExamen2
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Seccion2();
        }
        protected void BVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void BSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                Cliente.Salvar();
                Response.Redirect("Pagina1.aspx");
            }
            
        }

        protected void BAgregar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        public void Seccion2()
        {

            TNombre2.Text = Cliente.GetNombre();
            TCedula2.Text = Cliente.GetCedula();
            TTelefono2.Text = Cliente.GetTelefono();
            TDireccion2.Text = Cliente.GetDireccion();
            TFactura.Text = Convert.ToString(Cliente.GetFactura());
            TCodigo.Text = Cliente.Code(Cliente.Codigo);

        }
        public void GuardarDatos()
        {
            if (VerificarDatos())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                Cliente.SetMes(DropDownList1.SelectedIndex.ToString());
                Cliente.SetMonto(float.Parse(TMonto.Text));
                Cliente.SetDescuento(float.Parse(TDescuento.Text));
                Cliente.SetIva(Cliente.GetMonto() * 13 / 100);
                Cliente.SetSubtotal(Cliente.GetMonto() + Cliente.GetIva());
                Cliente.SetTotal(Cliente.GetSubtotal() - Cliente.GetDescuento());
                TMonto2.Text = Convert.ToString(Cliente.GetMonto());
                TDescuento2.Text = Convert.ToString(Cliente.GetDescuento());
                TIva.Text = Convert.ToString(Cliente.GetIva());
                TSubtotal.Text = Convert.ToString(Cliente.GetSubtotal());
                TTotal.Text = Convert.ToString(Cliente.GetTotal());
            }
        }
        private Boolean VerificarDatos() {
           Boolean Verificador = false;
            if (String.IsNullOrEmpty(TMonto.Text) || String.IsNullOrEmpty(TDescuento.Text))
            {
                Verificador = true;

            }
            return Verificador;

        }

       
    }
}