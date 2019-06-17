using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Innovationsdagen.Models;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace Innovationsdagen.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ObservableCollection<ServerViewModel> Servers { get; set; }

        
        public ShellViewModel()
        {
            Servers = new ObservableCollection<ServerViewModel>();

            for(int i = 0; i < 5; i++)
            {
                Servers.Add(new ServerViewModel
                {
                    FullName = $"Nytt namn {i}"
                });
            }
            
        }

    }
}
