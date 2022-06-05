namespace BotInstagram.Foms
{
    partial class frmGetFollowers
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToLost = new System.Windows.Forms.Button();
            this.btnLoadFollowings = new System.Windows.Forms.Button();
            this.btnLoadFollowers = new System.Windows.Forms.Button();
            this.dgvPages = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteFromList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsTimer = new System.Windows.Forms.TextBox();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.btnStartOrStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvFollowings = new System.Windows.Forms.DataGridView();
            this.btnUnFollow = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFollow = new System.Windows.Forms.Button();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Numberr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPages)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPages);
            this.groupBox1.Controls.Add(this.btnLoadFollowers);
            this.groupBox1.Controls.Add(this.btnLoadFollowings);
            this.groupBox1.Controls.Add(this.btnAddToLost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pages : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(69, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // btnAddToLost
            // 
            this.btnAddToLost.Location = new System.Drawing.Point(6, 46);
            this.btnAddToLost.Name = "btnAddToLost";
            this.btnAddToLost.Size = new System.Drawing.Size(252, 23);
            this.btnAddToLost.TabIndex = 1;
            this.btnAddToLost.Text = "Add To List";
            this.btnAddToLost.UseVisualStyleBackColor = true;
            this.btnAddToLost.Click += new System.EventHandler(this.btnAddToLost_Click);
            // 
            // btnLoadFollowings
            // 
            this.btnLoadFollowings.Location = new System.Drawing.Point(6, 75);
            this.btnLoadFollowings.Name = "btnLoadFollowings";
            this.btnLoadFollowings.Size = new System.Drawing.Size(252, 23);
            this.btnLoadFollowings.TabIndex = 2;
            this.btnLoadFollowings.Text = "Load Followings";
            this.btnLoadFollowings.UseVisualStyleBackColor = true;
            this.btnLoadFollowings.Click += new System.EventHandler(this.btnLoadFollowings_Click);
            // 
            // btnLoadFollowers
            // 
            this.btnLoadFollowers.Location = new System.Drawing.Point(6, 104);
            this.btnLoadFollowers.Name = "btnLoadFollowers";
            this.btnLoadFollowers.Size = new System.Drawing.Size(252, 23);
            this.btnLoadFollowers.TabIndex = 3;
            this.btnLoadFollowers.Text = "Load Followers";
            this.btnLoadFollowers.UseVisualStyleBackColor = true;
            this.btnLoadFollowers.Click += new System.EventHandler(this.btnLoadFollowers_Click);
            // 
            // dgvPages
            // 
            this.dgvPages.AllowUserToAddRows = false;
            this.dgvPages.AllowUserToDeleteRows = false;
            this.dgvPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Username,
            this.FullName});
            this.dgvPages.Location = new System.Drawing.Point(6, 133);
            this.dgvPages.Name = "dgvPages";
            this.dgvPages.ReadOnly = true;
            this.dgvPages.RowHeadersVisible = false;
            this.dgvPages.Size = new System.Drawing.Size(252, 294);
            this.dgvPages.TabIndex = 4;
            this.dgvPages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPages_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteFromList);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(282, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List : ";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvList.Location = new System.Drawing.Point(6, 46);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(188, 242);
            this.dgvList.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "*";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 38;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 80;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 78;
            // 
            // btnDeleteFromList
            // 
            this.btnDeleteFromList.Location = new System.Drawing.Point(6, 18);
            this.btnDeleteFromList.Name = "btnDeleteFromList";
            this.btnDeleteFromList.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteFromList.TabIndex = 5;
            this.btnDeleteFromList.Text = "Delete";
            this.btnDeleteFromList.UseVisualStyleBackColor = true;
            this.btnDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNo);
            this.groupBox3.Controls.Add(this.rbYes);
            this.groupBox3.Controls.Add(this.btnStartOrStop);
            this.groupBox3.Controls.Add(this.btnSetTimer);
            this.groupBox3.Controls.Add(this.txtMsTimer);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(282, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commands : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MS :";
            // 
            // txtMsTimer
            // 
            this.txtMsTimer.Location = new System.Drawing.Point(41, 20);
            this.txtMsTimer.Name = "txtMsTimer";
            this.txtMsTimer.Size = new System.Drawing.Size(153, 21);
            this.txtMsTimer.TabIndex = 1;
            this.txtMsTimer.Text = "20000";
            this.txtMsTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(6, 47);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(188, 23);
            this.btnSetTimer.TabIndex = 2;
            this.btnSetTimer.Text = "Set";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // btnStartOrStop
            // 
            this.btnStartOrStop.Location = new System.Drawing.Point(6, 104);
            this.btnStartOrStop.Name = "btnStartOrStop";
            this.btnStartOrStop.Size = new System.Drawing.Size(188, 23);
            this.btnStartOrStop.TabIndex = 2;
            this.btnStartOrStop.Text = "Stop / Start";
            this.btnStartOrStop.UseVisualStyleBackColor = true;
            this.btnStartOrStop.Click += new System.EventHandler(this.btnStartOrStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Auto Unfollow : ";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(97, 79);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(42, 17);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(145, 79);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(38, 17);
            this.rbNo.TabIndex = 3;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUnFollow);
            this.groupBox4.Controls.Add(this.dgvFollowings);
            this.groupBox4.Location = new System.Drawing.Point(488, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 433);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Following : ";
            // 
            // dgvFollowings
            // 
            this.dgvFollowings.AllowUserToAddRows = false;
            this.dgvFollowings.AllowUserToDeleteRows = false;
            this.dgvFollowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.dgvFollowings.Location = new System.Drawing.Point(6, 18);
            this.dgvFollowings.Name = "dgvFollowings";
            this.dgvFollowings.ReadOnly = true;
            this.dgvFollowings.RowHeadersVisible = false;
            this.dgvFollowings.Size = new System.Drawing.Size(162, 380);
            this.dgvFollowings.TabIndex = 4;
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.Location = new System.Drawing.Point(6, 404);
            this.btnUnFollow.Name = "btnUnFollow";
            this.btnUnFollow.Size = new System.Drawing.Size(162, 23);
            this.btnUnFollow.TabIndex = 5;
            this.btnUnFollow.Text = "Un Follow";
            this.btnUnFollow.UseVisualStyleBackColor = true;
            this.btnUnFollow.Click += new System.EventHandler(this.btnUnFollow_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFollow);
            this.groupBox5.Controls.Add(this.dgvFollowers);
            this.groupBox5.Location = new System.Drawing.Point(668, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 433);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Followers : ";
            // 
            // btnFollow
            // 
            this.btnFollow.Location = new System.Drawing.Point(6, 404);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(162, 23);
            this.btnFollow.TabIndex = 5;
            this.btnFollow.Text = "Follow";
            this.btnFollow.UseVisualStyleBackColor = true;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // dgvFollowers
            // 
            this.dgvFollowers.AllowUserToAddRows = false;
            this.dgvFollowers.AllowUserToDeleteRows = false;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numberr,
            this.dataGridViewTextBoxColumn6});
            this.dgvFollowers.Location = new System.Drawing.Point(6, 18);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.ReadOnly = true;
            this.dgvFollowers.RowHeadersVisible = false;
            this.dgvFollowers.Size = new System.Drawing.Size(162, 380);
            this.dgvFollowers.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 43200000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 600000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Numberr
            // 
            this.Numberr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Numberr.HeaderText = "*";
            this.Numberr.Name = "Numberr";
            this.Numberr.ReadOnly = true;
            this.Numberr.Width = 38;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frmGetFollowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 457);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGetFollowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get Followers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPages)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowings)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFollowers;
        private System.Windows.Forms.Button btnLoadFollowings;
        private System.Windows.Forms.Button btnAddToLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dgvPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteFromList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMsTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartOrStop;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUnFollow;
        private System.Windows.Forms.DataGridView dgvFollowings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.DataGridView dgvFollowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numberr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}