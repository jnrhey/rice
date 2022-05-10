using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FFImageLoading;
using Firebase.Database;
using mobi.Helper;
using Object = Java.Lang.Object;

namespace mobi
{
    class CartCustomAdapter : BaseAdapter
    {
        private readonly Context c;
        private readonly JavaList<Rice> rice;
        private LayoutInflater inflater;

        /*
         * CONSTRUCTOR
         */
        public CartCustomAdapter(Context c, JavaList<Rice> rice)
        {
            this.c = c;
            this.rice = rice;
        }

        /*
         * RETURN ITEMS
         */
        public override Object GetItem(int position)
        {
            return rice.Get(position);
        }

        /*
         * ITEMS ID
         */
        public override long GetItemId(int position)
        {
            return position;
        }

        /*
         * RETURN INFLATED VIEW
         */
        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            //INITIALIZE INFLATER
            if (inflater == null)
            {
                inflater = (LayoutInflater)c.GetSystemService(Context.LayoutInflaterService);
            }

            //INFLATE OUR MODEL LAYOUT
            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.list_view_model, parent, false);

            }

            //BIND DATA
            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
            {
                NameTxt = { Text = rice[position].Name },
                itemPrice = { Text = rice[position].Price },
                itemCategory = { Text = rice[position].Category }


            };





            //reads image from Firebase Storage using ImageServices
            ImageService.Instance.LoadUrl(rice[position].Image)
                  .Retry(2, 300)
                  .DownSample(500, 500)
                  .Into(holder.Img);




            FirebaseDatabase database = AppDataHelper.GetDatabase();
            DatabaseReference dbItems = database.GetReference("/items/item02/item-name");



            Console.WriteLine(dbItems);

            return convertView;
        }




        /*
         * TOTAL NUM OF ITEMS
         */
        public override int Count
        {
            get { return rice.Size(); }
        }



    }

    class CustomAdapterViewHolder : Java.Lang.Object
    {
        //adapter views to re-use
        public TextView NameTxt;
        public ImageView Img;
        public Button addToCart;
        public TextView itemPrice;
        public TextView itemCategory;

        public CustomAdapterViewHolder(View itemView)
        {
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.item_title);
            Img = itemView.FindViewById<ImageView>(Resource.Id.itemImg);
            addToCart = itemView.FindViewById<Button>(Resource.Id.addtocart);
            itemCategory = itemView.FindViewById<TextView>(Resource.Id.category);
            itemPrice = itemView.FindViewById<TextView>(Resource.Id.itemPrice);




        }


    }
}
