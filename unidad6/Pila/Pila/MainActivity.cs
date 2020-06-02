using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Pila
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var mostrarInsertar = FindViewById<Button>(Resource.Id.btnInsertar);
            var mostrarEliminar = FindViewById<Button>(Resource.Id.btnEliminar);
            var mostrarMostrar = FindViewById<Button>(Resource.Id.btnMostrar);
            mostrarInsertar.Click += (sender, e) => {
                var insertar = new Intent(this, typeof(insertar));
                insertar.PutExtra("Datos", "Datos Enviados");
                StartActivity(insertar);
            };
        }
    }
}