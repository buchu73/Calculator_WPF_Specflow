using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Calculator _calculator;
        
        public MainViewModel()
        {
            this._calculator = new Calculator();
            this.AddCommand = new RelayCommand(this.Add);
            this.SubCommand = new RelayCommand(this.Substract);
            this.MulCommand = new RelayCommand(this.Multiply);
            this.DivCommand = new RelayCommand(this.Divide);
        }       

        private string _firstNumber;
        public string FirstNumber
        {
            get { return _firstNumber; }
            set 
            {
                if (_firstNumber != value)
                {
                    _firstNumber = value;
                    this.RaisePropertyChanged("FirstNumber");
                }
            }
        }

        private string _secondNumber;
        public string SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                if (_secondNumber != value)
                {
                    _secondNumber = value;
                    this.RaisePropertyChanged("SecondNumber");
                }
            }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set 
            {
                if (_result != value)
                {
                    _result = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }


        public RelayCommand AddCommand { get; private set; }
        public RelayCommand SubCommand { get; private set; }
        public RelayCommand MulCommand { get; private set; }
        public RelayCommand DivCommand { get; private set; }

        private void Add()
        {
            this.SetNumbersToCalculator();
            this.Result = this._calculator.Add();            
        }

        private void Divide()
        {
            this.SetNumbersToCalculator();
            this.Result = this._calculator.Divide();
        }

        private void Multiply()
        {
            this.SetNumbersToCalculator();
            this.Result = this._calculator.Multiply();
        }

        private void Substract()
        {
            this.SetNumbersToCalculator();
            this.Result = this._calculator.Subtract();
        }

        private void SetNumbersToCalculator()
        {
            this._calculator.FirstNumber = int.Parse(this.FirstNumber);
            this._calculator.SecondNumber = int.Parse(this.SecondNumber);
        }
    }
}
