namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegateMenuDemo delegateMenu = new DelegateMenuDemo();
            InterfaceMenuDemo interfaceMenu = new InterfaceMenuDemo();
            interfaceMenu.Show();
            delegateMenu.Show();
        }
    }
}
