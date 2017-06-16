using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EmptyGroup
{
    public class App : Application
    {
        public App()
        {

            var deluxGroup = new StringGroup("French Cheeses")
            {
                "Bleu d'Auvergne", "Brie de Meaux"  // If this line is commented out, app will crash on Android (but not iOS)
            };
            var mericanGroup = new DeluxStringGroup("`merica Cheeses")
            {
                "Cheez Whiz", "Velveeta"   // If this line is commented out, app will crash on Android (but not iOS)
            };


            var dataSource = new List<StringGroup>
            {
                deluxGroup,
                mericanGroup
            };


            var listView = new ListView
            {
                ItemsSource = dataSource,
                IsGroupingEnabled = true,
                GroupHeaderTemplate = new GroupDataTemplateSelector()
            };


            var content = new ContentPage
            {
                Title = "GroupTemplateSelector + an empty group Demo",
                Content = listView
            };


            MainPage = new NavigationPage(content);
        }

    }
}
