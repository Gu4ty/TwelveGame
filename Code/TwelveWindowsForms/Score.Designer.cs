namespace TwelveWindowsForms
{
    partial class frmScore
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
            this.tabAg = new System.Windows.Forms.TabPage();
            this.dgvScoresAggressive = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNormal = new System.Windows.Forms.TabPage();
            this.dgvScoresNormal = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabmode = new System.Windows.Forms.TabControl();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearRecord = new System.Windows.Forms.Button();
            this.tabAg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresAggressive)).BeginInit();
            this.tabNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresNormal)).BeginInit();
            this.tabmode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAg
            // 
            this.tabAg.Controls.Add(this.dgvScoresAggressive);
            this.tabAg.Location = new System.Drawing.Point(4, 22);
            this.tabAg.Name = "tabAg";
            this.tabAg.Padding = new System.Windows.Forms.Padding(3);
            this.tabAg.Size = new System.Drawing.Size(447, 301);
            this.tabAg.TabIndex = 1;
            this.tabAg.Text = "Aggressive";
            this.tabAg.UseVisualStyleBackColor = true;
            // 
            // dgvScoresAggressive
            // 
            this.dgvScoresAggressive.AllowUserToAddRows = false;
            this.dgvScoresAggressive.AllowUserToDeleteRows = false;
            this.dgvScoresAggressive.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvScoresAggressive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresAggressive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvScoresAggressive.Location = new System.Drawing.Point(0, 0);
            this.dgvScoresAggressive.Name = "dgvScoresAggressive";
            this.dgvScoresAggressive.ReadOnly = true;
            this.dgvScoresAggressive.Size = new System.Drawing.Size(445, 299);
            this.dgvScoresAggressive.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Score";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Higher";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabNormal
            // 
            this.tabNormal.Controls.Add(this.dgvScoresNormal);
            this.tabNormal.Location = new System.Drawing.Point(4, 22);
            this.tabNormal.Name = "tabNormal";
            this.tabNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormal.Size = new System.Drawing.Size(447, 301);
            this.tabNormal.TabIndex = 0;
            this.tabNormal.Text = "Normal";
            this.tabNormal.UseVisualStyleBackColor = true;
            // 
            // dgvScoresNormal
            // 
            this.dgvScoresNormal.AllowUserToAddRows = false;
            this.dgvScoresNormal.AllowUserToDeleteRows = false;
            this.dgvScoresNormal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvScoresNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvScoresNormal.Location = new System.Drawing.Point(0, 0);
            this.dgvScoresNormal.Name = "dgvScoresNormal";
            this.dgvScoresNormal.ReadOnly = true;
            this.dgvScoresNormal.Size = new System.Drawing.Size(445, 299);
            this.dgvScoresNormal.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Score";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Higher";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Time";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tabmode
            // 
            this.tabmode.Controls.Add(this.tabNormal);
            this.tabmode.Controls.Add(this.tabAg);
            this.tabmode.Location = new System.Drawing.Point(12, 12);
            this.tabmode.Name = "tabmode";
            this.tabmode.SelectedIndex = 0;
            this.tabmode.Size = new System.Drawing.Size(455, 327);
            this.tabmode.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(39, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Game";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearRecord
            // 
            this.btnClearRecord.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecord.Location = new System.Drawing.Point(260, 345);
            this.btnClearRecord.Name = "btnClearRecord";
            this.btnClearRecord.Size = new System.Drawing.Size(179, 51);
            this.btnClearRecord.TabIndex = 3;
            this.btnClearRecord.Text = "Clear Records";
            this.btnClearRecord.UseVisualStyleBackColor = true;
            this.btnClearRecord.Click += new System.EventHandler(this.btnClearRecord_Click);
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 397);
            this.Controls.Add(this.btnClearRecord);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabmode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScore";
            this.Text = "Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScore_FormClosing);
            this.tabAg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresAggressive)).EndInit();
            this.tabNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresNormal)).EndInit();
            this.tabmode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabAg;
        private System.Windows.Forms.DataGridView dgvScoresAggressive;
        private System.Windows.Forms.TabPage tabNormal;
        private System.Windows.Forms.DataGridView dgvScoresNormal;
        private System.Windows.Forms.TabControl tabmode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnClearRecord;
    }
}