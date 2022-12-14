namespace Ex04.Menus.Test
{
    using System;
    using System.Collections.Generic;
    using Ex04.Menus.Delegates;

    public class DelegateMenuDemo
    {
        private const string k_Exit = "Exit";
        private const string k_Back = "Back";
        private const string k_VersionSpaces = "Version and Spaces";
        private const string k_DateTime = "Show Date/Time";
        private MainMenu m_MainMenu;

        public DelegateMenuDemo()
        {
            m_MainMenu = new MainMenu("Main Menu");
        }

        public void Show()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            MenuItem item;

            // add the Exit option to the main menu
            menuItems.Add(new MenuItem(k_Exit));

            // add the Version and Spaces option to the main menu
            menuItems.Add(new MenuItem(k_VersionSpaces));

            // add sub options to the Version and Spaces menu
            menuItems[1].AddSubItem(new MenuItem(k_Back));
            item = new MenuItem("Count Spaces");
            item.ReportClickDelegate += CountOfEnteredSpaces;
            menuItems[1].AddSubItem(item);

            item = new MenuItem("Show Version");
            item.ReportClickDelegate += ShowVersion;
            menuItems[1].AddSubItem(item);

            // add the Show Date/Time option to the main menu
            menuItems.Add(new MenuItem(k_DateTime));

            // add sub options to the Show Date/Time menu
            menuItems[2].AddSubItem(new MenuItem(k_Back));

            item = new MenuItem("Show Time");
            item.ReportClickDelegate += ShowCurrentTime;
            menuItems[2].AddSubItem(item);

            item = new MenuItem("Show Date");
            item.ReportClickDelegate += ShowCurrentDate;
            menuItems[2].AddSubItem(item);

            m_MainMenu.AddMenuItem(menuItems);
            m_MainMenu.Show();
        }

        public void ShowCurrentDate(MenuItem i_Item)
        {
            Console.Clear();
            DateTime currentDate = DateTime.Now;
            string date = string.Format("The Date Of Today is: {0}", currentDate.ToString("dd/MM/yyyy"));
            Console.WriteLine(date);
        }

        public void ShowCurrentTime(MenuItem i_Item)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;

            string time = string.Format("The time now is: {0}", currentTime.ToString("HH:mm:ss"));
            Console.WriteLine(time);
        }

        public void CountOfEnteredSpaces(MenuItem i_Item)
        {
            Console.Clear();
            Console.WriteLine("Please write something ");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int numOfSpaces = splitInput.Length;

            Console.WriteLine("Number Of Spaces: {0}", numOfSpaces - 1);
        }

        public void ShowVersion(MenuItem i_Item)
        {
            Console.Clear();
            Console.WriteLine("Version: 21.3.4.8933");
        }
    }
}
