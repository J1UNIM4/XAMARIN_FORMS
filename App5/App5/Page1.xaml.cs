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
            var entry = new Entry();
            Idioms_i.Children.Add(entry);
        }
        private void Button_Clicked_plus_a(object sender, EventArgs e)
        {
            var entry = new Entry();
            Aptitudes_i.Children.Add(entry);
        }
        private void Button_Clicked_plus_s(object sender, EventArgs e)
        {
            Items_s.Add(NEW.Text);
            //delete Property "X:NAME"


            Skills_i.Children.Add(new Entry(){
                //Ass property "x:Name = NEW"
            });
        }
    }
}