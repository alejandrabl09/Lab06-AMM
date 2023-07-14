using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
            {
            new Group("A")
            {
                new Item { Title = "Aguilar", Subtitle = "Adolfo" },
                new Item { Title = "Albornoz", Subtitle = "Rodolfo" },
                new Item { Title = "Alvarado", Subtitle = "Sandalio" },
                new Item { Title = "Alvarez", Subtitle = "Jorge" }
            },
            new Group("B")
            {
                new Item { Title = "Barzola", Subtitle = "Milton" },
                new Item { Title = "Bellido", Subtitle = "Abraham" },
                new Item { Title = "Bravo", Subtitle = "Luciana" },
                new Item { Title = "Bronstein", Subtitle = "Lucero" }
            },
            new Group("C")
            {
                new Item { Title = "Calero", Subtitle = "Zaina" },
                new Item { Title = "Cimas", Subtitle = "Zendaya" },
                new Item { Title = "Conde", Subtitle = "Zoyla" },
                new Item { Title = "Cortana", Subtitle = "Zub" }
            },
            };
            GroupedView.ItemsSource = Groups;
        }
    }
}