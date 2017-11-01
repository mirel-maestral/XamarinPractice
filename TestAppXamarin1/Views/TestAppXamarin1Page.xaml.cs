using TestAppXamarin1.ViewModel;
using TestAppXamarin1.Views;
using Xamarin.Forms;

namespace TestAppXamarin1
{
    public partial class TestAppXamarin1Page : ContentPage
    {
        public TestAppXamarin1Page()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Page2());
        }

        void gotoSlider_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new sliderPage());
        }

        void gotoListView_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListViewPage());
        }

        void behaviourTest_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new BehaviourView() );
        }
    }
}
