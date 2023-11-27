using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUpWithFade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {

            Form formBackground = new Form();
                try
                {
                    using (PopForm pf = new PopForm())
                    {
                        
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .50d;
                        formBackground.BackColor = Color.Black;
                    //  formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.WindowState = this.WindowState;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.Size = this.Size;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        pf.Owner = formBackground;
                    pf.StartPosition = FormStartPosition.CenterParent;
                        pf.ShowDialog();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            finally
            {
                formBackground.Dispose();
            }
            
            
            
               
        }
    }
}
