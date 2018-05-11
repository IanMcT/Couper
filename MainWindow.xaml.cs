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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Couper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables
        Player player1;
        Player player2;
        System.Windows.Threading.DispatcherTimer gameTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            player1 = new Player(new Point(0, 0), 1);
            player2 = new Player(new Point(this.Width, this.Height), -1);
            //start Timer
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);//fps
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            this.Title = player1.update().ToString() + " Player 1 and: " + player2.update().ToString() + " Player 1";
        }
    }
}
