using DataAccessObjects;
using Repositories.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmMember : Form
    {
        MemberDAO memberDAO = new MemberDAO();
        public frmMember()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            var list = memberDAO.GetAll()
                    .Select(p => new { p.MemberId, p.Email, p.CompanyName, p.City, p.Country }).ToList();
            dgvMemberList.DataSource = list;
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddMember.Enabled = true;
            btnUpdate.Enabled = false;

            var Id = dgvMemberList.Rows[e.RowIndex].Cells[0].Value;
            var obj = memberDAO.GetAll().Where(p => p.MemberId.Equals(Id)).FirstOrDefault();
            if (obj != null)
            {
                txtId.Text = obj.MemberId.ToString();
                txtEmail.Text = obj.Email;
                txtCompanyName.Text = obj.CompanyName.ToString();
                txtCity.Text = obj.City.ToString();
                txtCountry.Text = obj.Country;

            }
            btnAddMember.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var member = new Member();
            memberDAO = new MemberDAO();
            member.MemberId = int.Parse(txtId.Text);
            if (memberDAO.GetAll().Where(p => p.MemberId.Equals(member.MemberId)).FirstOrDefault() != null)
            {
                MessageBox.Show("MemberId Existed ", "hello", MessageBoxButtons.OK);
                return;
            }
            member.MemberId = int.Parse(txtId.Text);
            member.Email = txtEmail.Text;
            member.CompanyName = txtCompanyName.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            member.Password = "1";
            memberDAO.Create(member);
            MessageBox.Show("Member Added!");
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(txtId.Text);
            var obj = memberDAO.GetAll().Where(p => p.MemberId == Id).FirstOrDefault();
            memberDAO = new MemberDAO();
            if (obj != null)
            {
                var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    memberDAO.Delete(obj);
                }
                else
                {
                    return;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            memberDAO = new MemberDAO();
            var member = new Member();
            member.MemberId = int.Parse(txtId.Text);
            member.Email = txtEmail.Text;
            member.CompanyName = txtCompanyName.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            memberDAO.Update(member);

            var list = memberDAO.GetAll().Select(p => new { p.MemberId, p.Email, p.CompanyName, p.City }).ToList();
            dgvMemberList.DataSource = list;
        }

    }
}