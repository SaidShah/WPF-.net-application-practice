using System.Windows;

namespace FirstWPFproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // to change the title for the project
            Title = "hello world";
            // to change the start up of the screen
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}