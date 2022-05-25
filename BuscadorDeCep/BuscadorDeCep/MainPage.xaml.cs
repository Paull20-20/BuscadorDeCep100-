using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Correios;


namespace BuscadorDeCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnProcurar_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(entCep.Text))
            {
                await DisplayAlert("Campo de busca vázio", "Busque novamente", "ok");
            }
            else
            {
                CorreiosApi correios = new CorreiosApi();
                Correios.CorreiosServiceReference.enderecoERP result = correios.consultaCEP(entCep.Text);

                lblCep2.Text = result.cep;
                lblEstado.Text = result.uf;
                lblCidade.Text = result.cidade;
                lblBairro.Text = result.bairro;
                lblRua.Text = result.end;

            }


        }
    }
}
