using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public MainWindow()
        {
            //AllocConsole();
            InitializeComponent();
            Database.TestConnection();
        }

        private void Btn_CloseApplication_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_TestDatabaseConnection_Click(object sender, RoutedEventArgs e)
        {
            Database.TestConnection();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        
        private void Btn_NewProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_AddNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_AddToDo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_AddMeeting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Load_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ListView_Meetings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ListView_ToDo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ListView_Notes_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
