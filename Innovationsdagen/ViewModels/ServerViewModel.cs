using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Caliburn.Micro;

namespace Innovationsdagen.ViewModels
{
    public class ServerViewModel : Screen
    {
        private string _fullName;

        public bool IsSelected { get; set; }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                NotifyOfPropertyChange(() => FullName);
            }
        } 

    }
}
