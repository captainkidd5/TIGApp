using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TigApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public List<Work> Works { get; set; }

        public NewsPage()
        {
            InitializeWorks();
            InitializeComponent();

            BindingContext = this;
        }

        private void InitializeWorks()
        {
            this.Works = new List<Work>()
            {
                new Work()
                {
                    Title = "Dunning Kruger",
                    Description = "A collector of sorts",
                    ImageUrl = "https://tokyointernationalgallery.co.jp/wp-content/uploads/2020/06/DUNNING-KRUGER-1.jpg"
                },
                 new Work()
                {
                    Title = "Golumptuous the Lithuanian Beetle",
                    Description = "A collector of sorts",
                    ImageUrl = "https://tokyointernationalgallery.co.jp/wp-content/uploads/2020/06/Golumptuous-the-Lithuanian-Beetle-1.jpg"
                },
                                  new Work()
                {
                    Title = "Hubris Dogma and the Kowloon Ghosts",
                    Description = "A collector of sorts",
                    ImageUrl = "https://tokyointernationalgallery.co.jp/wp-content/uploads/2020/06/Hubris-Dogma-and-Kowloon-Ghosts-1.jpg"
                },
                                                   new Work()
                {
                    Title = "So do not fear for I am with you..",
                    Description = "A collector of sorts",
                    ImageUrl = "https://tokyointernationalgallery.co.jp/wp-content/uploads/2020/06/So-do-not-fear-for-I-am-with-you-do-not-be-dismayed-for-I-am-your-Dog.-1.jpg"
                },
                                                                    new Work()
                {
                    Title = "What do you mean you forgot the perc?",
                    Description = "A collector of sorts",
                    ImageUrl = "https://tokyointernationalgallery.co.jp/wp-content/uploads/2020/06/%E2%80%9CWhat-do-you-mean-you-forgot-the-Perc-30-%E2%80%9D-2.jpg"
                },
            };
        }
    }
}