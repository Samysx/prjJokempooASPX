using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjJogoJoquempô
{
    public partial class PaginaInicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSortear_Click(object sender, EventArgs e)
        {

            Random rdn = new Random();
            int valor = rdn.Next(1, 4);
            int valor2 = rdn.Next(1, 4);

            int empate = int.Parse(lblempates.Text);

            if (valor == 1)
            {
                Image1.ImageUrl = "~/CSS/img/Papel.jpg";
            }
            if (valor == 2)
            {
                Image1.ImageUrl = "~/CSS/img/Pedra.jpg";
            }
            if(valor == 3)
            {
                Image1.ImageUrl = "~/CSS/img/Tesoura.jpg";
            }

            if (valor2 == 1)
            {
                Image2.ImageUrl = "~/CSS/img/Papel.jpg";
            }
            if (valor2 == 2)
            {
                Image2.ImageUrl = "~/CSS/img/Pedra.jpg";
            }
            if (valor2 == 3)
            {
                Image2.ImageUrl = "~/CSS/img/Tesoura.jpg";
            }
            if (valor == valor2)
            {
                empate = empate + 1;
                lblempates.Text = empate.ToString();
            }
        }
    }
}