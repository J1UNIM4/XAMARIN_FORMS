using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        public List<string> Items_i { get; set; }

        public List<string> Items_a { get; set; }

        public List<string> Items_s { get; set; }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var curriculo = new Curriculum()
            {
                Fname = Fname.Text,
                LName = Lname.Text,
                phone = phone.Text,
                country = country.Text,
                idioms = Items_i,
                aptitudes = Items_a,
                skills = Items_s,
                experience = Edit.Text
                
            };

            Navigation.PushAsync(new Page2(curriculo));
        }

        private void Button_Clicked_plus_i(object sender, EventArgs e)
        {
            foreach (var item in Idioms_i.Children)
            {
                if (item.StyleId == "1")
                {
                    var entry_new = new Entry();
                    entry_new = (Entry)item;

                    Items_i.Add(entry_new.ToString());
                    item.StyleId = "0";
                }
            }
            NEW_i.StyleId = "0";

            Idioms_i.Children.Add(new Entry()
            {
                StyleId = "1"
            });
        }
        private void Button_Clicked_plus_a(object sender, EventArgs e)
        {
            foreach (var item in Aptitudes_i.Children)
            {
                if (item.StyleId == "1")
                {
                    var entry_new = new Entry();
                    entry_new = (Entry)item;
                    Items_a.Add(entry_new.ToString());
                    item.StyleId = "0";
                }
            }
            NEW_a.StyleId = "0";
            
            Aptitudes_i.Children.Add(new Entry()
            {
                StyleId = "1"
            });
        }
        private void Button_Clicked_plus_s(object sender, EventArgs e)
        {
            foreach (var item in Skills_i.Children)
            {
                if (item.StyleId == "1")
                {
                    var entry_new = new Entry();
                    entry_new = (Entry)item;
                    Items_s.Add(entry_new.ToString());
                    item.StyleId = "0";
                }
            }
            NEW_s.StyleId = "0";

            Skills_i.Children.Add(new Entry()
            {
                StyleId = "1"
            });
        }
    }
}