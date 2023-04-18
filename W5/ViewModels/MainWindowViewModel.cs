using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            Messages = new ObservableCollection<Message>();

            CreateMessageCommand = new RelayCommand(() => 
            {
                /*Messages.Add(new Message()
                {
                    messageContent = "Fasz",
                    messageSender = "Sanyo",
                    messageTime = DateTime.Now
                });*/
            });
        }
    }
}
