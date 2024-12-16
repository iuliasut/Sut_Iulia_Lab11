using Sut_Iulia_Lab11.Data;
namespace Sut_Iulia_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
          
        }

       protected override Window CreateWindow(IActivationState? activationState)
       {
          return new Window(new AppShell());
        }
    }
}