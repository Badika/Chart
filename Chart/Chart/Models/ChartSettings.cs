using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Chart.Models
{
    class ChartModel : DependencyObject
    {
        public static readonly DependencyProperty SetBrushProperty =
            DependencyProperty.Register("SetBrush", typeof(string), typeof(ContentControl));

        public string SetTestText
        {
            get { return (string)GetValue(SetBrushProperty); }
            set { SetValue(SetBrushProperty, value); }
        }





        //    public class ChartSettings : INotifyPropertyChanged
        //    {
        //        private Brush testBrush;
        //        public Brush TestBrush
        //        {
        //            get { return testBrush; }
        //            set
        //            {
        //                if (testBrush != value)
        //                {
        //                    testBrush = value;
        //                    OnPropertyChanged("TestBrush");
        //                }

        //            }
        //        }






        //        private List<double> lineData;
        //        private double lineThickness;
        //        private Brush lineBrush;
        //        private string fontFamily;
        //        private double fontSize;
        //        private string xTitle;
        //        private string yTitle;

        //        public List<double> LineData
        //        {
        //            get { return lineData; }
        //            set
        //            {
        //                lineData = new List<double>();
        //                lineData.AddRange(value);
        //                OnPropertyChanged("LineData");
        //            }
        //        }
        //        public double LineThickness {
        //            get { return lineThickness; }
        //            set
        //            {
        //                if (value >= 0)
        //                    lineThickness = value;
        //                else
        //                    lineThickness = 0;
        //                OnPropertyChanged("LineThickness");
        //            }
        //        }
        //        public Brush LineBrush {
        //            get { return lineBrush; }
        //            set
        //            {
        //                lineBrush = value;
        //                OnPropertyChanged("LineBrush");
        //            }
        //        }
        //        public string FontFamily {
        //            get { return fontFamily; }
        //            set
        //            {
        //                if(fontFamily != value)
        //                {
        //                    fontFamily = value;
        //                    OnPropertyChanged("FontFamily");
        //                }

        //            }
        //        }
        //        public double FontSize { get; set; }
        //        public string XAxisTitle { get; set; }
        //        public string YAxisTitle { get; set; }






        //        public event PropertyChangedEventHandler PropertyChanged;
        //        protected void OnPropertyChanged(string propName)
        //        {
        //            if (PropertyChanged != null)
        //                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //        }
        //    }
    }
}
