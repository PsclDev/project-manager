using System;
using System.Windows;
using System.Windows.Media;

namespace ProjectManager
{
    public static class CstmMsgBx
    {
        private static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        public static void Show(string Text, string HexColor = "#C7EA46", int Interval = 2250)
        {
            try
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        Timer.Tick += new EventHandler(OnTimeEvent);
                        Timer.Interval = Interval;
                        Timer.Start();
                        (window as MainWindow).Snackbar_MessageBox.IsActive = true;
                        (window as MainWindow).Snackbar_MessageBox.Background = new BrushConverter().ConvertFromString(HexColor) as SolidColorBrush;
                        (window as MainWindow).Snackbar_MessageBox.Foreground = Brushes.Black;
                        (window as MainWindow).SnackbarMessage.Content = Text;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("A error occurred while trying to show CstmMsgBx", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                Log.Error(Log.GetMethodName(), exc.ToString());
            }
        }

        public static void Error(string Text, int Interval = 2250)
        {
            try
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        Timer.Tick += new EventHandler(OnTimeEvent);
                        Timer.Interval = Interval;
                        Timer.Start();
                        (window as MainWindow).Snackbar_MessageBox.IsActive = true;
                        (window as MainWindow).Snackbar_MessageBox.Background = new BrushConverter().ConvertFromString("#DC143C") as SolidColorBrush;
                        (window as MainWindow).Snackbar_MessageBox.Foreground = Brushes.White;
                        (window as MainWindow).SnackbarMessage.Content = Text;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("A error occurred while trying to show CstmMsgBx", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                Log.Error(Log.GetMethodName(), exc.ToString());
            }
        }

        public static void CustomMessage(string Text, string BackgroundColor = "#26252E", string ForegroundColor = "#fff", int Interval = 2250)
        {
            try
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        Timer.Tick += new EventHandler(OnTimeEvent);
                        Timer.Interval = Interval;
                        Timer.Start();
                        (window as MainWindow).Snackbar_MessageBox.IsActive = true;
                        (window as MainWindow).Snackbar_MessageBox.Background = new BrushConverter().ConvertFromString(BackgroundColor) as SolidColorBrush;
                        (window as MainWindow).Snackbar_MessageBox.Foreground = new BrushConverter().ConvertFromString(ForegroundColor) as SolidColorBrush;
                        (window as MainWindow).SnackbarMessage.Content = Text;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("A error occurred while trying to show CstmMsgBx", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                Log.Error(Log.GetMethodName(), exc.ToString());
            }
        }

        private static void OnTimeEvent(object source, EventArgs e)
        {
            try
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                        (window as MainWindow).Snackbar_MessageBox.IsActive = false;
                }
                Timer.Stop();
            }
            catch (Exception exc)
            {
                CstmMsgBx.Error("A error occurred in CstmMsgBx.OnTimeEvent()");
                Log.Error(Log.GetMethodName(), exc.ToString());
            }
        }
    }
}
