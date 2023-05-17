using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjJogoJoquempô
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static int img = 0;
        int papel = 1;
        int tesoura = 2;
        int pedra = 3;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPedra_Click(object sender, EventArgs e)
        {
            img = pedra;
            Image1.ImageUrl = "~/CSS/img/Pedra.jpg";
        }

        protected void btnPapel_Click(object sender, EventArgs e)
        {
            img = papel;
            Image1.ImageUrl = "~/CSS/img/Papel.jpg";
        }

        protected void btnTesoura_Click(object sender, EventArgs e)
        {
            img = tesoura;
            Image1.ImageUrl = "~/CSS/img/Tesoura.jpg";
        }

        protected void BtnSortear_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int img2 = rdn.Next(1, 4);

            int empate = int.Parse(lblempates.Text);
            Double placar = Convert.ToDouble(LblPontuacaoP.Text);
            Double placar2 = Convert.ToDouble(lblPontuacaoM.Text);


            if(img2 == papel)
            {
                Image2.ImageUrl = "~/CSS/img/Papel.jpg";
            }
            else if (img2 == tesoura)
            {
                Image2.ImageUrl = "~/CSS/img/Tesoura.jpg";
            }
            else if (img2 == pedra)
            {
                Image2.ImageUrl = "~/CSS/img/Pedra.jpg";
            }

            if (img == img2)
            {
               
                lblempates.Text = (empate +1).ToString();
            }

            else if (img == papel && img2 == pedra)
            {
                LblPontuacaoP.Text = (placar + 1).ToString();
            }
            else if(img == pedra && img2 == tesoura)
            {
                LblPontuacaoP.Text = (placar + 1).ToString();
            }
            else if(img == tesoura && img2 == papel)
            {
                LblPontuacaoP.Text = (placar + 1).ToString();
            }

            if (img2 == papel && img == pedra)
            {
                lblPontuacaoM.Text = (placar + 1).ToString();
            }
            else if(img2 == pedra && img == tesoura)
            {
                lblPontuacaoM.Text = (placar + 1).ToString();
            }
            else if(img2 == tesoura && img == papel)
            {
                lblPontuacaoM.Text = (placar + 1).ToString();
            }


        }
    }
}