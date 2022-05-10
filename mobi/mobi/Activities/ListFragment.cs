using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mobi.Listeners;
using System.Collections.Generic;

namespace mobi.Activities
{
    [Activity(Label = "ListFragment")]
    public class ListFragment : AndroidX.Fragment.App.Fragment
    {


        List<Rice> riceList;
        itemListener riceListener;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            View view = inflater.Inflate(Resource.Layout.list_layout, container, false);
           



            //ListView Bind for Rice Items
         

            return view;

        }


     

        /*  private JavaList<Rice> GetRices()
          {
              rice = new JavaList<Rice>();
              Rice rice_list;

              rice_list = new Rice("Basmati",
                  "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fbasmati_longrice.PNG?alt=media&token=a969f788-14b4-4c5d-a3db-aa5fd3ac3b72"
                  , "200",
                  "Long Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Jasponica", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fjasponica_shortrice.PNG?alt=media&token=be4f995a-44ee-4d5b-8113-cc905293a87c", 
                  "200", "Short Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Sakura", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fsakura_mediumrice.PNG?alt=media&token=ac22a39e-c2fc-4346-bd67-b55f7c23ca7c",
                  "500"
                  ,"Short Grain") ;
              rice.Add(rice_list);

              rice_list = new Rice("Spanish Gate", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fspanishgate_longrice.PNG?alt=media&token=7aec3f40-369c-4068-a833-a1e0d76056ef"
                  ,"200"
                  ,"Short Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Farm Boy", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2FFarmboy_Long.PNG?alt=media&token=480de817-89ac-4e5c-9877-2de86b743034"
                  , "250"
                  ,"Medium Grain") ;
              rice.Add(rice_list);

              rice_list = new Rice("Harvester's", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2FHarvester_long.PNG?alt=media&token=3c9968f2-6b9b-4776-8807-dd722cdb8ecf"
                  ,"230"
                  ,"Medium Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Botan", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fbotan_medium.PNG?alt=media&token=c16aa43d-f4c2-4247-a7ac-072974590e99"
                  ,"300"
                  ,"Long Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Rico", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Frico_medium.PNG?alt=media&token=36b3f46a-ff14-49aa-b3fd-f6c39b1d01be"
                  ,"150"
                  ,"Medium Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Goya", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fgoya_medium.jpg?alt=media&token=9f83b207-e02e-48a8-85a5-3bdf24243138"
                  ,"130"
                  ,"Long Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Spanish Gate", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fspanishgate_longrice.PNG?alt=media&token=7aec3f40-369c-4068-a833-a1e0d76056ef"
                  ,"250"
                  ,"Short Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Sunrice", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2Fsunrice_medium.PNG?alt=media&token=4187f210-b8e3-40a4-abd4-dbe9a66e2e2f"
                  ,"200"
                  ,"Medium Grain");
              rice.Add(rice_list);

              rice_list = new Rice("Harvester's", "https://firebasestorage.googleapis.com/v0/b/riceapp-7cc68.appspot.com/o/items%2FHarvester_short.jpg?alt=media&token=fa5fff10-3295-4cb7-9ec7-744601d9fd79"
                  ,"150"
                  ,"Long Grain");
              rice.Add(rice_list);

              return rice;
          }*/


    }
 }
