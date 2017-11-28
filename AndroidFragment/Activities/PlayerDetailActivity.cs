using Android.App;
using Android.OS;
using Android.Support.V4.App;
using AndroidFragment.Fragments;
using AndroidFragment.Infrastructure;
using AndroidFragment.Model;

namespace AndroidFragment.Activities
{
    [Activity]
    public class PlayerDetailActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PlayerDetailActivity);

            //The right way to pass/ recieve params to an Activity
            //https://stackoverflow.com/a/7325248
            Player player = null;
            if (Intent.Extras != null)
            {
                player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(Intent.Extras.GetString(Constants.TagPlayer));
            }

            var fragment = PlayerDetailFragment.NewInstance(player);
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.itemDetailFrameLayout, fragment).Commit();
        }
    }
}