using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using FFImageLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mobi.Adapter
{
    class RiceAdapter : RecyclerView.Adapter
    {
        public event EventHandler<RiceAdapterClickEventArgs> ItemClick;
        public event EventHandler<RiceAdapterClickEventArgs> ItemLongClick;
        public event EventHandler<RiceAdapterClickEventArgs> DeleteItemClick;
        List<Rice> Items;

       public RiceAdapter(List<Rice> Data)
        {
            Items = Data;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewholder, int position)
        {
            var holder = viewholder as RiceAdapterViewHolder;
            holder.ItemTitle.Text = Items[position].Name;
            holder.ItemCategory.Text = Items[position].Category;
            holder.ItemPrice.Text = Items[position].Price;
            ImageService.Instance.LoadUrl(Items[position].itemThumbnail)
                .Retry(2, 300)
                .DownSample(300, 300)
                .Into(holder.ItemThumbnail);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.cart_list_model, parent, false);

            var vh = new RiceAdapterViewHolder(itemView, OnClick, OnLongClick, OnDeleteClick);
            return vh;
        }

        public override int ItemCount => Items.Count;

        void OnClick(RiceAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(RiceAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);
        void OnDeleteClick(RiceAdapterClickEventArgs args) => DeleteItemClick?.Invoke(this, args);

    }

    public class RiceAdapterViewHolder : RecyclerView.ViewHolder
    {
        public TextView ItemTitle { get; set; }
        public TextView ItemAvailability { get; set; }
        public TextView ItemCategory { get; set; }
        public TextView ItemPrice { get; set; }
        public ImageView ItemThumbnail { get; set; }

        public RiceAdapterViewHolder(View itemView, Action<RiceAdapterClickEventArgs> clickListener, Action<RiceAdapterClickEventArgs>longClickListener, Action<RiceAdapterClickEventArgs>deleteClickListener): base(itemView)
        {
            ItemTitle = (TextView)itemView.FindViewById<TextView>(Resource.Id.item_title);
            ItemCategory = (TextView)itemView.FindViewById<TextView>(Resource.Id.category);
            ItemPrice = (TextView)itemView.FindViewById<TextView>(Resource.Id.itemPrice);
            ItemThumbnail = (ImageView)itemView.FindViewById<ImageView>(Resource.Id.itemImg);
        }
    }

    public class RiceAdapterClickEventArgs : EventArgs 
    { 

        public View View { get; set; }
        public int Position { get; set; }

    }

}