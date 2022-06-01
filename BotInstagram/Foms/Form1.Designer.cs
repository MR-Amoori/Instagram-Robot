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
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.gbFollowers = new System.Windows.Forms.GroupBox();
            this.btnLoadFollowers = new System.Windows.Forms.Button();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFollowings = new System.Windows.Forms.GroupBox();
            this.dgvFollowings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadListFollowings = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbImageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.gbFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.gbFollowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).BeginInit();
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
            this.gbCommand.Location = new System.Drawing.Point(218, 12);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(754, 144);
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
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(6, 20);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(188, 187);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
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
            // dgvFollowers
            // 
            this.dgvFollowers.AllowUserToAddRows = false;
            this.dgvFollowers.AllowUserToDeleteRows = false;
            this.dgvFollowers.AllowUserToOrderColumns = true;
            this.dgvFollowers.AllowUserToResizeRows = false;
            this.dgvFollowers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Fullname});
            this.dgvFollowers.Location = new System.Drawing.Point(6, 45);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.ReadOnly = true;
            this.dgvFollowers.RowHeadersVisible = false;
            this.dgvFollowers.Size = new System.Drawing.Size(251, 476);
            this.dgvFollowers.TabIndex = 2;
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
            this.gbFollowings.Text = "Followers : ";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvFollowings.Location = new System.Drawing.Point(6, 45);
            this.dgvFollowings.Name = "dgvFollowings";
            this.dgvFollowings.ReadOnly = true;
            this.dgvFollowings.RowHeadersVisible = false;
            this.dgvFollowings.Size = new System.Drawing.Size(251, 476);
            this.dgvFollowings.TabIndex = 2;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 729);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.GroupBox gbFollowings;
        private System.Windows.Forms.DataGridView dgvFollowings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnLoadListFollowings;
    }
}

