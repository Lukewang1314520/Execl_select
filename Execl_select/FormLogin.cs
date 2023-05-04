using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execl_select
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserName = textBoxUser.Text.Trim();
            var UserPwd = textBoxPwd.Text.Trim();
            DALL78 dALL78 = new DALL78();
            string SQL = $"select Pwd from UserID where UserName='{UserName}'";
            var result= dALL78.Read(SQL);
            if (result==UserPwd)
            {
                model model = new model();
                model.UserID = UserName;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }
    }
}
