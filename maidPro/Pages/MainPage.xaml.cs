using System.Threading.Tasks;
using maidPro.ui;

namespace maidPro.Pages
{   
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++) {
                TaskItem item = new TaskItem();
                item.RoomNumber = 200+i;
                TaskContain.Children.Add(item);
                item.Clean = (CleanStatus)((i%6)+1);
                item.RoomStatus = (RoomStatus)((i % 5) + 1);
            }
        }

 
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingPage());

        }
    }

}
