using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class WaitFormWithParameter : Form
    {
        public Action<object> Worker { get; set; }
        public object Parameter;
        public WaitFormWithParameter(Action<object> worker, object parameter)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
            Parameter = parameter;
        }

        private void WaitFormWithParameter_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Worker, Parameter).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
