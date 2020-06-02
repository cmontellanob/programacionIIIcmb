using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Ahorcado
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText letra = FindViewById<EditText>(Resource.Id.txtLetra);
            Button enviar = FindViewById<Button>(Resource.Id.btnenviar);
            EditText palabra = FindViewById<EditText>(Resource.Id.txtPalabra);
            Button enviarpalabra = FindViewById<Button>(Resource.Id.btnenviarPalabra);

            TextView resultado = FindViewById<TextView>(Resource.Id.lblResultado);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.imgResultado);
            void actualizar()
            {
                switch (juego.Ahorcado.getInstancia().Estado)
                {
                    case 0:
                        //imagen.SetImageResource(Resource.Drawable.uno);
                        break;
                    case 1:
                        imagen.SetImageResource(Resource.Drawable.uno);
                        break;
                    case 2:
                        imagen.SetImageResource(Resource.Drawable.dos);
                        break;
                    case 3:
                        imagen.SetImageResource(Resource.Drawable.tres);
                        break;
                    case 4:
                        imagen.SetImageResource(Resource.Drawable.cuatro);
                        break;
                    case 5:
                        imagen.SetImageResource(Resource.Drawable.cinco);
                        break;
                    case 6:
                        imagen.SetImageResource(Resource.Drawable.seis);
                        break;
                    case 7:
                        imagen.SetImageResource(Resource.Drawable.siete);
                        break;
                    case 8:
                        imagen.SetImageResource(Resource.Drawable.ocho);
                        break;
                }
            }

            enviar.Click += (sender, e) =>
              {
                  char l = letra.Text[0];
                  string res=juego.Ahorcado.getInstancia().Buscar(l);
                  resultado.Text = res;
                  actualizar();
                  


              };
            enviarpalabra.Click += (sender, e) =>
            {
                string p = palabra.Text;
                string res = juego.Ahorcado.getInstancia().BuscarPalabra(p);
                resultado.Text = res;
                actualizar();


            };

        }
    }
}