using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JosephOvarezExamen2
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void GuardarVariables()
        {
            Cliente.SetNombre(TNombre.Text);
            Cliente.SetCedula(TCedula.Text);
            Cliente.SetDireccion(TDireccion.Text);
            Cliente.SetTelefono(TTelefono.Text);
            Cliente.SetFactura();
        }

        private Boolean VerificarEspacios()
        {
            Boolean Verificador = false;
            if (String.IsNullOrEmpty(TNombre.Text) || String.IsNullOrEmpty(TCedula.Text) || String.IsNullOrEmpty(TDireccion.Text) || String.IsNullOrEmpty(TTelefono.Text))
            {
                Verificador = true;
                
            }
            return Verificador;
        }
        protected void Agua_Click1(object sender, ImageClickEventArgs e)
        {
            if (VerificarEspacios())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                GuardarVariables();
                Cliente.SetCodigo(1);
                Response.Redirect("Pagina2.aspx");
            }
           
        }
       
        protected void Telefono_Click1(object sender, ImageClickEventArgs e)
        {
            if (VerificarEspacios())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                GuardarVariables();
                Cliente.SetCodigo(2);
                Response.Redirect("Pagina2.aspx");
            }
        }

        protected void Electricidad_Click1(object sender, ImageClickEventArgs e)
        {
            if (VerificarEspacios())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                GuardarVariables();
                Cliente.SetCodigo(3);
                Response.Redirect("Pagina2.aspx");
            }
        }

        protected void Internet_Click1(object sender, ImageClickEventArgs e)
        {
            if (VerificarEspacios())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Espacios sin completar');", true);
            }
            else
            {
                GuardarVariables();
                Cliente.SetCodigo(4 );
                Response.Redirect("Pagina2.aspx");
            }
        }
    }
}