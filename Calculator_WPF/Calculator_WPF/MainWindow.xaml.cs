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
using CalculatorLib;

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string equation = "";
        char mathSymbol= ' ';
        double _num1 = 0;
        double _num2 = 0;
        int d = 0;
        List<string> eq;
        int _multiplyCount = 0;
        int _divisionCount = 0;
        int _addCount = 0;
        int _subtractCount = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pick_1(object sender, RoutedEventArgs e)
        {
            equation += 1.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_2(object sender, RoutedEventArgs e)
        {
            equation += 2.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_3(object sender, RoutedEventArgs e)
        {
            equation += 3.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_4(object sender, RoutedEventArgs e)
        {
            equation += 4.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_5(object sender, RoutedEventArgs e)
        {
            equation += 5.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_6(object sender, RoutedEventArgs e)
        {
            equation += 6.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_7(object sender, RoutedEventArgs e)
        {
            equation += 7.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_8(object sender, RoutedEventArgs e)
        {
            equation += 8.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_9(object sender, RoutedEventArgs e)
        {
            equation += 9.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_0(object sender, RoutedEventArgs e)
        {
            equation += 0.ToString();
            LabelResult.Content = equation;
        }

        private void Pick_Decimal(object sender, RoutedEventArgs e)
        {
            equation += ".";
            LabelResult.Content = equation;
        }

        private void Pick_Divide(object sender, RoutedEventArgs e)
        {
      
            if (equation != "")
            {
                double.TryParse(equation, out _num1);
                mathSymbol = '/';
                Value1.Content = equation + " /";
                equation = "";
                LabelResult.Content = "";
            }
        }

        private void Pick_Multiply(object sender, RoutedEventArgs e)
        {
          
            if (equation != "")
            {
                double.TryParse(equation, out _num1);
                mathSymbol = '*';
                Value1.Content = equation + " *";
                equation = "";
                LabelResult.Content = "";
            }
        }

        private void Pick_Subtract(object sender, RoutedEventArgs e)
        {
           
            if (equation != "")
            {
                double.TryParse(equation, out _num1);
                mathSymbol = '-';
                Value1.Content = equation + " -";
                equation = "";
                LabelResult.Content = "";
            }
        }

        private void Pick_Add(object sender, RoutedEventArgs e)
        {
           
            if (equation != "")
            {
                double.TryParse(equation, out _num1);
                mathSymbol = '+';
                Value1.Content = equation + " +";
                equation = "";
                LabelResult.Content = "";
            }
        }

        private void Pick_Result(object sender, RoutedEventArgs e)
        {
           
            var numBool = double.TryParse(equation, out _num2);
            switch (mathSymbol)
            { 
                case '/':
                    if(_num1 == 0 || _num2 == 0)
                    {
                        LabelResult.Content ="Error";
                        Value1.Content = "";
                        _num1 = 0;
                        _num2 = 0;  
                        break;
                    }
                
                    Value1.Content = "";
                    equation =  numBool == false ? "Invalid input" : Calculator.Divide(_num1, _num2).ToString();
                    break;
                case '*':
                    Value1.Content = "";
                    equation = numBool == false ? "Invalid input" : Calculator.Multiply(_num1, _num2).ToString();
                    break;
                case '+':
                    Value1.Content = "";
                    equation = numBool == false ? "Invalid input" : Calculator.Add(_num1, _num2).ToString();
                    break;
                case '-':
                    Value1.Content = "";
                    equation = numBool == false ? "Invalid input" : Calculator.Subtract(_num1, _num2).ToString();
                    break;
                default:
                    break;
            }

            LabelResult.Content = equation;
            int.TryParse(equation, out int result);
            _num1 = result;
            _num2 = 0;
        }

        private void Clear_Label(object sender, RoutedEventArgs e)
        {
              equation = "";
              mathSymbol = ' ';
             _num1 = 0;
             _num2 = 0;
            Value1.Content = "";
            LabelResult.Content = "";
        }

        private int EquestionResult(List<string> input)
        {
            List<string> newList = new List<string>();
            if (_multiplyCount != 0)
            {
                newList = ReturnCalc("*", _multiplyCount, input);
            }

            if (_divisionCount != 0)
            {
                newList = ReturnCalc("/", _multiplyCount, input);
            }

            if (_addCount != 0)
            {
                newList = ReturnCalc("+", _multiplyCount, input);
            }

            if (_subtractCount != 0)
            {
                newList = ReturnCalc("-", _multiplyCount, input);
            }
            string numString = newList[0];
            bool resultBool = int.TryParse(numString,out int result);

            return result;
        }


        private List<string> ReturnCalc(string op, int count, List<string> list)
        {
            var output = list;
            for (int i = 0; i < count; i++)
            {
                int s = list.IndexOf(op);
                int q = int.Parse(list[s - 1]) * int.Parse(list[s + 1]);
                list[s - 1] = q.ToString();
                list.RemoveAt(s);
                list.RemoveAt(s + 1);
            }

            return output;
        }

       
    }
}
