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

        private void Button_Clicked(object sender, EventArgs e)
        {
            var nombre = Fname.Text;
            var apellido = Lname.Text;
            List<string> list = new List<string>();
            for(int i=0;i< Idioms_i.Children.Count; i++)
            {
                list.Add(Idioms_i.GetChildElements(Idioms_i));

            };


            var curriculo = new Curriculum()
            {
                Fname = nombre,
                LName = apellido,
                phone = 1231231231,
                country = country.Text,
                idioms = "Ingles",
                aptitudes = "Aplicado",
                skills = "Fisico",
                experience = "Buen programador"
                
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
            var entry = new Entry();
            Skills_i.Children.Add(entry);
        }
    }
}