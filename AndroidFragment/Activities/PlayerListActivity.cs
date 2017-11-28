using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Widget;
using AndroidFragment.Fragments;
using AndroidFragment.Infrastructure;
using AndroidFragment.Model;
using AndroidFragment.Services;
using Newtonsoft.Json;

namespace AndroidFragment.Activities
{
    [Activity(MainLauncher = true)]
    public class PlayerListActivity : FragmentActivity
    {
        private FrameLayout _playerDetailFrameLayout;
        private IEnumerable<Player> _players;

        public FrameLayout PlayerDetailFrameLayout => _playerDetailFrameLayout ?? (_playerDetailFrameLayout = FindViewById<FrameLayout>(Resource.Id.itemDetailFrameLayout));

        private bool HasPlayerDetailFragment => PlayerDetailFrameLayout != null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PlayerListActivity);

            _players = new PlayersServices().GetPlayers().ToList();
            var playerListFragment = PlayerListFragment.NewInstance(_players);

            playerListFragment.PlayerClicked += PlayerListFragmentOnPlayerClicked();

            //"Load" fragment into "view"
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.listViewFrameLayout, playerListFragment)
                .Commit();

            if (HasPlayerDetailFragment)
            {
                var detailFragment = PlayerDetailFragment.NewInstance(_players.First());
                SupportFragmentManager.BeginTransaction().Replace(Resource.Id.itemDetailFrameLayout, detailFragment)
                    .Commit();
            }
        }

        private EventHandler<Player> PlayerListFragmentOnPlayerClicked()
        {
            return (sender, player) =>
            {
                if (!HasPlayerDetailFragment)
                {
                    var intent = new Intent(this, typeof(PlayerDetailActivity));
                    ////The right way to pass/ recieve params to an Activity
                    intent.PutExtra(Constants.TagPlayer, JsonConvert.SerializeObject(player));
                    StartActivity(intent);
                }
                else
                {
                    var detailFragment = PlayerDetailFragment.NewInstance(player);
                    //var arguments = new Bundle();
                    //arguments.PutString(Constants.TagPlayer, Newtonsoft.Json.JsonConvert.SerializeObject(player));
                    //detailFragment.Arguments = arguments;
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.itemDetailFrameLayout, detailFragment)
                        .Commit();
                }
            };
        }
    }
}