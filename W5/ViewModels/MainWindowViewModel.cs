using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using W5.Model;

namespace W5.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public ObservableCollection<Message> Messages { get; set; }

        public ICommand CreateMessageCommand { get; set; }


        public MainWindowViewModel()
        {
               
        }
    }
}
