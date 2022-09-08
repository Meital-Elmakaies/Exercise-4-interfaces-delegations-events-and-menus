namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class MenuUtil
    {
        public static void ShowMenu(string i_MenuName, List<MenuItem> i_MenuItems)
        {
            bool exitKey = false;
            while (!exitKey)
            {
                int userChoice;
                string msg = string.Format("{0}", i_MenuName);
                Console.WriteLine(msg);

                for (int i = 1; i < i_MenuItems.Count; i++)
                {
                    Console.WriteLine("{0} - {1}", i, i_MenuItems[i].SelectOption);
                }

                Console.WriteLine("0 - {0}", i_MenuItems[0].SelectOption);
                Console.WriteLine();

                userChoice = getUserChoice(i_MenuItems.Count - 1);
                Console.Clear();

                if (userChoice != 0)
                {
                    i_MenuItems[userChoice].IsSelect = true;
                }
                else
                {
                    exitKey = true;
                }
            }
        }

        private static int getUserChoice(int i_NumOfSelections)
        {
            int userSelection = 0;
            bool isValid = false;

            Console.WriteLine("Please select option: ");
            while (!isValid)
            {
                try
                {
                    userSelection = int.Parse(Console.ReadLine());
                    if (userSelection <= i_NumOfSelections && userSelection >= 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input! enter only integer number between 0 - {0}", i_NumOfSelections);
                }
            }

            return userSelection;
        }
    }
}
