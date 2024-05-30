using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_paper.Command
{
    class Relaycommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> execute;

        public Relaycommand(Action<object> execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
