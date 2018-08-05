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

namespace Chart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Polyline sineCurve;

        public MainWindow()
        {
            InitializeComponent();

            sineCurve = new Polyline();
            sineCurve.Stroke = Brushes.Red;
            sineCurve.StrokeThickness = 1;
            content.Content = sineCurve;
            AddPoints2();
        
        }
        private void AddPoints1()
        {
            for (double x = 0; x < 90; x += 0.25)
            {
                sineCurve.Points.Add(new Point(x*5, 250 + 250 * Math.Sin(x / Math.PI)));
            }
        }
        private void AddPoints2()
        {
            for (double x = 0; x < 90; x += 5)
            {
                sineCurve.Points.Add(new Point(x * 5, x % 2 != 0 ? 250 : 0));
                sineCurve.Points.Add(new Point(x * 5 + 25, x % 2 != 0 ? 250 : 0));
            }
        }
    }
}
