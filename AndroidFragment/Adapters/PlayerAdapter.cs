using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidFragment.Model;
using Square.Picasso;

namespace AndroidFragment.Adapters
{
    public class PlayerAdapter : ArrayAdapter<Player>
    {
        private readonly int _textViewResourceId;
        private readonly Context _context;
        private readonly Player[] _players;

        public PlayerAdapter(Context context, int textViewResourceId, Player[] players) : base(context, textViewResourceId, players)
        {
            _textViewResourceId = textViewResourceId;
            _context = context;
            _players = players;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            PlayerHolder holder = null;

            if (row == null)
            {
                LayoutInflater inflater = ((Android.App.Activity)_context).LayoutInflater;
                row = inflater.Inflate(_textViewResourceId, parent, false);

                holder = new PlayerHolder(row);
                row.SetTag(Resource.Id.TAG_ID, holder);
            }
            else
            {
                holder = (PlayerHolder)row.GetTag(Resource.Id.TAG_ID);
            }

            var player = _players[position];
            holder.Name.Text = player.Name;
            holder.Team.Text = player.Team;
            Picasso.With(_context).Load(player.ImageUrl).Into(holder.ImageUrl);

            return row;
        }

        private class PlayerHolder : Java.Lang.Object
        {
            public PlayerHolder(View view)
            {
                ImageUrl = view.FindViewById<ImageView>(Resource.Id.image);
                Name = view.FindViewById<TextView>(Resource.Id.name);
                Team = view.FindViewById<TextView>(Resource.Id.team);
            }

            public ImageView ImageUrl { get; private set; }
            public TextView Name { get; private set; }
            public TextView Team { get; private set; }
        }

    }
}