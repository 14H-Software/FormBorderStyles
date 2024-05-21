using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBorderStyles
{
    public partial class Form1 : Form
    {
        FormBorderStyle frm { 
            get => this.FormBorderStyle;
            set => this.FormBorderStyle = value; 
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_forceMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_forceNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void cb_MaximizeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_MaximizeBtn.Checked == true)
            {
                this.MaximizeBox = true;
            }
            else
            {
                this.MaximizeBox = false;
            }
        }

        private void cb_MinimizeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MinimizeBtn.Checked == true)
            {
                this.MinimizeBox = true;
            }
            else
            {
                this.MinimizeBox = false;
            }
        }

        private void cb_ControlBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ControlBox.Checked == true)
            {
                this.ControlBox = true;
            }
            else
            {
                this.ControlBox = false;
            }
        }

        private void cb_ShowIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowIcon.Checked == true)
            {
                this.ShowIcon = true;
            }
            else
            {
                this.ShowIcon = false;
            }
        }

        private void cb_ShowInTaskbar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowInTaskbar.Checked == true)
            {
                this.ShowInTaskbar = true;
            }
            else
            {
                this.ShowInTaskbar = false;
            }
        }

        private void btn_ApplyBorder_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = frm;
        }

        private void rb_None_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_None.Checked == true)
            {
                frm = FormBorderStyle.None;
            }
        }

        private void rb_FixedSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_FixedSingle.Checked == true)
            {
                frm = FormBorderStyle.FixedSingle;
            }
        }

        private void rb_Fixed3D_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Fixed3D.Checked == true)
            {
                frm = FormBorderStyle.Fixed3D;
            }
        }

        private void rb_FixedDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_FixedDialog.Checked == true)
            {
                frm = FormBorderStyle.FixedDialog;
            }
        }

        private void rb_Sizable_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Sizable.Checked == true)
            {
                frm = FormBorderStyle.Sizable;
            }
        }

        private void rb_FixedTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_FixedTool.Checked == true)
            {
                frm = FormBorderStyle.FixedToolWindow;
            }
        }

        private void rb_SizableTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SizableTool.Checked == true)
            {
                frm = FormBorderStyle.SizableToolWindow;
            }
        }

        private void btn_EnableVisualStyles_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_VisualStyles_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_VisualStyles.Checked == true)
            {
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
            }
            else
            {
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            }
        }

        private void tmr_progress_Tick(object sender, EventArgs e)
        {
            if (pbar_demo.Value < pbar_demo.Maximum)
            {
                pbar_demo.Value += 4;
            }
            else
            {
                pbar_demo.Value = 0;
            }
            pbar_demo2.Value = pbar_demo.Value;
        }

        private void rb_Blocks_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Blocks.Checked == true)
            {
                pbar_demo.Style = ProgressBarStyle.Blocks;
            }
        }

        private void rb_Cont_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Cont.Checked == true)
            {
                pbar_demo.Style = ProgressBarStyle.Continuous;
            }
        }

        private void rb_Marq_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Marq.Checked == true)
            {
                pbar_demo.Style = ProgressBarStyle.Marquee;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormChild ChildForm = new FormChild();
            ChildForm.TopLevel = false;
            ChildForm.Parent = pan_container;
            ChildForm.Show();
            ChildForm.BringToFront();
        }
    }
}
