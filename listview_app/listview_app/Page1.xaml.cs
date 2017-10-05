using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using listview_app.models;

namespace listview_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            PopulateListView();
        }




        private void PopulateListView()
        {
            var listOfSites = new ObservableCollection<Servent>()
            {
                new Servent()
                {

                    IconSource = ImageSource.FromFile("ArcherCC.png"),
                    Name = "Emiya",
                    ClassS = "An archer class servant who enjoys to cook",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=011",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("NeroCC.png"),
                    Name = "Nero Claudis",
                    ClassS = "A saber class servant with a boastful attitude",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=005",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("mordred_ace.png"),
                    Name = "Mordred Pendragon",
                    ClassS = "A saber class servant and the son of Arthur",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=076",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("Eliz1CC.png"),
                    Name = "Elizabeth Bathory",
                    ClassS = "A lancer class servant who wants to be an idol.",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=018",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("TamaCC.png"),
                    Name = "Tamamo No Mae",
                    ClassS = "Caster class Servant. Also is Evil",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=062",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("ShikiRCC.png"),
                    Name = "Ryougi Shiki",
                    ClassS = "A relentless Assasssin",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=091",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("RiderCC.png"),
                    Name = "Alexander The Great",
                    ClassS = "A Rider class Servant and a king",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=108",
                },
                new Servent()
                {
                    IconSource = ImageSource.FromFile("GilCC.png"),
                    Name = "Gilgamesh",
                    ClassS = "Archer class Servant. World's oldest hero",
                    Url = "http://fate-go.cirnopedia.org/servant_profile.php?servant=012",
                }

            };

            ServantListView.ItemsSource = listOfSites;
        }

        void Handle_NavigateToUrl(object sender, System.EventArgs e)
        {
            var listViewItem = (ImageCell)sender;
            var url = (string)listViewItem.CommandParameter;
            Device.OpenUri(new Uri(url));
        }
    }
}