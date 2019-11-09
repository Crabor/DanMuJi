using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DanMuJi.Pages
{
    /// <summary>
    /// DanMuArea.xaml 的交互逻辑
    /// </summary>
    public partial class DanMuArea : Window
    {
        DispatcherTimer timer1 = new DispatcherTimer();
        private string danMu;
        private double danMuActualWidth;



        public DanMuArea()
        {
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
            var socket = IO.Socket("wss://wx.sifeizhai.me");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("链接成功");
                socket.On("broadcast", (data) =>
                {
                    danMu = data.ToString();
                    Dispatcher.BeginInvoke(new Action(delegate { SendDanmu(); }));
                });
            });

            timer1.Tick += new EventHandler(TopMost);
            timer1.Start();
        }


        private void TopMost(object sender, EventArgs e)
        {
            this.Topmost = true;
        }

        private void SendDanmu()
        {
            TextBlock text = new TextBlock();
            text.Text = danMu;
            text.AddHandler(TextBlock.LoadedEvent, new RoutedEventHandler(GetActualWidthOfDanMu));


            text.FontSize = 30;

            //text.Style = Resources["TextBlockStyle"] as Style;
            text.Style = (Style)this.FindResource("TextBlockStyle");
            //text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("White"));
            //System.Windows.Media.Effects.DropShadowEffect ds = new System.Windows.Media.Effects.DropShadowEffect();
            //ds.Color = (Color)ColorConverter.ConvertFromString("#FF616161");
            //ds.ShadowDepth = 1.5;
            //ds.Opacity = 1;
            //text.Effect = ds;
            myCanvas.Children.Add(text);

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = myWin.ActualWidth;
            doubleAnimation.To = -danMuActualWidth;
            doubleAnimation.Duration = TimeSpan.FromSeconds(10);
            text.BeginAnimation(Canvas.LeftProperty, doubleAnimation);

        }

        private void GetActualWidthOfDanMu(object sender, RoutedEventArgs e)
        {
            TextBlock text = sender as TextBlock;
            danMuActualWidth = text.ActualWidth;
        }
    }
}
