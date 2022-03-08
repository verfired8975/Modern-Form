using System;

using System.Windows;
using System.Windows.Controls;


namespace VIVA_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public TabControl Tab = null;

        private void AddTab(object sender, RoutedEventArgs e)
        {
            VIVA_Functions.AddTabFunction(Tab, ("Script " + (Tab.Items.Count + 1)), "");
        }

        private void Start(object sender, StartupEventArgs e)
        {
            try
            {
                var VIVA = new VIVA();
                VIVA.Show();
                Tab = VIVA.Tabs;
                AddTab(null, null);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.DialogResult Result = System.Windows.Forms.MessageBox.Show("An error Has occured, would you like to copy the error to your clipboard?", "VIVA Error Handler.", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1);
                if (Result == System.Windows.Forms.DialogResult.Yes)
                {
                    Clipboard.SetText(ex.ToString());
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            System.Windows.Forms.DialogResult Result = System.Windows.Forms.MessageBox.Show("An error Has occured, would you like to copy the error to your clipboard?", "VIVA Error Handler.", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            e.Handled = true;
        }
    }
}
