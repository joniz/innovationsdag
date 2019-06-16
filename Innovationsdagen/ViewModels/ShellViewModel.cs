using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Innovationsdagen.Models;
using System.Collections.ObjectModel;

namespace Innovationsdagen.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ObservableCollection<Server> Servers { get; set; }
        
        public ShellViewModel()
        {
            Servers = new ObservableCollection<Server>();

            for(int i = 0; i < 5; i++)
            {
                Servers.Add(new Server
                {
                    Name = $"Nytt namn {i}"
                });
            }
            
        }

    }
}
