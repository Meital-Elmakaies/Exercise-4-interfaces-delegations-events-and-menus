namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class MenuItem
    {
        private readonly List<ISelectedObserver> r_SelectedObservers = new List<ISelectedObserver>();
        private readonly List<MenuItem> r_SubMenuList = new List<MenuItem>();
        private string m_SelectedOption;
        private bool m_IsSelect = false;

        public MenuItem(string i_SelectedOption)
        {
            m_SelectedOption = i_SelectedOption;
        }

        public string SelectOption
        {
            get { return m_SelectedOption; }
            set { m_SelectedOption = value; }
        }

        public bool IsSelect
        {
            get { return m_IsSelect; }
            set
            {
                m_IsSelect = value;
                if (value)
                {
                    doWhenClicked();
                }
            }
        }

        public List<MenuItem> SubMenuList
        {
            get { return r_SubMenuList; }
        }

        public List<ISelectedObserver> SelectedObservers
        {
            get { return r_SelectedObservers; }
        }

        public void AddSubItem(MenuItem i_Item)
        {
            SubMenuList.Add(i_Item);
        }

        public void AttachObserver(ISelectedObserver i_SelectedObserver)
        {
            r_SelectedObservers.Add(i_SelectedObserver);
        }

        public void DetachObserver(ISelectedObserver i_SelectedObserver)
        {
            r_SelectedObservers.Remove(i_SelectedObserver);
        }

        private void doWhenClicked()
        {
            if (SelectedObservers.Count == 0)
            {
                MenuUtil.ShowMenu(m_SelectedOption, r_SubMenuList);
            }
            else
            {
                notifySelectObservers();
            }
        }

        private void notifySelectObservers()
        {
            foreach (ISelectedObserver observer in SelectedObservers)
            {
                observer.ReportSelected(SelectOption);
            }
        }
    }
}
