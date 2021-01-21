using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandler
{
    public partial class MainTarget : Form
    {
       

       
           
        public MainTarget()
        {
            InitializeComponent();
        }

        private void MainTarget_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += (ae, eventArgs) =>
            {
                var Result = MessageBox.Show($"An exception has been thrown. Please report the following error message to a developer, the message has been copied to your clipboard:\n\n{((Exception)eventArgs.ExceptionObject)}");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}
