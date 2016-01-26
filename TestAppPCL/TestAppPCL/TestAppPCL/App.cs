using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestAppPCL
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var database = new RandomThoughtDatabase();
            MainPage = new NavigationPage(new RandomThoughtsPage(database));
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
    }
}
