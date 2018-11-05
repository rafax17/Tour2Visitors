using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnInicio_Click(object sender, EventArgs e)
    {
        try
        {
            usuarioo usua = new usuarioo("", "", "","", "", "", "", "", "", "");
            if (usua.login(TxtUsuario.Text, TxtContraseña.Text)){

                LabelEstado.Text = "Validación exitosa";

            }
            else
            {
                LabelEstado.Text = "Validación incorrecta";
            }
            
        }
        catch
        {

        }
    }
}