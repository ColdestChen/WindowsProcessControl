using System;
using System.Windows.Forms;


namespace WindowsProcessControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        WindowsProcessControl myProcess = new WindowsProcessControl();
        string[] ps;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                myProcess.StartProcess(tbName.Text);
                btnRenew.PerformClick();
                //btnClear.PerformClick();
                int n;
                string s;
                for (int i = 0; i < ps.Length; i++)
                {
                    n = ps[i].LastIndexOf("@");
                    s=ps[i].Substring(0,n);
                    if (s == tbName.Text)
                    {
                        listBox1.SelectedIndex = i;
                        break;
                    }
                }
                

            }
                
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                myProcess.CloseProcess(tbName.Text);
                //btnRenew.PerformClick();
                btnClear.PerformClick();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
                lbState.Text = "" + myProcess.IsProcessExist(tbName.Text);
            if(tbId.Text == "")
            {
                if (myProcess.getIdByName(tbName.Text) != -1)
                    tbId.Text = "" + myProcess.getIdByName(tbName.Text);
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbId.Text != "")
            {
                myProcess.KillProcess(tbName.Text, int.Parse(tbId.Text));
                //btnRenew.PerformClick();
                btnClear.PerformClick();
            } 
        }

        

        
        
        //Set Textbox input Number only
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            /*
             * Source 
             * http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
             * 
             * */
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ps = myProcess.getAllProcess();
            int n;
            string s;
             
            foreach (string p in ps)
            {
                n = p.LastIndexOf("@");
                s = p.Substring(0, n) + " (ID:" + p.Substring(n + 1, p.Length - n - 1) + ")";
                listBox1.Items.Add(s);
            }

        }        

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbId.Text = "";
            lbState.Text = "N/A";
            btnRenew.PerformClick();
        }

        //listBox 選擇切換
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s;
            int n;
            s = listBox1.Text;
            if (s != "")
            {
                n = s.LastIndexOf(" (ID:");
                tbName.Text = s.Substring(0, n);
                tbId.Text = s.Substring(n + 5, s.Length - n - 6);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRenew.PerformClick();
        }

        
    }
}
