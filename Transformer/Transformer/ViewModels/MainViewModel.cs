using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Transformer.ViewModels
{
    public class MainViewModel:INotifyPropertyChanged 
    {
        private double _primaryTurns;
        private double _secondryTurns;
        public double Height { get; set; }
        public double Width { get; set; }
        public double PrimaryVolt { get; set; }
        public double SecondryVolt { get; set; }

        public double PrimaryTurns
        {
            get { return _primaryTurns; }
            set
            {
                _primaryTurns = value;
                OnPropertyChanged();
            }
        }

        public double SecondryTurns
        {
            get { return _secondryTurns; }
            set
            {
                _secondryTurns = value;
                OnPropertyChanged();
            }
        }

        public double CoreArea { get; set; }
        public double  NewCoreArea { get; set; }
        public Command CalculateCommand => new Command(() =>
                                                         {
                                                             CoreArea = (Height * Width);
                                                             NewCoreArea = (1.11 * 4 * 60000 * CoreArea * 50);
                                                             double temp= 100000000 / NewCoreArea;
                                                             PrimaryTurns   = Math.Round((temp * PrimaryVolt),2);
                                                             SecondryTurns =Math.Round( (temp * SecondryVolt),2);
                                                         });


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}