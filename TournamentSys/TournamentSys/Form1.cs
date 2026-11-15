using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentSys
{
    public partial class Form1 : Form
    {
        int q = 0;

        public Form1()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(2440, 1360);
            this.MinimumSize = new System.Drawing.Size(2440, 1360);
            this.MaximumSize = new System.Drawing.Size(2440, 1360);

            this.StartPosition = FormStartPosition.Manual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~ Reset Function ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void resetFunc(params System.Windows.Forms.GroupBox[] groupBoxes)
        {

            foreach(System.Windows.Forms.GroupBox groupBox in groupBoxes)
            {
                foreach(Control control in groupBox.Controls)
                {
                    if(control is System.Windows.Forms.ComboBox comboBox)
                    {
                        comboBox.Text = "";
                    }

                    if(control is System.Windows.Forms.Label label)
                    {
                        label.Text = "0";
                    }
                }
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~ Total Function ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void t1Total(object sender, EventArgs e)
        {
            q = Convert.ToInt32(lblT1P1.Text) + Convert.ToInt32(lblT1P2.Text) + Convert.ToInt32(lblT1P3.Text)
                + Convert.ToInt32(lblT1P4.Text) + Convert.ToInt32(lblT1P5.Text);
            lblT1Total.Text = Convert.ToString(q);
        }

        private void t2Total(object sender, EventArgs e)
        {
            q = Convert.ToInt32(lblT2P1.Text) + Convert.ToInt32(lblT2P2.Text) + Convert.ToInt32(lblT2P3.Text)
                + Convert.ToInt32(lblT2P4.Text) + Convert.ToInt32(lblT2P5.Text);
            lblT2Total.Text = Convert.ToString(q);
        }

        private void t3Total(object sender, EventArgs e)
        {
            q = Convert.ToInt32(lblT3P1.Text) + Convert.ToInt32(lblT3P2.Text) + Convert.ToInt32(lblT3P3.Text)
                + Convert.ToInt32(lblT3P4.Text) + Convert.ToInt32(lblT3P5.Text);
            lblT3Total.Text = Convert.ToString(q);
        }

        private void t4Total(object sender, EventArgs e)
        {
            q = Convert.ToInt32(lblT4P1.Text) + Convert.ToInt32(lblT4P2.Text) + Convert.ToInt32(lblT4P3.Text)
                + Convert.ToInt32(lblT4P4.Text) + Convert.ToInt32(lblT4P5.Text);
            lblT4Total.Text = Convert.ToString(q);
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~ Combobox Function ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] points = new int[3];
            {
                int.TryParse(txtPoint1.Text, out points[0]);
                int.TryParse(txtPoint2.Text, out points[1]);
                int.TryParse(txtPoint3.Text, out points[2]);
            }

            Dictionary<int, int> indexToPoint = new Dictionary<int, int>()
            {
                { 0, points[0] }, { 1, points[1] }, { 2, points[2] },
                { 3, points[0] }, { 4, points[1] }, { 5, points[2] },
                { 6, points[0] }, { 7, points[1] }, { 8, points[2] },
                { 9, points[0] }, { 10, points[1] }, { 11, points[2] },
                { 12, points[0] }, { 13, points[1] }, { 14, points[2] },
                { 15, points[2] }
            };

            ComboBox comboBox = sender as ComboBox;
            int outputValue = indexToPoint[comboBox.SelectedIndex];

            Dictionary<string, Label> comboBoxToLableMap = new Dictionary<string, Label>()
            {
                { "cboT1P1", lblT1P1 }, { "cboT1P2", lblT1P2 }, { "cboT1P3", lblT1P3 }, { "cboT1P4", lblT1P4 }, { "cboT1P5", lblT1P5 },
                { "cboT2P1", lblT2P1 }, { "cboT2P2", lblT2P2 }, { "cboT2P3", lblT2P3 }, { "cboT2P4", lblT2P4 }, { "cboT2P5", lblT2P5 },
                { "cboT3P1", lblT3P1 }, { "cboT3P2", lblT3P2 }, { "cboT3P3", lblT3P3 }, { "cboT3P4", lblT3P4 }, { "cboT3P5", lblT3P5 },
                { "cboT4P1", lblT4P1 }, { "cboT4P2", lblT4P2 }, { "cboT4P3", lblT4P3 }, { "cboT4P4", lblT4P4 }, { "cboT4P5", lblT4P5 },
            };

            if(comboBoxToLableMap.ContainsKey(comboBox.Name))
            {
                comboBoxToLableMap[comboBox.Name].Text = outputValue.ToString();
            }
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult iReset;

            iReset = MessageBox.Show("Confirm if you want to Reset", "Tournament System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iReset == DialogResult.Yes) {
                resetFunc(groupBox1, groupBox2, groupBox3, groupBox4);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to Exit", "Tournament System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                 Close();
            }
        }

        private void cboT1P1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t1Total(sender, e);
        }

        private void cboT1P2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t1Total(sender, e);
        }

        private void cboT1P3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t1Total(sender, e);
        }

        private void cboT1P4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t1Total(sender, e);
        }

        private void cboT1P5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t1Total(sender, e);
        }

        private void cboT2P1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t2Total(sender, e);
        }

        private void cboT2P2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t2Total(sender, e);
        }

        private void cboT2P3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t2Total(sender, e);
        }

        private void cboT2P4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t2Total(sender, e);
        }

        private void cboT2P5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t2Total(sender, e);
        }

        private void cboT3P1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t3Total(sender, e);
        }

        private void cboT3P2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t3Total(sender, e);
        }

        private void cboT3P3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t3Total(sender, e);
        }

        private void cboT3P4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t3Total(sender, e);
        }

        private void cboT3P5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t3Total(sender, e);
        }

        private void cboT4P1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t4Total(sender, e);
        }

        private void cboT4P2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t4Total(sender, e);
        }

        private void cboT4P3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t4Total(sender, e);
        }

        private void cboT4P4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t4Total(sender, e);
        }

        private void cboT4P5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SelectedIndexChanged(sender, e);
            t4Total(sender, e);
        }
    }
}
