using AppBanHang.Models;
using AppBanHang.Views;

namespace AppBanHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        static AccountModel account;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account = new AccountModel() { Account = "admin", Password = "doanhhoang"};
            if(txtPassword.Text == account.Password && txtAccount.Text == account.Account)
            {
               FormMain formHome = new FormMain();
                formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
