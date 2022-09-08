namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MenuItem
    {
        private readonly List<MenuItem> r_SubMenuList = new List<MenuItem>();
        private bool m_IsSelect = false;
        private string m_SelectedOption;

        public MenuItem(string i_SelectedOption)
        {
            m_SelectedOption = i_SelectedOption;
        }

        public event Action<MenuItem> ReportClickDelegate;

        public List<MenuItem> SubMenuList
        {
            get { return r_SubMenuList; }
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
                    OnReportClickDelegate();
                }
            }
        }

        public void AddSubItem(MenuItem i_Item)
        {
            SubMenuList.Add(i_Item);
        }

        protected virtual void OnReportClickDelegate()
        {
            if (ReportClickDelegate != null)
            {
                ReportClickDelegate.Invoke(this);
            }
            else
            {
                MenuUtil.ShowMenu(SelectOption, SubMenuList);
            }
        }
    }
}
