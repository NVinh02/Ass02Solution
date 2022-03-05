using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public Member user { get; set; }
        public IMemberRepository memberRepository { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            if (email.Equals(config["DefaultAccount:Email"]) && password.Equals(config["DefaultAccount:password"]))
            {
                user = new Member
                {
                    MemberId = 0,
                    Email = email,
                    CompanyName = "FPT",
                    City = "Ho Chi Minh",
                    Country ="Vietnam",
                    Password = password
                };
            } else
            {
                user = memberRepository.CheckLogin(email, password);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
