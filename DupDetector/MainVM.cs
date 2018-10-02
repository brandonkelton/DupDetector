using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DupDetector
{
    public class MainVM : ObservableObject
    {
        public event EventHandler CloseWizard;

        public MainVM()
        {
            CloseWizardCommand = new RelayCommand(x => CloseWizardAction(), x => true);
        }

        protected virtual void OnCloseWizard(EventArgs e)
        {
            CloseWizard?.Invoke(this, e);
        }

        public ICommand CloseWizardCommand { get; }
        private void CloseWizardAction()
        {
            OnCloseWizard(new EventArgs());
        }

        public string Text { get; set; } = "Testing";
    }
}
