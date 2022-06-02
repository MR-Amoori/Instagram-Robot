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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.gbImageProfile = new System.Windows.Forms.GroupBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.gbFollowers = new System.Windows.Forms.GroupBox();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadFollowers = new System.Windows.Forms.Button();
            this.gbFollowings = new System.Windows.Forms.GroupBox();
            this.dgvFollowings = new System.Windows.Forms.DataGridView();
            this.Numberw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadListFollowings = new System.Windows.Forms.Button();
            this.gbFollowAndUnFollow = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartProcessUnfollow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFollows = new System.Windows.Forms.Button();
            this.btnBlockOrUnBlock = new System.Windows.Forms.Button();
            this.btnUnfollows = new System.Windows.Forms.Button();
            this.txtAwait = new System.Windows.Forms.TextBox();
            this.txtUsernameForFollowAndUnFollow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBlocks = new System.Windows.Forms.GroupBox();
            this.dgvBlockUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadBlockUsers = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbDirect = new System.Windows.Forms.GroupBox();
            this.btnSendPhotoDirect = new System.Windows.Forms.Button();
            this.btnSendVideoDirect = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessageDirect = new System.Windows.Forms.TextBox();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbShowPostes = new System.Windows.Forms.GroupBox();
            this.btnShowPostes = new System.Windows.Forms.Button();
            this.txtUsernamePostes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbStory = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaptionStory = new System.Windows.Forms.TextBox();
            this.btnStosryPhoto = new System.Windows.Forms.Button();
            this.btnStosryVideo = new System.Windows.Forms.Button();
            this.gbPost = new System.Windows.Forms.GroupBox();
            this.txtCaptionPost = new System.Windows.Forms.TextBox();
            this.btnSendImagePost = new System.Windows.Forms.Button();
            this.btnSendVideoPost = new System.Windows.Forms.Button();
            this.txtUsernameTag = new System.Windows.Forms.TextBox();
            this.txtLocationPost = new System.Windows.Forms.TextBox();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbImageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.gbFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.gbFollowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).BeginInit();
            this.gbFollowAndUnFollow.SuspendLayout();
            this.gbBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockUsers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbDirect.SuspendLayout();
            this.gbShowPostes.SuspendLayout();
            this.gbStory.SuspendLayout();
            this.gbPost.SuspendLayout();
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
            this.gbCommand.Controls.Add(this.btnActivities);
            this.gbCommand.Controls.Add(this.btnEditProfile);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(758, 12);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(214, 144);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Commands : ";
            // 
            // btnActivities
            // 
            this.btnActivities.Location = new System.Drawing.Point(111, 20);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(97, 23);
            this.btnActivities.TabIndex = 1;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
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
            this.gbImageProfile.Location = new System.Drawing.Point(764, 162);
            this.gbImageProfile.Name = "gbImageProfile";
            this.gbImageProfile.Size = new System.Drawing.Size(208, 245);
            this.gbImageProfile.TabIndex = 2;
            this.gbImageProfile.TabStop = false;
            this.gbImageProfile.Text = "Image Profile : ";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(6, 213);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(99, 23);
            this.btnChangeImage.TabIndex = 1;
            this.btnChangeImage.Text = "Change";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(111, 213);
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
            this.pcImage.Size = new System.Drawing.Size(196, 187);
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
            this.dgvFollowers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFollowers_CellDoubleClick);
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
            this.dgvFollowings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFollowings_CellDoubleClick);
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
            this.gbFollowAndUnFollow.Controls.Add(this.btnBlockOrUnBlock);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ms";
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
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "_________________________________________________________";
            // 
            // btnFollows
            // 
            this.btnFollows.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFollows.Location = new System.Drawing.Point(111, 49);
            this.btnFollows.Name = "btnFollows";
            this.btnFollows.Size = new System.Drawing.Size(115, 23);
            this.btnFollows.TabIndex = 1;
            this.btnFollows.Text = "Follow";
            this.btnFollows.UseVisualStyleBackColor = true;
            this.btnFollows.Click += new System.EventHandler(this.btnFollows_Click);
            // 
            // btnBlockOrUnBlock
            // 
            this.btnBlockOrUnBlock.ForeColor = System.Drawing.Color.Black;
            this.btnBlockOrUnBlock.Location = new System.Drawing.Point(6, 48);
            this.btnBlockOrUnBlock.Name = "btnBlockOrUnBlock";
            this.btnBlockOrUnBlock.Size = new System.Drawing.Size(99, 23);
            this.btnBlockOrUnBlock.TabIndex = 1;
            this.btnBlockOrUnBlock.Text = "Block / Unblock";
            this.btnBlockOrUnBlock.UseVisualStyleBackColor = true;
            this.btnBlockOrUnBlock.Click += new System.EventHandler(this.btnBlockOrUnBlock_Click);
            // 
            // btnUnfollows
            // 
            this.btnUnfollows.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUnfollows.Location = new System.Drawing.Point(232, 49);
            this.btnUnfollows.Name = "btnUnfollows";
            this.btnUnfollows.Size = new System.Drawing.Size(99, 23);
            this.btnUnfollows.TabIndex = 1;
            this.btnUnfollows.Text = "Un Follow";
            this.btnUnfollows.UseVisualStyleBackColor = true;
            this.btnUnfollows.Click += new System.EventHandler(this.btnUnfollows_Click);
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
            // gbBlocks
            // 
            this.gbBlocks.Controls.Add(this.dgvBlockUsers);
            this.gbBlocks.Controls.Add(this.btnLoadBlockUsers);
            this.gbBlocks.Enabled = false;
            this.gbBlocks.Location = new System.Drawing.Point(552, 162);
            this.gbBlocks.Name = "gbBlocks";
            this.gbBlocks.Size = new System.Drawing.Size(206, 245);
            this.gbBlocks.TabIndex = 5;
            this.gbBlocks.TabStop = false;
            this.gbBlocks.Text = "Block List : ";
            // 
            // dgvBlockUsers
            // 
            this.dgvBlockUsers.AllowUserToAddRows = false;
            this.dgvBlockUsers.AllowUserToDeleteRows = false;
            this.dgvBlockUsers.AllowUserToOrderColumns = true;
            this.dgvBlockUsers.AllowUserToResizeRows = false;
            this.dgvBlockUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBlockUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlockUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvBlockUsers.Location = new System.Drawing.Point(6, 51);
            this.dgvBlockUsers.Name = "dgvBlockUsers";
            this.dgvBlockUsers.ReadOnly = true;
            this.dgvBlockUsers.RowHeadersVisible = false;
            this.dgvBlockUsers.Size = new System.Drawing.Size(194, 185);
            this.dgvBlockUsers.TabIndex = 2;
            this.dgvBlockUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlockUsers_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "*";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnLoadBlockUsers
            // 
            this.btnLoadBlockUsers.Location = new System.Drawing.Point(6, 20);
            this.btnLoadBlockUsers.Name = "btnLoadBlockUsers";
            this.btnLoadBlockUsers.Size = new System.Drawing.Size(194, 23);
            this.btnLoadBlockUsers.TabIndex = 1;
            this.btnLoadBlockUsers.Text = "Block Users";
            this.btnLoadBlockUsers.UseVisualStyleBackColor = true;
            this.btnLoadBlockUsers.Click += new System.EventHandler(this.btnLoadBlockUsers_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 704);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogout
            // 
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogout.Enabled = false;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 22);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gbDirect
            // 
            this.gbDirect.Controls.Add(this.btnSendPhotoDirect);
            this.gbDirect.Controls.Add(this.btnSendVideoDirect);
            this.gbDirect.Controls.Add(this.btnSendMessage);
            this.gbDirect.Controls.Add(this.txtMessageDirect);
            this.gbDirect.Controls.Add(this.txtDirect);
            this.gbDirect.Controls.Add(this.label7);
            this.gbDirect.Enabled = false;
            this.gbDirect.Location = new System.Drawing.Point(764, 413);
            this.gbDirect.Name = "gbDirect";
            this.gbDirect.Size = new System.Drawing.Size(208, 162);
            this.gbDirect.TabIndex = 7;
            this.gbDirect.TabStop = false;
            this.gbDirect.Text = "Direct : ";
            // 
            // btnSendPhotoDirect
            // 
            this.btnSendPhotoDirect.Location = new System.Drawing.Point(10, 135);
            this.btnSendPhotoDirect.Name = "btnSendPhotoDirect";
            this.btnSendPhotoDirect.Size = new System.Drawing.Size(95, 21);
            this.btnSendPhotoDirect.TabIndex = 2;
            this.btnSendPhotoDirect.Text = "Send Video";
            this.btnSendPhotoDirect.UseVisualStyleBackColor = true;
            this.btnSendPhotoDirect.Click += new System.EventHandler(this.btnSendPhotoDirect_Click);
            // 
            // btnSendVideoDirect
            // 
            this.btnSendVideoDirect.Location = new System.Drawing.Point(111, 135);
            this.btnSendVideoDirect.Name = "btnSendVideoDirect";
            this.btnSendVideoDirect.Size = new System.Drawing.Size(91, 21);
            this.btnSendVideoDirect.TabIndex = 2;
            this.btnSendVideoDirect.Text = "Send Photo";
            this.btnSendVideoDirect.UseVisualStyleBackColor = true;
            this.btnSendVideoDirect.Click += new System.EventHandler(this.btnSendVideoDirect_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(10, 113);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(192, 21);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Direct";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessageDirect
            // 
            this.txtMessageDirect.Location = new System.Drawing.Point(10, 45);
            this.txtMessageDirect.Multiline = true;
            this.txtMessageDirect.Name = "txtMessageDirect";
            this.txtMessageDirect.Size = new System.Drawing.Size(192, 62);
            this.txtMessageDirect.TabIndex = 1;
            this.txtMessageDirect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(75, 18);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(127, 21);
            this.txtDirect.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username :";
            // 
            // gbShowPostes
            // 
            this.gbShowPostes.Controls.Add(this.btnShowPostes);
            this.gbShowPostes.Controls.Add(this.txtUsernamePostes);
            this.gbShowPostes.Controls.Add(this.label8);
            this.gbShowPostes.Enabled = false;
            this.gbShowPostes.Location = new System.Drawing.Point(552, 12);
            this.gbShowPostes.Name = "gbShowPostes";
            this.gbShowPostes.Size = new System.Drawing.Size(200, 88);
            this.gbShowPostes.TabIndex = 8;
            this.gbShowPostes.TabStop = false;
            this.gbShowPostes.Text = "Show Posts : ";
            // 
            // btnShowPostes
            // 
            this.btnShowPostes.Location = new System.Drawing.Point(6, 48);
            this.btnShowPostes.Name = "btnShowPostes";
            this.btnShowPostes.Size = new System.Drawing.Size(187, 23);
            this.btnShowPostes.TabIndex = 2;
            this.btnShowPostes.Text = "Show Postes";
            this.btnShowPostes.UseVisualStyleBackColor = true;
            this.btnShowPostes.Click += new System.EventHandler(this.btnShowPostes_Click);
            // 
            // txtUsernamePostes
            // 
            this.txtUsernamePostes.Location = new System.Drawing.Point(67, 23);
            this.txtUsernamePostes.Name = "txtUsernamePostes";
            this.txtUsernamePostes.Size = new System.Drawing.Size(127, 21);
            this.txtUsernamePostes.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username :";
            // 
            // gbStory
            // 
            this.gbStory.Controls.Add(this.label9);
            this.gbStory.Controls.Add(this.txtCaptionStory);
            this.gbStory.Controls.Add(this.btnStosryPhoto);
            this.gbStory.Controls.Add(this.btnStosryVideo);
            this.gbStory.Enabled = false;
            this.gbStory.Location = new System.Drawing.Point(552, 86);
            this.gbStory.Name = "gbStory";
            this.gbStory.Size = new System.Drawing.Size(200, 70);
            this.gbStory.TabIndex = 9;
            this.gbStory.TabStop = false;
            this.gbStory.Text = "Story : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Caption :";
            // 
            // txtCaptionStory
            // 
            this.txtCaptionStory.Location = new System.Drawing.Point(67, 17);
            this.txtCaptionStory.Name = "txtCaptionStory";
            this.txtCaptionStory.Size = new System.Drawing.Size(126, 21);
            this.txtCaptionStory.TabIndex = 1;
            // 
            // btnStosryPhoto
            // 
            this.btnStosryPhoto.Location = new System.Drawing.Point(104, 40);
            this.btnStosryPhoto.Name = "btnStosryPhoto";
            this.btnStosryPhoto.Size = new System.Drawing.Size(89, 23);
            this.btnStosryPhoto.TabIndex = 0;
            this.btnStosryPhoto.Text = "Photo";
            this.btnStosryPhoto.UseVisualStyleBackColor = true;
            this.btnStosryPhoto.Click += new System.EventHandler(this.btnStosryPhoto_Click);
            // 
            // btnStosryVideo
            // 
            this.btnStosryVideo.Location = new System.Drawing.Point(6, 40);
            this.btnStosryVideo.Name = "btnStosryVideo";
            this.btnStosryVideo.Size = new System.Drawing.Size(92, 23);
            this.btnStosryVideo.TabIndex = 0;
            this.btnStosryVideo.Text = "Video";
            this.btnStosryVideo.UseVisualStyleBackColor = true;
            this.btnStosryVideo.Click += new System.EventHandler(this.btnStosryVideo_Click);
            // 
            // gbPost
            // 
            this.gbPost.Controls.Add(this.txtLocationPost);
            this.gbPost.Controls.Add(this.txtUsernameTag);
            this.gbPost.Controls.Add(this.btnSendVideoPost);
            this.gbPost.Controls.Add(this.btnSendImagePost);
            this.gbPost.Controls.Add(this.txtCaptionPost);
            this.gbPost.Enabled = false;
            this.gbPost.Location = new System.Drawing.Point(552, 413);
            this.gbPost.Name = "gbPost";
            this.gbPost.Size = new System.Drawing.Size(206, 276);
            this.gbPost.TabIndex = 10;
            this.gbPost.TabStop = false;
            this.gbPost.Text = "Post : ";
            // 
            // txtCaptionPost
            // 
            this.txtCaptionPost.Location = new System.Drawing.Point(6, 73);
            this.txtCaptionPost.Multiline = true;
            this.txtCaptionPost.Name = "txtCaptionPost";
            this.txtCaptionPost.Size = new System.Drawing.Size(194, 168);
            this.txtCaptionPost.TabIndex = 0;
            this.txtCaptionPost.Text = "Caption ";
            // 
            // btnSendImagePost
            // 
            this.btnSendImagePost.Location = new System.Drawing.Point(104, 247);
            this.btnSendImagePost.Name = "btnSendImagePost";
            this.btnSendImagePost.Size = new System.Drawing.Size(96, 23);
            this.btnSendImagePost.TabIndex = 1;
            this.btnSendImagePost.Text = "Photo";
            this.btnSendImagePost.UseVisualStyleBackColor = true;
            this.btnSendImagePost.Click += new System.EventHandler(this.btnSendImagePost_Click);
            // 
            // btnSendVideoPost
            // 
            this.btnSendVideoPost.Location = new System.Drawing.Point(7, 247);
            this.btnSendVideoPost.Name = "btnSendVideoPost";
            this.btnSendVideoPost.Size = new System.Drawing.Size(91, 23);
            this.btnSendVideoPost.TabIndex = 1;
            this.btnSendVideoPost.Text = "Video";
            this.btnSendVideoPost.UseVisualStyleBackColor = true;
            // 
            // txtUsernameTag
            // 
            this.txtUsernameTag.Location = new System.Drawing.Point(7, 18);
            this.txtUsernameTag.Name = "txtUsernameTag";
            this.txtUsernameTag.Size = new System.Drawing.Size(193, 21);
            this.txtUsernameTag.TabIndex = 2;
            this.txtUsernameTag.Text = "User Tags";
            this.txtUsernameTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocationPost
            // 
            this.txtLocationPost.Location = new System.Drawing.Point(7, 45);
            this.txtLocationPost.Name = "txtLocationPost";
            this.txtLocationPost.Size = new System.Drawing.Size(193, 21);
            this.txtLocationPost.TabIndex = 3;
            this.txtLocationPost.Text = "Location";
            this.txtLocationPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 729);
            this.Controls.Add(this.gbPost);
            this.Controls.Add(this.gbStory);
            this.Controls.Add(this.gbShowPostes);
            this.Controls.Add(this.gbDirect);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbBlocks);
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
            this.gbBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockUsers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDirect.ResumeLayout(false);
            this.gbDirect.PerformLayout();
            this.gbShowPostes.ResumeLayout(false);
            this.gbShowPostes.PerformLayout();
            this.gbStory.ResumeLayout(false);
            this.gbStory.PerformLayout();
            this.gbPost.ResumeLayout(false);
            this.gbPost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gbBlocks;
        private System.Windows.Forms.DataGridView dgvBlockUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnLoadBlockUsers;
        private System.Windows.Forms.Button btnBlockOrUnBlock;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbDirect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessageDirect;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Button btnSendPhotoDirect;
        private System.Windows.Forms.Button btnSendVideoDirect;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.GroupBox gbShowPostes;
        private System.Windows.Forms.Button btnShowPostes;
        private System.Windows.Forms.TextBox txtUsernamePostes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbStory;
        private System.Windows.Forms.Button btnStosryPhoto;
        private System.Windows.Forms.Button btnStosryVideo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaptionStory;
        private System.Windows.Forms.GroupBox gbPost;
        private System.Windows.Forms.TextBox txtUsernameTag;
        private System.Windows.Forms.Button btnSendVideoPost;
        private System.Windows.Forms.Button btnSendImagePost;
        private System.Windows.Forms.TextBox txtCaptionPost;
        private System.Windows.Forms.TextBox txtLocationPost;
    }
}

