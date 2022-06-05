using InstagramApiSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram.Foms
{
    public partial class frmGetFollowers : Form
    {
        public string UserName { get; set; }
        public frmGetFollowers()
        {
            InitializeComponent();
        }

        private void btnAddToLost_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Add(txtUsername.Text);
        }

        private async void btnLoadFollowings_Click(object sender, EventArgs e)
        {
            dgvPages.Rows.Clear();
            var followings = await ctx.api.UserProcessor.GetUserFollowingAsync(txtUsername.Text, PaginationParameters.Empty);
            // followings.Value.Reverse();
            int num = 1;
            foreach (var item in followings.Value)
            {
                dgvPages.Rows.Add(num, item.UserName, item.FullName);
                num++;
            }
        }

        private async void btnLoadFollowers_Click(object sender, EventArgs e)
        {
            dgvPages.Rows.Clear();
            var followers = await ctx.api.UserProcessor.GetUserFollowersAsync(txtUsername.Text, PaginationParameters.Empty);
            int num = 1;
            foreach (var item in followers.Value)
            {
                dgvPages.Rows.Add(num, item.UserName, item.FullName);
                num++;
            }
        }

        private void dgvPages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dgvPages.CurrentRow.Cells[1].Value.ToString();
            dgvList.Rows.Add(username);
        }

        private void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow != null)
            {
                int index = dgvList.CurrentRow.Index;
                dgvList.Rows.RemoveAt(index);
            }
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            int await = int.Parse(txtMsTimer.Text);
            awaitt = await;
        }

        private int awaitt = 20000;
        private Task Patience()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(awaitt);
            });
        }

        private async void btnStartOrStop_Click(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                timer1.Enabled = true;
            }
            if (rbNo.Checked)
            {
                timer1.Enabled = false;
            }

            foreach (var item in dgvList.Rows)
            {

                 // استفاده از لیست باکس به جای دیتا گرید

                    var user = await ctx.api.UserProcessor.GetUserAsync(item.ToString());
                    if (user.Succeeded)
                    {
                        var follow = await ctx.api.UserProcessor.FollowUserAsync(user.Value.Pk);
                        if (follow.Succeeded)
                        {
                            dgvFollowings.Rows.Add(user.Value.UserName);
                            dgvList.Rows.RemoveAt(0);
                            await Patience();
                        }
                    }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            List<string> followings = new List<string>();
            foreach (var item in dgvFollowings.Rows)
            {
                var user = await ctx.api.UserProcessor.GetUserAsync(item.ToString());
                if (user.Succeeded)
                {
                    var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
                    if (unfollow.Succeeded)
                    {
                        dgvList.Rows.RemoveAt(0);
                        await Patience();
                    }
                }
            }
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            var followers = await ctx.api.UserProcessor.GetUserFollowersAsync(UserName, PaginationParameters.Empty);
            int count = 1;
            if (followers.Succeeded)
            {
                foreach (var item in followers.Value)
                {
                    dgvFollowers.Rows.Add(count, item.UserName);
                    count++;
                }
            }
        }

        private async void btnFollow_Click(object sender, EventArgs e)
        {
            if (dgvFollowers.CurrentRow != null)
            {
                string username = dgvFollowers.CurrentRow.Cells[1].Value.ToString();
                var user = await ctx.api.UserProcessor.GetUserAsync(username);
                if (user.Succeeded)
                {
                    var follow = await ctx.api.UserProcessor.FollowUserAsync(user.Value.Pk);
                    if (follow.Succeeded)
                    {
                        dgvFollowings.Rows.Add(username);
                    }
                }
            }
        }

        private async void btnUnFollow_Click(object sender, EventArgs e)
        {
            if (dgvFollowings.CurrentRow != null)
            {
                string username = dgvFollowings.CurrentRow.Cells[1].Value.ToString();
                var user = await ctx.api.UserProcessor.GetUserAsync(username);
                if (user.Succeeded)
                {
                    var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
                    if (unfollow.Succeeded)
                    {
                        int index = dgvFollowings.CurrentRow.Index;
                        dgvFollowings.Rows.RemoveAt(index);
                    }
                }
            }
        }
    }
}
