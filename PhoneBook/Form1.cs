using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			grdObject.Visible = false;
			btnUpdate.Enabled = false;
		}
		PhoneDbDataContext dbDataContext = new PhoneDbDataContext();

		private void TxtAra_TextChanged(object sender, EventArgs e)
		{
			//grdObject.DataSource = dbDataContext.Phones
			//									.Where(f => f.Customer.Name.Contains(txtAra.Text) || f.Customer.Surname.Contains(txtAra.Text)&&f.IsPrimary==true)
			//									.ToList();

			var filter = (from q in dbDataContext.Phones
						  //.Where(f => f.Customer.Name.Contains(txtAra.Text) || f.Customer.Surname.Contains(txtAra.Text)&& f.IsPrimary==true)
						  .Where(f => f.Customer.Name.Contains(txtAra.Text) && f.IsPrimary == true)
						  select new
						  {
							   KisiAdi = q.Customer.Name,
							   KisiSoyadi = q.Customer.Surname,
							   TelefonNO = q.PhoneNumber,
							   TelefonTag = q.PhoneTag,
							   TlPrimsary=q.IsPrimary
						  }).ToList();
			grdObject.DataSource = filter;
		}
		
		private void GetAllPhone_Click(object sender, EventArgs e)
		{
			var phones = (from p in dbDataContext.Phones
						  select p).ToList();
			grdObject.DataSource = phones;
			grdObject.Visible = true;
		}

		private void GetAllCustomer_Click(object sender, EventArgs e)
		{
			grdObject.Visible = true;
			//grdObject.Refresh();
			var customers = (from c in dbDataContext.Customers
							 select c).ToList();

			grdObject.DataSource = customers;
			grdObject.Visible = true;
		}

		private void GetAllPhoneCustomer_Click(object sender, EventArgs e)
		{
			var all = (from q in dbDataContext.Phones
							select new
							{
								KisiId=q.CustomerId,
								KisiAdi = q.Customer.Name,
								KisiSoyadi = q.Customer.Surname,
								TelefonNO = q.PhoneNumber,
								TelefonTag = q.PhoneTag,
								TelPrimary = q.IsPrimary
							}).ToList();
			grdObject.DataSource = all;
			//for (int i = 0; i < all.Count; i++)
			//{
			//	Console.Write("'{0}'    ", all[i]);
			//}
		}
		
		private void AddCustomer_Click(object sender, EventArgs e)
		{
			PhoneDbDataContext dbDataContext = new PhoneDbDataContext();
			grdObject.Refresh();
			Customer customer = new Customer();
			customer.Name = txtAd.Text;
			customer.Surname = txtSoyad.Text;
			dbDataContext.Customers.InsertOnSubmit(customer);
			dbDataContext.SubmitChanges();
			grdObject.DataSource = dbDataContext.Customers;
			
		}
		int updatedId = 0;
		private void DuzenleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnUpdate.Enabled = true;
			updatedId = Convert.ToInt32(grdObject.CurrentRow.Cells[0].Value);
			txtUpdated.Text = grdObject.CurrentRow.Cells[1].Value.ToString();
			txtUpdateSurname.Text = grdObject.CurrentRow.Cells[2].Value.ToString();
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			btnUpdate.Enabled = false;
			var updatedCustomer = dbDataContext.Customers.FirstOrDefault(q => q.CustomerId == updatedId);
			if (updatedCustomer == null) return;
			updatedCustomer.Name = txtUpdated.Text;
			updatedCustomer.Surname = txtUpdateSurname.Text;
			dbDataContext.SubmitChanges();
			grdObject.Refresh();
		}



		private void SilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			grdObject.Refresh();
			var deletedId = Convert.ToInt32(grdObject.CurrentRow.Cells[0].Value);

			var deletedCategory = dbDataContext.Customers.First(q => q.CustomerId == deletedId);
			
			DialogResult result = MessageBox
				  .Show($"{deletedCategory.Name} kişisini silmek istediğinizden emin misiniz?",
						 "Silmek üzeresiniz!",
						 MessageBoxButtons.YesNo,
						 MessageBoxIcon.Question);
			if (deletedCategory == null) return;

			if (result == DialogResult.Yes)
			{
				dbDataContext.Customers.DeleteOnSubmit(deletedCategory);
				dbDataContext.SubmitChanges();
				grdObject.Refresh();
			}
			
			MessageBox.Show($"{deletedCategory.Name} kişisi silindi!",
				"Bilgi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			
			//if (deletedCategory.)
			//{
			//	silToolStripMenuItem.Enabled = false;
			//}
			
		}

		private void txtPhonePrimary_TextChanged(object sender, EventArgs e)
		{
			//grdObject.DataSource = dbDataContext.Phones
			//									.Where(f => f.IsPrimary)
			//									.ToList();
		}
		public object SelectedItem { get; set; }
		private void BtnSavePhone_Click(object sender, EventArgs e)
		{
			
			PhoneDbDataContext dbDataContext = new PhoneDbDataContext();
			grdObject.Refresh();
			Phone phone = new Phone();
			Customer customer = new Customer();

			customer.CustomerId =Convert.ToInt32((txtKisiId.Text));
			phone.PhoneNumber = txtPhoneNumber.Text;
			phone.PhoneTag = txtPhoneTag.Text;
			string[] itemValues = new string[] {"Primary", "Second", "Third"};
			foreach (string value in itemValues)
				ChImportantPhone.Properties.Items.Add(value, CheckState.Unchecked, true);
			ChImportantPhone.SetEditValue("1");
			// Disable the Circle item.
			ChImportantPhone.Properties.Items["1"].Enabled = false;


			dbDataContext.Customers.InsertOnSubmit(customer);
			dbDataContext.SubmitChanges();
			grdObject.DataSource = dbDataContext.Customers;
		}

		private void BtnNext_Click(object sender, EventArgs e)
		{

		}

		private void groupControl1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
