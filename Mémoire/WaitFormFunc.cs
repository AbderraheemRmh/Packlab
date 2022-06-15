using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mémoire.Forms;
using System.Threading;
using System.Windows.Forms;

namespace Mémoire
{
    public class WaitFormFunc
    {
        WaitForm wait;
        Thread loadThread;

        public void show()
        {
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }
        public void show(Form parent)   
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start();
        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadThread = null;
            }
        }

        private void LoadingProcess()
        {
            wait = new WaitForm();
            wait.ShowDialog();
        }

        private void LoadingProcess(Object parent)
        {
            Form _Parent = parent as Form;
            wait = new WaitForm(_Parent);
            wait.ShowDialog();
        }
    }
}
