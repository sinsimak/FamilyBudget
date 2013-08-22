using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using FamilyBudgetSilverlightApp.BudgetServiceReference;
using FamilyBudgetSilverlightApp.HelloWorldService;

namespace FamilyBudgetSilverlightApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            TextResult = "Initial Value";
            BudgetName = "Initial Value";
        }

        private ICommand _loadWordCommand;
        public ICommand LoadWordCommand
        {
            get
            {
                if(_loadWordCommand == null)
                {
                    _loadWordCommand = new Command(LoadWord);
                }
                return _loadWordCommand;
            }
        }

        private string _textResult;
        public string TextResult
        {
            get
            {
                return _textResult;
            }
            set
            {
                _textResult = value;
                NotifyPropertyChanged("TextResult");
            }
        }

        private void LoadWord()
        {
            HelloWorldServiceClient proxy = new HelloWorldServiceClient(); 
            proxy.GetWordCompleted += ProxyOnGetWordCompleted;
            proxy.GetWordAsync();
        }

        private void ProxyOnGetWordCompleted(object sender, GetWordCompletedEventArgs getWordCompletedEventArgs)
        {
            TextResult = getWordCompletedEventArgs.Result;
        }

        private string _budgetName;
        public string BudgetName
        {
            get { return _budgetName; }
            set 
            { 
                _budgetName = value;
                NotifyPropertyChanged("BudgetName");
            }
        }

        private ICommand _loadBudgetDtoCommamd;
        public ICommand LoadBudgetDtoCommand
        {
            get
            {
                if (_loadBudgetDtoCommamd == null)
                {
                    _loadBudgetDtoCommamd = new Command(LoadBudgetDto);
                }
                return _loadBudgetDtoCommamd;
            }
        }

        private void LoadBudgetDto()
        {
            BudgetServiceClient proxy = new BudgetServiceClient();
            proxy.GetBudgetByIdCompleted += ProxyOnGetBudgetByIdCompleted;
            proxy.GetBudgetByIdAsync(1);
        }

        private void ProxyOnGetBudgetByIdCompleted(object sender, GetBudgetByIdCompletedEventArgs getBudgetByIdCompletedEventArgs)
        {
            BudgetName = getBudgetByIdCompletedEventArgs.Result.Name;
        }
    }
}
