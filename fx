using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Security;



namespace Fx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntFunction_Click(object sender, EventArgs e)
        {
            this.txtVbsReturn.Text = "Clicked";
            System.Diagnostics.Process vbs = new System.Diagnostics.Process();

            vbs.StartInfo.FileName="cscript";
            vbs.StartInfo.UseShellExecute = false;
            vbs.StartInfo.RedirectStandardOutput=true;
            vbs.StartInfo.Arguments= "//nologo C:\\Users\\AnOther\\Desktop\\jsApp\\function.vbs \"HelloWorld\"";
            vbs.Start();
            vbs.WaitForExit();
            string os = vbs.StandardOutput.ReadToEnd();
            this.txtVbsReturn.Text = os;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHttpPost_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Http data posted waiting....";

            WebRequest wr = WebRequest.Create("http://....com");
            
            
            
        }
    }
}
