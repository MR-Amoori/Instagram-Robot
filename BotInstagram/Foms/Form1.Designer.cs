namespace BotInstagram
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.gbImageProfile = new System.Windows.Forms.GroupBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.gbFollowers = new System.Windows.Forms.GroupBox();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.btnLoadFollowers = new System.Windows.Forms.Button();
            this.gbFollowings = new System.Windows.Forms.GroupBox();
            this.dgvFollowings = new System.Windows.Forms.DataGridView();
            this.btnLoadListFollowings = new System.Windows.Forms.Button();
            this.gbFollowAndUnFollow = new System.Windows.Forms.GroupBox();
            this.txtUsernameForFollowAndUnFollow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnfollows = new System.Windows.Forms.Button();
            this.btnFollows = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartProcessUnfollow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAwait = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numberw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbImageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.gbFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.gbFollowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).BeginInit();
            this.gbFollowAndUnFollow.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(191, 144);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Account : ";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(6, 113);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username or Email :";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnEditProfile);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(552, 12);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(420, 144);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Commands : ";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(6, 20);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(97, 23);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // gbImageProfile
            // 
            this.gbImageProfile.Controls.Add(this.btnChangeImage);
            this.gbImageProfile.Controls.Add(this.btnRemoveImage);
            this.gbImageProfile.Controls.Add(this.pcImage);
            this.gbImageProfile.Enabled = false;
            this.gbImageProfile.Location = new System.Drawing.Point(772, 162);
            this.gbImageProfile.Name = "gbImageProfile";
            this.gbImageProfile.Size = new System.Drawing.Size(200, 245);
            this.gbImageProfile.TabIndex = 2;
            this.gbImageProfile.TabStop = false;
            this.gbImageProfile.Text = "Image Profile : ";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(6, 213);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(91, 23);
            this.btnChangeImage.TabIndex = 1;
            this.btnChangeImage.Text = "Change";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(103, 213);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveImage.TabIndex = 1;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(6, 20);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(188, 187);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // gbFollowers
            // 
            this.gbFollowers.Controls.Add(this.dgvFollowers);
            this.gbFollowers.Controls.Add(this.btnLoadFollowers);
            this.gbFollowers.Enabled = false;
            this.gbFollowers.Location = new System.Drawing.Point(12, 162);
            this.gbFollowers.Name = "gbFollowers";
            this.gbFollowers.Size = new System.Drawing.Size(264, 527);
            this.gbFollowers.TabIndex = 3;
            this.gbFollowers.TabStop = false;
            this.gbFollowers.Text = "Followers : ";
            // 
            // dgvFollowers
            // 
            this.dgvFollowers.AllowUserToAddRows = false;
            this.dgvFollowers.AllowUserToDeleteRows = false;
            this.dgvFollowers.AllowUserToOrderColumns = true;
            this.dgvFollowers.AllowUserToResizeRows = false;
            this.dgvFollowers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Username,
            this.Fullname});
            this.dgvFollowers.Location = new System.Drawing.Point(6, 45);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.ReadOnly = true;
            this.dgvFollowers.RowHeadersVisible = false;
            this.dgvFollowers.Size = new System.Drawing.Size(251, 476);
            this.dgvFollowers.TabIndex = 2;
            // 
            // btnLoadFollowers
            // 
            this.btnLoadFollowers.Location = new System.Drawing.Point(6, 16);
            this.btnLoadFollowers.Name = "btnLoadFollowers";
            this.btnLoadFollowers.Size = new System.Drawing.Size(251, 23);
            this.btnLoadFollowers.TabIndex = 1;
            this.btnLoadFollowers.Text = "Load List Followers";
            this.btnLoadFollowers.UseVisualStyleBackColor = true;
            this.btnLoadFollowers.Click += new System.EventHandler(this.btnLoadFollowers_Click);
            // 
            // gbFollowings
            // 
            this.gbFollowings.Controls.Add(this.dgvFollowings);
            this.gbFollowings.Controls.Add(this.btnLoadListFollowings);
            this.gbFollowings.Enabled = false;
            this.gbFollowings.Location = new System.Drawing.Point(282, 162);
            this.gbFollowings.Name = "gbFollowings";
            this.gbFollowings.Size = new System.Drawing.Size(264, 527);
            this.gbFollowings.TabIndex = 3;
            this.gbFollowings.TabStop = false;
            this.gbFollowings.Text = "Followings : ";
            // 
            // dgvFollowings
            // 
            this.dgvFollowings.AllowUserToAddRows = false;
            this.dgvFollowings.AllowUserToDeleteRows = false;
            this.dgvFollowings.AllowUserToOrderColumns = true;
            this.dgvFollowings.AllowUserToResizeRows = false;
            this.dgvFollowings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFollowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numberw,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvFollowings.Location = new System.Drawing.Point(6, 45);
            this.dgvFollowings.Name = "dgvFollowings";
            this.dgvFollowings.ReadOnly = true;
            this.dgvFollowings.RowHeadersVisible = false;
            this.dgvFollowings.Size = new System.Drawing.Size(251, 476);
            this.dgvFollowings.TabIndex = 2;
            // 
            // btnLoadListFollowings
            // 
            this.btnLoadListFollowings.Location = new System.Drawing.Point(6, 16);
            this.btnLoadListFollowings.Name = "btnLoadListFollowings";
            this.btnLoadListFollowings.Size = new System.Drawing.Size(251, 23);
            this.btnLoadListFollowings.TabIndex = 1;
            this.btnLoadListFollowings.Text = "Load List Followings";
            this.btnLoadListFollowings.UseVisualStyleBackColor = true;
            this.btnLoadListFollowings.Click += new System.EventHandler(this.btnLoadListFollowings_Click);
            // 
            // gbFollowAndUnFollow
            // 
            this.gbFollowAndUnFollow.Controls.Add(this.label6);
            this.gbFollowAndUnFollow.Controls.Add(this.label5);
            this.gbFollowAndUnFollow.Controls.Add(this.btnStartProcessUnfollow);
            this.gbFollowAndUnFollow.Controls.Add(this.label4);
            this.gbFollowAndUnFollow.Controls.Add(this.btnFollows);
            this.gbFollowAndUnFollow.Controls.Add(this.btnUnfollows);
            this.gbFollowAndUnFollow.Controls.Add(this.txtAwait);
            this.gbFollowAndUnFollow.Controls.Add(this.txtUsernameForFollowAndUnFollow);
            this.gbFollowAndUnFollow.Controls.Add(this.label3);
            this.gbFollowAndUnFollow.Enabled = false;
            this.gbFollowAndUnFollow.Location = new System.Drawing.Point(209, 12);
            this.gbFollowAndUnFollow.Name = "gbFollowAndUnFollow";
            this.gbFollowAndUnFollow.Size = new System.Drawing.Size(337, 144);
            this.gbFollowAndUnFollow.TabIndex = 4;
            this.gbFollowAndUnFollow.TabStop = false;
            this.gbFollowAndUnFollow.Text = "Follow / Un Follow : ";
            // 
            // txtUsernameForFollowAndUnFollow
            // 
            this.txtUsernameForFollowAndUnFollow.Location = new System.Drawing.Point(73, 22);
            this.txtUsernameForFollowAndUnFollow.Name = "txtUsernameForFollowAndUnFollow";
            this.txtUsernameForFollowAndUnFollow.Size = new System.Drawing.Size(258, 21);
            this.txtUsernameForFollowAndUnFollow.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username :";
            // 
            // btnUnfollows
            // 
            this.btnUnfollows.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUnfollows.Location = new System.Drawing.Point(208, 49);
            this.btnUnfollows.Name = "btnUnfollows";
            this.btnUnfollows.Size = new System.Drawing.Size(123, 23);
            this.btnUnfollows.TabIndex = 1;
            this.btnUnfollows.Text = "Un Follow";
            this.btnUnfollows.UseVisualStyleBackColor = true;
            this.btnUnfollows.Click += new System.EventHandler(this.btnUnfollows_Click);
            // 
            // btnFollows
            // 
            this.btnFollows.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFollows.Location = new System.Drawing.Point(73, 49);
            this.btnFollows.Name = "btnFollows";
            this.btnFollows.Size = new System.Drawing.Size(129, 23);
            this.btnFollows.TabIndex = 1;
            this.btnFollows.Text = "Follow";
            this.btnFollows.UseVisualStyleBackColor = true;
            this.btnFollows.Click += new System.EventHandler(this.btnFollows_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "_________________________________________________________";
            // 
            // btnStartProcessUnfollow
            // 
            this.btnStartProcessUnfollow.Location = new System.Drawing.Point(9, 113);
            this.btnStartProcessUnfollow.Name = "btnStartProcessUnfollow";
            this.btnStartProcessUnfollow.Size = new System.Drawing.Size(322, 23);
            this.btnStartProcessUnfollow.TabIndex = 3;
            this.btnStartProcessUnfollow.Text = "Start Process";
            this.btnStartProcessUnfollow.UseVisualStyleBackColor = true;
            this.btnStartProcessUnfollow.Click += new System.EventHandler(this.btnStartProcessUnfollow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unfollow those who have not followed . . . ";
            // 
            // txtAwait
            // 
            this.txtAwait.Location = new System.Drawing.Point(232, 93);
            this.txtAwait.Multiline = true;
            this.txtAwait.Name = "txtAwait";
            this.txtAwait.Size = new System.Drawing.Size(71, 17);
            this.txtAwait.TabIndex = 0;
            this.txtAwait.Text = "20000";
            this.txtAwait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAwait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAwait_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ms";
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Number.HeaderText = "*";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 5;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.HeaderText = "UserName";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 81;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.HeaderText = "Full Name";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Numberw
            // 
            this.Numberw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Numberw.HeaderText = "*";
            this.Numberw.Name = "Numberw";
            this.Numberw.ReadOnly = true;
            this.Numberw.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 729);
            this.Controls.Add(this.gbFollowAndUnFollow);
            this.Controls.Add(this.gbFollowings);
            this.Controls.Add(this.gbFollowers);
            this.Controls.Add(this.gbImageProfile);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Robot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbImageProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.gbFollowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).EndInit();
            this.gbFollowings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).EndInit();
            this.gbFollowAndUnFollow.ResumeLayout(false);
            this.gbFollowAndUnFollow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox gbImageProfile;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.GroupBox gbFollowers;
        private System.Windows.Forms.Button btnLoadFollowers;
        private System.Windows.Forms.DataGridView dgvFollowers;
        private System.Windows.Forms.GroupBox gbFollowings;
        private System.Windows.Forms.DataGridView dgvFollowings;
        private System.Windows.Forms.Button btnLoadListFollowings;
        private System.Windows.Forms.GroupBox gbFollowAndUnFollow;
        private System.Windows.Forms.Button btnFollows;
        private System.Windows.Forms.Button btnUnfollows;
        private System.Windows.Forms.TextBox txtUsernameForFollowAndUnFollow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartProcessUnfollow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAwait;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numberw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

