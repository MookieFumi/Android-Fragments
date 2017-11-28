using System;
using System.Collections.Generic;
using System.Linq;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using AndroidFragment.Adapters;
using AndroidFragment.Infrastructure;
using AndroidFragment.Model;
using Newtonsoft.Json;

namespace AndroidFragment.Fragments
{
    public class PlayerListFragment : Fragment
    {
        public IEnumerable<Player> Players { get; private set; }

        public static PlayerListFragment NewInstance(IEnumerable<Player> players)
        {
            return new PlayerListFragment
            {
                Players = players ?? Enumerable.Empty<Player>()
            };
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Recuperamos las variables guardadas en OnSaveInstanceState
            var value = savedInstanceState?.GetString(Constants.TagPlayers, string.Empty);
            if (!string.IsNullOrEmpty(value))
                Players = JsonConvert.DeserializeObject<IEnumerable<Player>>(value);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.PlayerListFragment, container, false);
        }

        /// <summary>
        ///     Any view setup should occur here.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="savedInstanceState"></param>
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            var adapter = new PlayerAdapter(Activity, Resource.Layout.PlayerListViewRow, Players.ToArray());
            var listView = view.FindViewById<ListView>(Resource.Id.listView);
            listView.Adapter = adapter;

            listView.ItemClick += (sender, args) =>
            {
                var itemAtPosition = listView.GetItemAtPosition(args.Position);
                OnPlayerClicked(itemAtPosition.Cast<Player>());
            };
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            //Todas las variables locales las guardamos en el Bundle para posteriormente recuperarla en el OnCreate
            outState.PutString(Constants.TagPlayers, JsonConvert.SerializeObject(Players));

            base.OnSaveInstanceState(outState);
        }

        public event EventHandler<Player> PlayerClicked;

        protected virtual void OnPlayerClicked(Player player)
        {
            PlayerClicked?.Invoke(this, player);
        }
    }
}