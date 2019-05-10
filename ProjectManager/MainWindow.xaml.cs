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

        private void RunSQL(string SQL)
        {
            try
            {
                Database.RunSQL(SQL);
                TxtBx_Name.Background = Brushes.White;
                TxtBx_Name.Text = "";
            }
            catch (Exception exc)
            {
                CstmMsgBx.Error(exc.ToString());
                Log.Error(Log.GetMethodName(), exc.ToString());
            }
        }

        private void BtnAddProjects_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Name.Text == "")
                MissingValue("Bitte tragen Sie ein Projektnamen ein");
            else
            {
                //RunSQL($"INSERT INTO Projects (name) VALUES ('{TxtBx_Name.Name}')");
                Project project = new Project
                {
                    Name = TxtBx_Name.Text
                };

                ListView_Projects.Items.Add(project);
            }
        }

        private void Btn_AddNote_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Name.Text == "")
                MissingValue("Bitte tragen Sie einen Titel ein");
            else
            {
                if (ListView_Projects.SelectedIndex != -1)
                {
                    //RunSQL($"INSERT INTO Notes (title) VALUES ('{TxtBx_Name.Name}')");
                    Objects.MyTreeViewItem art = new Objects.MyTreeViewItem();
                    art.Header = TxtBx_Name.Text;
                    art.Index = 1;

                    Objects.MyTreeViewItem prt = new Objects.MyTreeViewItem();
                    prt.Header = TxtBx_Name.Text;
                    prt.Index = 2;

                    TreeView_Note.Items.Add(art);
                }
                else
                    CstmMsgBx.Error("Es wurde kein Projekt ausgewählt");
            }
        }

        private void Btn_AddToDo_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Name.Text == "")
                MissingValue("Bitte tragen Sie einen Titel ein");
            else
            {
                if (ListView_Projects.SelectedIndex != -1)
                {
                    //RunSQL($"INSERT INTO ToDo (title) VALUES ('{TxtBx_Name.Name}')");
                    TreeView_ToDo.Items.Add(TxtBx_Name.Text);
                }
                else
                    CstmMsgBx.Error("Es wurde kein Projekt ausgewählt");
            }
        }

        private void Btn_AddMeeting_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Name.Text == "")
                MissingValue("Bitte tragen Sie einen Titel ein");
            else
            {
                if (ListView_Projects.SelectedIndex != -1)
                {
                    //RunSQL($"INSERT INTO Notes (title) VALUES ('{TxtBx_Name.Name}')");
                    TreeView_Meetings.Items.Add(TxtBx_Name.Text);
                }
                else
                    CstmMsgBx.Error("Es wurde kein Projekt ausgewählt");
            }
        }

        private void MissingValue(string message)
        {
            CstmMsgBx.Error(message);
            TxtBx_Name.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#ff3232");
        }

        private void Btn_Export_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Import_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var name = TreeView.SelectedItem.ToString();

            CstmMsgBx.Show(name.ToString());
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Objects.MyTreeViewItem selectedItem = e.NewValue as Objects.MyTreeViewItem;
            if (selectedItem != null)
            {
                MessageBox.Show("" + selectedItem.Index);

            }
        }
    }
}
