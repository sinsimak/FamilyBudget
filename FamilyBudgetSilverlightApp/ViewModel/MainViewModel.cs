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
using FamilyBudgetSilverlightApp.HelloWorldService;

namespace FamilyBudgetSilverlightApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            TextResult = "Initial Value";
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
    }
}
