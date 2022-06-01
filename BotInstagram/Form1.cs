using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class frmMain : Form
    {
        // In The Name Of God

        private static UserSessionData user;
        private static IInstaApi api;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Default
            txtUsername.Text = "Khoderoyawwa";
            txtPassword.Text = "test12";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            user = new UserSessionData
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };

            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay
                .FromSeconds(0, 1)).Build();

            var loginRequest = await api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                gbLogin.Enabled = false;
                gbCommand.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Login Failed ! \n" + loginRequest.Info.Message);
            }

        }
    }
}
