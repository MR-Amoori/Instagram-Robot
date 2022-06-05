using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
                gbBlocks.Enabled = true;
                btnLogout.Enabled = true;
                gbDirect.Enabled = true;
                gbShowPostes.Enabled = true;
                gbStory.Enabled = true;
                gbPost.Enabled = true;
                gbSearchInPostes.Enabled = true;
                gbDownloadPost.Enabled = true;
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
            MessageBox.Show("Remove Profile ?", "Wrning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                var result = await ctx.api.AccountProcessor.RemoveProfilePictureAsync();
                if (result.Succeeded)
                {
                    pcImage.Image = null;
                }
            }
        }

        private async void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.png;*.gif";
            op.Title = "Select Image Profile";
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
                var followingsUser = await ctx.api.UserProcessor.GetUserFollowingAsync(item.UserName, PaginationParameters.Empty);
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
            btnStartProcessUnfollow.Enabled = true;
            MessageBox.Show("Finished Process Unfollow ...");
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

        private async void btnLoadBlockUsers_Click(object sender, EventArgs e)
        {
            dgvBlockUsers.Rows.Clear();
            var blocks = await ctx.api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.Empty);
            int count = 1;
            foreach (var item in blocks.Value.BlockedList)
            {
                dgvBlockUsers.Rows.Add(count, item.UserName, item.FullName);
                count++;
            }
        }

        private async void btnBlockOrUnBlock_Click(object sender, EventArgs e)
        {
            var blocks = await ctx.api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.Empty);
            if (blocks.Value.BlockedList.Any(b => b.UserName.Contains(txtUsernameForFollowAndUnFollow.Text)))
            {
                var user = await ctx.api.UserProcessor.GetUserAsync(txtUsernameForFollowAndUnFollow.Text);
                var block = ctx.api.UserProcessor.UnBlockUserAsync(user.Value.Pk);
                MessageBox.Show("UnBlock !");
                btnLoadBlockUsers.PerformClick();
            }
            else
            {
                var user = await ctx.api.UserProcessor.GetUserAsync(txtUsernameForFollowAndUnFollow.Text);
                var block = ctx.api.UserProcessor.BlockUserAsync(user.Value.Pk);
                MessageBox.Show("Block !");
                btnLoadBlockUsers.PerformClick();
            }
        }

        private void dgvBlockUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsernameForFollowAndUnFollow.Text = dgvBlockUsers.SelectedCells[0].Value.ToString();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            await ctx.api.LogoutAsync();
            gbLogin.Enabled = true;
            btnLogin.Enabled = false;
            gbCommand.Enabled = false;
            gbImageProfile.Enabled = false;
            pcImage.Image = null;
            gbFollowers.Enabled = false;
            gbFollowings.Enabled = false;
            gbFollowAndUnFollow.Enabled = false;
            gbBlocks.Enabled = false;
            btnLogout.Enabled = false;
            gbDirect.Enabled = false;
            btnLogin.Enabled = true;
            gbShowPostes.Enabled = false;
            gbStory.Enabled = false;
            gbPost.Enabled = false;
            gbSearchInPostes.Enabled = false;
            gbDownloadPost.Enabled = false;
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtDirect.Text);
            var direct = await ctx.api.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(), null, txtMessageDirect.Text);
            if (direct.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
        }

        private async void btnSendVideoDirect_Click(object sender, EventArgs e)
        {
            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
            var user = await ctx.api.UserProcessor.GetUserAsync(txtDirect.Text);
            var threadeId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == user.Value.FullName).ThreadId;

            OpenFileDialog op = new OpenFileDialog();

            var imageUp = new InstaImage()
            {
                Uri = op.FileName
            };

            if (op.ShowDialog() == DialogResult.OK)
            {
                var direct = await ctx.api.MessagingProcessor.SendDirectPhotoAsync(imageUp, threadeId);
                if (direct.Succeeded)
                {
                    MessageBox.Show("Sended ...");
                }
                else
                {
                    MessageBox.Show("Filed ... \n" + direct.Info.Message);
                }
            }
        }

        private async void btnSendPhotoDirect_Click(object sender, EventArgs e)
        {
            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
            var user = await ctx.api.UserProcessor.GetUserAsync(txtDirect.Text);
            var threadeId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == user.Value.FullName).ThreadId;

            OpenFileDialog op = new OpenFileDialog();

            var videoUp = new InstaVideo()
            {
                Uri = op.FileName
            };

            var videoUpload = new InstaVideoUpload()
            {
                Video = videoUp
            };

            if (op.ShowDialog() == DialogResult.OK)
            {
                var direct = await ctx.api.MessagingProcessor.SendDirectVideoAsync(videoUpload, threadeId);
                if (direct.Succeeded)
                {
                    MessageBox.Show("Sended ...");
                }
                else
                {
                    MessageBox.Show("Filed ... \n" + direct.Info.Message);
                }
            }
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            new Foms.frmActivity().ShowDialog();
        }

        private void btnShowPostes_Click(object sender, EventArgs e)
        {
            Foms.frmShowPost frm = new Foms.frmShowPost();
            frm.UserName = txtUsernamePostes.Text.Trim();
            frm.Id = 0;
            frm.ShowDialog();
        }

        private void dgvFollowings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsernameForFollowAndUnFollow.Text = dgvFollowings.SelectedCells[0].Value.ToString();
        }

        private void dgvFollowers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsernameForFollowAndUnFollow.Text = dgvFollowers.SelectedCells[0].Value.ToString();
        }

        private async void btnStosryPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.png;*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                var image = new InstaImage()
                {
                    Uri = op.FileName
                };
                var result = await ctx.api.StoryProcessor.UploadStoryPhotoAsync(image, txtCaptionStory.Text);
                if (result.Succeeded)
                {
                    MessageBox.Show("Story Sended ...");
                }
                else
                {
                    MessageBox.Show("No Sended Story !\n" + result.Info.Message);
                }
            }
        }

        private async void btnStosryVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select Video";
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Image For Thumbnail";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;

            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo() { Uri = videoUri, Height = 0, Width = 0 },
                VideoThumbnail = new InstaImage() { Uri = imageUri, Height = 0, Width = 0 }
            };

            var result = await ctx.api.StoryProcessor.UploadStoryVideoAsync(video, txtCaptionStory.Text);
            if (result.Succeeded)
            {
                MessageBox.Show("Story Sended ...");
            }
            else
            {
                MessageBox.Show("No Sended Story !\n" + result.Info.Message);
            }
        }

        private async void btnSendImagePost_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.png;*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                var uploadImage = new InstaImageUpload()
                {
                    Height = 1080,
                    Width = 1080,
                    Uri = op.FileName
                };

                double x = 0.5, y = 0.5;
                uploadImage.UserTags.Add(new InstaUserTagUpload() { Username = txtUsernameTag.Text, X = x, Y = y });

                var result = await ctx.api.MediaProcessor.UploadPhotoAsync(uploadImage, txtCaptionStory.Text);

                if (result.Succeeded)
                {
                    MessageBox.Show("Post Sended ...");
                }
                else
                {
                    MessageBox.Show("No Sended Post !\n" + result.Info.Message);
                }
            }
        }

        private void brnSearchTextInSearch_Click(object sender, EventArgs e)
        {
            Foms.frmShowPost frm = new Foms.frmShowPost();
            frm.UserName = txtUsernameForSearch.Text.Trim();
            frm.TextForSearch = txtTextForSearch.Text;
            frm.Id = 1;
            frm.ShowDialog();
        }

        private async void btnSendVideoPost_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select Video";
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Image For Thumbnail";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;

            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo() { Uri = videoUri, Height = 0, Width = 0 },
                VideoThumbnail = new InstaImage() { Uri = imageUri, Height = 0, Width = 0 },
            };

            double x = 0.5, y = 0.5;
            video.UserTags.Add(new InstaUserTagUpload() { Username = txtUsernameTag.Text, X = x, Y = y });

            var result = await ctx.api.MediaProcessor.UploadVideoAsync(video, txtCaptionPost.Text);

            if (result.Succeeded)
            {
                MessageBox.Show("Post Sended ...");
            }
            else
            {
                MessageBox.Show("No Sended Post !\n" + result.Info.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToString("H:m:ss");
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            Uri link = new Uri(txtLinkForDownload.Text);
            var media = await ctx.api.MediaProcessor.GetMediaIdFromUrlAsync(link);
            if (media.Succeeded)
            {
                var result = await ctx.api.MediaProcessor.GetMediaByIdAsync(media.Value);
                if (result.Value.MediaType == InstaMediaType.Video)
                {
                    string linkDownload = result.Value.Videos[result.Value.Videos.Count - 1].Uri.ToString();

                    string addres = @"C:\Program Files (x86)\Internet Download Manager\IDMan.exe";
                    string linkPost = linkDownload;
                    System.Diagnostics.Process.Start(addres, "-d " + linkPost);

                }
                else
                {
                    MessageBox.Show("No Video Post !");
                }
            }
            else
            {
                MessageBox.Show("Not Found !");
            }
        }

        private void btnGetFollower_Click(object sender, EventArgs e)
        {
            Foms.frmGetFollowers frm = new Foms.frmGetFollowers();
            frm.UserName = txtUsername.Text;
            frm.ShowDialog();
        }
    }
}
