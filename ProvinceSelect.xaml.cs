using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolMe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProvinceSelect : ContentView
	{
        List<string> province = new List<string>
        {
            "Gauteng", "Western Cape", "KwaZulu Natal", "Free State", "Eastern Cape", "Northern Cape",
            "Mpumalanga", "Limpompo", "North West"
        };

        public object ProvincePicker { get; }

        public ProvinceSelect ()
		{
			InitializeComponent ();

            ProvincePicker.Items.Add("Gauteng");
            ProvincePicker.Items.Add("Western Cape");
            ProvincePicker.Items.Add("KwaZulu Natal");
            ProvincePicker.Items.Add("Free State");
            ProvincePicker.Items.Add("Eastern Cape");
            ProvincePicker.Items.Add("Northern Cape");
            ProvincePicker.Items.Add("Mpumalanga");
            ProvincePicker.Items.Add("Limpompo");
            ProvincePicker.Items.Add("North West");
        }
        private void ProvincePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = ProvincePicker.Items[ProvincePicker.SelectedIndex];

            DisplayAlert(name, "Selected value", "Ok");
        }

        private void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var keyword = SearchButton.Text;

            var suggestion = province.Where(c => c.ToLower().Contains(keyword.ToLower()));
            var s = from c in province where c.Contains(keyword) select c;
            SuggestionListView.ItemsSource = suggestion;
        }
        private void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {

        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var provinces = e.Item as string;
        }
    }
}