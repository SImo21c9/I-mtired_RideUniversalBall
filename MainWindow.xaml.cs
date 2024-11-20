using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace mywpfApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private readonly DispatcherTimer gameTimer;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            // Initialize game values
            Priser = 10;
            Public_Demand = 20;
            Clips = 0;
            Funds = 100;
            Price = 5;
            AutoBalls = 0;
        }

        private double price;

        public double Price
        {
            get => price;
            set
            {
                price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }

        private double autoballs;

        public double AutoBalls
        {
            get => autoballs;
            set
            {
                autoballs = value;
                NotifyPropertyChanged(nameof(AutoBalls));
            }
        }

        private double priser;
        public double Priser
        {
            get => priser;
            set
            {
                priser = value;
                NotifyPropertyChanged(nameof(Priser));
                
            }
        }

        private double public_demand;
        public double Public_Demand
        {
            get => public_demand;
            set
            {
                public_demand = value;
                NotifyPropertyChanged(nameof(Public_Demand));
            }
        }

        private double clips;
        public double Clips
        {
            get => clips;
            set
            {
                clips = value;
                NotifyPropertyChanged(nameof(Clips));
            }
        }

        private double funds;
        public double Funds
        {
            get => funds;
            set
            {
                funds = value;
                NotifyPropertyChanged(nameof(Funds));
            }
        }

        

         
       
       

        private void Make_Balls(object sender, RoutedEventArgs e)
        {
            Clips += 1;
        }

        private void Lower_Balls(object sender, RoutedEventArgs e)
        {
            if (Priser > 0.1)
            {
                Priser -= 0.1;
            }
        }

        private void Higher_balls(object sender, RoutedEventArgs e)
        {
            Priser += 0.1;
        }

        private void AutoBalls_Balls(object sender, RoutedEventArgs e)
        {
            double cost = 100 * Math.Pow(1.1, AutoBalls); 
            if (Funds >= cost)
            {
                Funds -= cost;
                AutoBalls++;
            } 
        }

        private void Buy_Rubber(object sender, RoutedEventArgs e)
        {
            
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}