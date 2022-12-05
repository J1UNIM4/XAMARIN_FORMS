using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(new Curriculum()
            {
                LName = "jose",
                Fname = "Morales",
                aptitudes = new List<string>
                {
                    "APTITUD1",
                    "APTITUD2",
                    "APTITUD3"
                },
                idioms = new List<string>
                {
                    "Ingles",
                    "Español",
                    "Frances"
                },
                skills = new List<string>
                {
                    "Programador",
                    "Data science",
                    "Liderazgo"
                },
                country = "PERU",
                phone = "93992192",
                experience= "PROGRAMDOR DE LIMPSUM DMEOSASDQWASDasdew asdqwda sadawa"


                
            }));
        }
    }
}
