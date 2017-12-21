using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace aula3Cadastro
{
    [Activity(Label = "aula3Cadastro", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var nome = FindViewById<EditText>(Resource.Id.nome);
            var sobrenome = FindViewById<EditText>(Resource.Id.sobrenome);
            var dta_nasc = FindViewById<EditText>(Resource.Id.dta_nascimento);
            var btn = FindViewById<Button>(Resource.Id.Enviar);

            btn.Click += delegate {
                var intencao = new Intent(this,typeof(SecondActivity));

                intencao.PutExtra("nome", nome.Text);
                intencao.PutExtra("sobrenome", sobrenome.Text);
                intencao.PutExtra("dta_nasc", dta_nasc.Text);

                StartActivity(intencao);
            };
        }
    }
}

