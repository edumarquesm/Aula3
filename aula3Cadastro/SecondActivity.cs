
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace aula3Cadastro
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Recebe);

            var nome = FindViewById<TextView>(Resource.Id.nome);
            var sobrenome = FindViewById<TextView>(Resource.Id.sobrenome);
            var dta_nasc = FindViewById<TextView>(Resource.Id.dta_nascimento);
            var btnV = FindViewById<Button>(Resource.Id.Voltar);


            nome.Text = (String) Intent.GetStringExtra("nome");
            sobrenome.Text = (String) Intent.GetStringExtra("sobrenome");
            dta_nasc.Text = (String) Intent.GetStringExtra("dta_nasc");
        
            btnV.Click += delegate {

                var intencao = new Intent(this, typeof(MainActivity));
                
                StartActivity(intencao);
            };

        }
    }
}
