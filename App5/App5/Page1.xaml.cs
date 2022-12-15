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
                Lname = Lname.Text,
                phone = phone.Text,
                country = country.Text,
                idioms = Items_i,
                aptitudes = Items_a,
                skills = Items_s,
                experience = Edit.Text
                
            };
            var Pag2 = new Page2();
            Pag2.BindingContext = curriculo;
            Navigation.PushAsync(Pag2);
        }

        public void Button_Clicked_plus_i(object sender, EventArgs e) 
        {

            Entry new_entry = new Entry();

            new_entry = (Entry)Idioms_i.Children.Last();

            Items_i.Add(new_entry.Text);


            Idioms_i.Children.Add(new Entry());
        }
        public void Button_Clicked_plus_a(object sender, EventArgs e)
        {
            
            Entry new_entry = new Entry();

            new_entry =(Entry)Aptitudes_i.Children.Last();

            Items_a.Add(new_entry.Text);

            
            Aptitudes_i.Children.Add(new Entry());
        }
        public void Button_Clicked_plus_s(object sender, EventArgs e)
        {

            Entry new_entry = new Entry();

            new_entry = (Entry)Skills_i.Children.Last();

            Items_s.Add(new_entry.Text);


            Skills_i.Children.Add(new Entry());
        }
    }
}