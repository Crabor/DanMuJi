using DanMuJi.Pages;
using FirstFloor.ModernUI.Windows.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DanMuJi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TemporButton_Click(object sender, RoutedEventArgs e)
        {
            IndexStackPanel.Visibility = Visibility.Hidden;
            IndexImage.Visibility = Visibility.Hidden;
            //WaitTemporRing.Visibility = Visibility.Visible;
            //WaitTemporTextBlock.Visibility = Visibility.Visible;
            //TemporRoomImage.Visibility = Visibility.Visible;
            //TemporRoomSetPanel.Visibility = Visibility.Visible;
            TemporRoomNameTextBox.Visibility = Visibility.Visible;
            TemporRoomNameStackPanel.Visibility = Visibility.Visible;

        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            IndexStackPanel.Visibility = Visibility.Hidden;
            IndexImage.Visibility = Visibility.Hidden;
            LogInInfoStackPanel.Visibility = Visibility.Visible;
            LogInDesicionStackPanel.Visibility = Visibility.Visible;
        }

        private void DanMuFieldComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TemporRoomNameConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            TemporRoomNameTextBox.Visibility = Visibility.Hidden;
            TemporRoomNameStackPanel.Visibility = Visibility.Hidden;
            WaitTemporRing.Visibility = Visibility.Visible;
            WaitTemporTextBlock.Visibility = Visibility.Visible;

            //客户端向服务端发送创建临时房间请求


            //服务器成功返回临时房间
            DanMuArea danMuArea = new DanMuArea();
            danMuArea.Show();
            WaitTemporRing.Visibility = Visibility.Hidden;
            WaitTemporTextBlock.Visibility = Visibility.Hidden;
            TemporRoomInfoStackPanel.Visibility = Visibility.Visible;
            TemporRoomSetPanel.Visibility = Visibility.Visible;
        }

        private void TemporRoomNameCancelButton_Click(object sender, RoutedEventArgs e)
        {
            TemporRoomNameTextBox.Text = null;
            TemporRoomNameTextBox.Visibility = Visibility.Hidden;
            TemporRoomNameStackPanel.Visibility = Visibility.Hidden;
            IndexStackPanel.Visibility = Visibility.Visible;
            IndexImage.Visibility = Visibility.Visible;
        }

        private void BackToIndexButton_Click(object sender, RoutedEventArgs e)
        {
            //如果打开了临时房间，关闭之



            RoomStackPanel.Visibility = Visibility.Hidden;
            TemporRoomNameTextBox.Visibility = Visibility.Hidden;
            TemporRoomNameStackPanel.Visibility = Visibility.Hidden;
            TemporRoomInfoStackPanel.Visibility = Visibility.Hidden;
            TemporRoomSetPanel.Visibility = Visibility.Hidden;
            IndexImage.Visibility = Visibility.Visible;
            IndexStackPanel.Visibility = Visibility.Visible;
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new ModernWindow
            {
                Style = (Style)App.Current.Resources["BlankWindow"],
                Title = "设置",
                IsTitleVisible = true,
                Content = new SettingsPage(),
                Width = 480,
                Height = 480
            };

            wnd.Show();
        }

        private void LogInConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            UserTextBlock.Text = null;
            PassWordTextBlock.Text = null;
            LogInInfoStackPanel.Visibility = Visibility.Hidden;
            LogInDesicionStackPanel.Visibility = Visibility.Hidden;
            RoomStackPanel.Visibility = Visibility.Visible;
        }

        private void LogInCancelButton_Click(object sender, RoutedEventArgs e)
        {
            UserTextBlock.Text = null;
            PassWordTextBlock.Text = null;
            LogInInfoStackPanel.Visibility = Visibility.Hidden;
            LogInDesicionStackPanel.Visibility = Visibility.Hidden;
            IndexStackPanel.Visibility = Visibility.Visible;
            IndexImage.Visibility = Visibility.Visible;
        }
    }
}
