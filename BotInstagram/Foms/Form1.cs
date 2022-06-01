using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
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

namespace BotInstagram
{
    public partial class frmMain : Form
    {
        // In The Name Of God

        private static UserSessionData user;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Default
            txtUsername.Text = "test_courses_bar";
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

            ctx.api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay
                .FromSeconds(0, 1)).Build();

            var loginRequest = await ctx.api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                gbLogin.Enabled = false;
                gbCommand.Enabled = true;
                gbImageProfile.Enabled = true;
                pcImage.Load(ctx.api.GetLoggedUser().LoggedInUser.ProfilePicUrl);
                gbFollowers.Enabled = true;
                gbFollowings.Enabled = true;
                gbFollowAndUnFollow.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Login Failed ! \n" + loginRequest.Info.Message);
            }

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            (new Foms.frmEditProfile()).ShowDialog();
        }

        private async void btnRemoveImage_Click(object sender, EventArgs e)
        {
            var result = await ctx.api.AccountProcessor.RemoveProfilePictureAsync();
            if (result.Succeeded)
            {
                pcImage.Image = null;
            }
        }

        private async void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                var picByte = File.ReadAllBytes(op.FileName);
                var result = await ctx.api.AccountProcessor.ChangeProfilePictureAsync(picByte);
                if (result.Succeeded)
                {
                    pcImage.ImageLocation = op.FileName;
                }
            }
        }

        private async void btnLoadFollowers_Click(object sender, EventArgs e)
        {
            dgvFollowers.Rows.Clear();
            var followers = await ctx.api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.Empty);
            int count = 1;
            foreach (var item in followers.Value)
            {
                dgvFollowers.Rows.Add(count, item.UserName, item.FullName);
                count++;
            }
        }

        private async void btnLoadListFollowings_Click(object sender, EventArgs e)
        {
            dgvFollowings.Rows.Clear();
            // string username = ctx.api.GetLoggedUser().UserName;
            var username = await ctx.api.UserProcessor.GetCurrentUserAsync();
            var followings = await ctx.api.UserProcessor.GetUserFollowingAsync(username.Value.UserName, PaginationParameters.Empty);
            int count = 1;
            foreach (var item in followings.Value)
            {
                dgvFollowings.Rows.Add(count, item.UserName, item.FullName);
                count++;
            }
        }

        private async void btnFollows_Click(object sender, EventArgs e)
        {
            try
            {
                var follow = await ctx.api.UserProcessor.GetUserAsync(txtUsernameForFollowAndUnFollow.Text);
                var result = await ctx.api.UserProcessor.FollowUserAsync(follow.Value.Pk);
                if (result.Succeeded)
                {
                    MessageBox.Show("Follow !");
                    btnLoadListFollowings.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed ! \n" + result.Info.Message);
                }
            }
            catch
            {
                MessageBox.Show("Failed !");
            }

        }

        private async void btnUnfollows_Click(object sender, EventArgs e)
        {
            try
            {
                var follow = await ctx.api.UserProcessor.GetUserAsync(txtUsernameForFollowAndUnFollow.Text);
                var result = await ctx.api.UserProcessor.UnFollowUserAsync(follow.Value.Pk);
                if (result.Succeeded)
                {
                    MessageBox.Show("Un Follow !");
                    btnLoadListFollowings.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed ! \n" + result.Info.Message);
                }
            }
            catch
            {
                MessageBox.Show("Failed !");
            }
        }

        private async void btnStartProcessUnfollow_Click(object sender, EventArgs e)
        {
            btnStartProcessUnfollow.Enabled = false;
            var followings = await ctx.api.UserProcessor.GetUserFollowingAsync(txtUsername.Text, PaginationParameters.Empty);
            foreach (var item in followings.Value)
            {
                var followingsUser = await ctx.api.UserProcessor.GetUserFollowingAsync(item.UserName, PaginationParameters.MaxPagesToLoad(10));
                if (followingsUser.Succeeded)
                {
                    if (followingsUser.Value.Any(f => f.UserName.Contains(txtUsername.Text)))
                    {
                        continue;
                    }
                    else
                    {
                        var user = await ctx.api.UserProcessor.GetUserAsync(item.UserName);
                        var res = ctx.api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
                    }
                }
                await Patience();
            }
        }

        private Task Patience()
        {
            int await = Convert.ToInt32(txtAwait.Text);
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(await);
            });
        }

        private void txtAwait_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }


        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    var username = await ctx.api.UserProcessor.GetCurrentUserAsync();
        //    var followings = await ctx.api.UserProcessor.GetUserFollowingAsync("mr__amoori", PaginationParameters.Empty);
        //    List<string> ls = new List<string>();
        //    foreach (var item in followings.Value)
        //    {
        //        ls.Add(item.UserName);
        //    }
        //    if (ls.Any(c => c.Contains(username.Value.UserName)))
        //    {
        //        MessageBox.Show("Ok");
        //    }
        //    else
        //    {
        //        MessageBox.Show("No");
        //        var result = await ctx.api.UserProcessor.GetUserAsync("mr__amoori");
        //        var res = ctx.api.UserProcessor.UnFollowUserAsync(result.Value.Pk);
        //    }
        //}

    }
}
