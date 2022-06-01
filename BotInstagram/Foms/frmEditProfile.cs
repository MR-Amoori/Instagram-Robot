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
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        private async void frmEditProfile_Load(object sender, EventArgs e)
        {
            var editProfile = await ctx.api.AccountProcessor.GetRequestForEditProfileAsync();
            if (editProfile.Succeeded)
            {
                txtName.Text = editProfile.Value.FullName;
                txtUsername.Text = editProfile.Value.Username;
                txtEmail.Text = editProfile.Value.Email;
                txtMobile.Text = editProfile.Value.PhoneNumber;
                txtWebSite.Text = editProfile.Value.ExternalUrl;
                txtBio.Text = editProfile.Value.Biography;
                if (editProfile.Value.Gender == InstagramApiSharp.Enums.InstaGenderType.Male)
                {
                    rbMale.Checked = true;
                }
                else if (editProfile.Value.Gender == InstagramApiSharp.Enums.InstaGenderType.Female)
                {
                    rbFemale.Checked = true;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var edit = await ctx.api.AccountProcessor
                .EditProfileAsync(txtName.Text, txtBio.Text,
                txtWebSite.Text, txtEmail.Text, txtMobile.Text,
                (rbMale.Checked) ? InstagramApiSharp.Enums.InstaGenderType.Male : InstagramApiSharp.Enums.InstaGenderType.Female ,
                txtUsername.Text);
          
            if (edit.Succeeded)
            {
                MessageBox.Show("Succeeded !" ,"Good",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
