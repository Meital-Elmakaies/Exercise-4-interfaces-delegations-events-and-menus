namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MainMenu
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly string r_MenuName;

        public MainMenu(string i_MenuName)
        {
            r_MenuName = i_MenuName;
        }

        public string MenuName
        {
            get { return r_MenuName; }
        }

        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public void AddMenuItem(List<MenuItem> i_MenuItems)
        {
            foreach (MenuItem item in i_MenuItems)
            {
                MenuItems.Add(item);
            }
        }

        public void Show()
        {
            MenuUtil.ShowMenu(MenuName, MenuItems);
        }
    }
}
