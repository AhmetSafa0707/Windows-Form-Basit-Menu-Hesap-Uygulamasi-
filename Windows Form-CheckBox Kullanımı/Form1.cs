using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_CheckBox_Kullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_hesapla_Click(object sender, EventArgs e)
		{
			int tutar=0;

			if (checkbox_cay.Checked)
			{
				tutar += 2;
			}

			if (checkbox_su.Checked)
			{
				tutar += 1;
			}

			if(checkbox_hamburger.Checked)
			{
				tutar += 30;
			}

			if ((checkbox_pizza.Checked))
			{
				tutar += 50;
			}

			lbl_tutarsayisal.Text = (tutar.ToString()+" Lira");
		}

		
	}
}
