using TestAppXamarin1.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppXamarin1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        static PersonDataBase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new  TestAppXamarin1Page());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static PersonDataBase Database{
            get{
                if (database == null){
                    database = new PersonDataBase(
                        DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.ddb3"));
                }
                return database;    
            }
        }
    }
}
