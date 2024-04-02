using lab4_2_;
class Program
{
    static void Main(string[] args)
    {
        ComputerMonitor monitor = new ComputerMonitor { Name = "Samsung", Component = "monitor" };
        SystemBlock systemBlock = new SystemBlock { Name = "ArtLine", Component = "system block" };
        Mouse mouse = new Mouse { Name = "Logitech", Component = "mouse" };
        Keyboard keyboard = new Keyboard{ Name = "Logitech", Component = "keyboard"};

        PersonalComputer pc = new PersonalComputer(monitor, systemBlock, mouse, keyboard);

        Console.WriteLine(pc.ToString());

        pc.ConnectComponents();
        pc.TurnOn();
        pc.TurnOff();
        pc.DisconnectComponents();
    }
}