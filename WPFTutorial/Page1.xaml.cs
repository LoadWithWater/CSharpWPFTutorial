using System.Windows.Controls;

namespace WPFTutorial
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        bool running = false;

        public Page1()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (running) {
                // stop
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            } else {
                // run
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            
            running = !running;
        }
    }
}
