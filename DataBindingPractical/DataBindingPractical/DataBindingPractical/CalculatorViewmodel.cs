using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataBindingPractical
{
  public enum Operator
  {
    Default, Add, Subtract, Multiply, Divide
  };
  public class CalculatorViewmodel : INotifyPropertyChanged
  {
    private bool shouldClearResult = false;

    private Operator currentOperator = Operator.Default;
    private Operator previousOperator = Operator.Default;

    private double? operandOne = null;
    private double? operandTwo = null;

    private string result;
    public string Result
    {
      get
      {
        return result;
      }
      set
      {
        if (result != value)
        {
          result = value;
          OnPropertyChanged("Result");
        }
      }
    }
    public ICommand AddCharacter
    {
      get
      {
        return new Command<string>((character) =>
        {
          if (shouldClearResult)
          {
            Result = string.Empty;
          }
          Result = Result + character;
        });
      }
    }

    public ICommand AddOperator
    {
      get
      {
        return new Command<Operator>((oper) =>
        {
          currentOperator = oper;
          if (operandOne == null)
          {
            operandOne = double.Parse(result);
          }
          else
          {
            operandTwo = double.Parse(result);
          }
          EvaluateResult();
          previousOperator = currentOperator;
          currentOperator = Operator.Default;
          shouldClearResult = true;
        });
      }
    }

    public ICommand Evaluate
    {
      get
      {
        return new Command(() =>
        {
          if (previousOperator != Operator.Default && operandOne != null)
          {
            operandTwo = double.Parse(result);
          }
          EvaluateResult();
          previousOperator = Operator.Default;
          operandOne = null;
          operandTwo = null;
          shouldClearResult = true;
        });
      }
    }

    public ICommand ClearAll
    {
      get
      {
        return new Command(() =>
       {
         operandOne = operandTwo = null;
         currentOperator = Operator.Default;
         Result = string.Empty;
       }
       );
      }
    }

    private void EvaluateResult()
    {
      if (operandOne != null && operandTwo != null)
        switch (previousOperator)
        {
          case Operator.Default:
            break;
          case Operator.Add:
            operandOne = operandOne + operandTwo;
            break;
          case Operator.Subtract:
            operandOne = operandOne - operandTwo;
            break;
          case Operator.Multiply:
            operandOne = operandOne * operandTwo;
            break;
          case Operator.Divide:
            operandOne = operandOne / operandTwo;
            break;
        }
      Result = operandOne.ToString();
    }

    private void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    public event PropertyChangedEventHandler PropertyChanged;
  }
}
