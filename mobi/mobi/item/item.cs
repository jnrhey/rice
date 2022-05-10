using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mobi.item
{
    public class Item
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public string Details { get; set; }
        public override string ToString()
        {
            return Name + "" + Description;
        }

    }
}