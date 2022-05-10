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
    class CustomAdapter : BaseAdapter
    {
        public Context c;
        public List<Rice> rice;
        private LayoutInflater inflater;
        
        /*
         * CONSTRUCTOR
         */
        public CustomAdapter(Context c, List<Rice> rice)
        {
            this.c = c;
            this.rice = rice;
        }

        public override int Count => throw new NotImplementedException();

        public override Object GetItem(int position)
        {
            throw new NotImplementedException();
        }



        /*
         * RETURN ITEMS
         */
        /*   public override Object GetItem(int position)
           {
               return rice.Get(position);
           }
   */
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
         /*   if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.list_view_model, parent, false);

            }
*//*
            if(convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.cart_list_model, parent, false);
            }
*/
   /*         //BIND DATA
            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
            {
                NameTxt = { Text = rice[position].Name },
                itemPrice = { Text = rice[position].Price },
                itemCategory = { Text = rice[position].Category },
                
            };
*/

/*
            holder.addToCart.Click += AddToCart_Click;
           
          

            //reads image from Firebase Storage using ImageServices
            ImageService.Instance.LoadUrl(rice[position].itemThumbnail)
                  .Retry(2, 300)
                  .DownSample(300, 300)
                  .Into(holder.Img);



           ;
*/
            



           

            void AddToCart_Click(object sender, EventArgs e)
            {
                Toast.MakeText(Application.Context, "Added to cart! ", ToastLength.Short).Show();
               
            }


            return convertView;
        }









        /*
         * TOTAL NUM OF ITEMS
         */
 


    }

    /* class CustomAdapterViewHolder : Java.Lang.Object
    {
        //adapter views to re-use
        public TextView NameTxt;
        public ImageView Img;
        public Button addToCart;
        public TextView itemPrice;
        public TextView itemCategory;
        public LayoutInflater inflater;
        public Context c;
        private JavaList<Rice> prods;


        public  CustomAdapterViewHolder(View itemView)
        {
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.item_title);
            Img = itemView.FindViewById<ImageView>(Resource.Id.itemImg);
            itemCategory = itemView.FindViewById<TextView>(Resource.Id.category);
            itemPrice = itemView.FindViewById<TextView>(Resource.Id.itemPrice);
            addToCart = itemView.FindViewById<Button>(Resource.Id.addtocart);

       

        }

   

      
     
    }*/
}
