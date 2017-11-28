using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using AndroidFragment.Infrastructure;
using AndroidFragment.Model;
using Newtonsoft.Json;
using Square.Picasso;

namespace AndroidFragment.Fragments
{
    public class PlayerDetailFragment : Fragment
    {
        public Player Player { get; private set; }

        public static PlayerDetailFragment NewInstance(Player player)
        {
            return new PlayerDetailFragment
            {
                Player = player
            };
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Recuperamos las variables guardadas en OnSaveInstanceState
            var value = savedInstanceState?.GetString(Constants.TagPlayer, string.Empty);
            if (!string.IsNullOrEmpty(value))
                Player = JsonConvert.DeserializeObject<Player>(value);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.PlayerDetailFragment, container, false);

            var name = view.FindViewById<TextView>(Resource.Id.name);
            name.Text = Player.Name;

            var team = view.FindViewById<TextView>(Resource.Id.team);
            team.Text = Player.Team;

            var country = view.FindViewById<TextView>(Resource.Id.country);
            country.Text = Player.Country;

            var imageUrl = view.FindViewById<ImageView>(Resource.Id.imageUrl);
            Picasso.With(Activity).Load(Player.ImageUrl).Into(imageUrl);

            return view;
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            //Todas las variables locales las guardamos en el Bundle para posteriormente recuperarla en el OnCreate
            outState.PutString(Constants.TagPlayer, JsonConvert.SerializeObject(Player));

            base.OnSaveInstanceState(outState);
        }
    }
}