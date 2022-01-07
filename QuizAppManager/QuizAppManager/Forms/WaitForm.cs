using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppManager.Forms
{
    public partial class WaitForm : Form
    {
        public Action Worker { get; set; }
        public WaitForm(Action worker)
        {
            InitializeComponent();

            Worker = worker;
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
