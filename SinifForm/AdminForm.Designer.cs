
namespace SinifForm
{
    partial class AdminForm
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
            this.ClearPanelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgw_Students = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearPanelBtn
            // 
            this.ClearPanelBtn.AutoRoundedCorners = true;
            this.ClearPanelBtn.BorderRadius = 22;
            this.ClearPanelBtn.CheckedState.Parent = this.ClearPanelBtn;
            this.ClearPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearPanelBtn.CustomImages.Parent = this.ClearPanelBtn;
            this.ClearPanelBtn.FillColor = System.Drawing.Color.Red;
            this.ClearPanelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearPanelBtn.ForeColor = System.Drawing.Color.White;
            this.ClearPanelBtn.HoverState.Parent = this.ClearPanelBtn;
            this.ClearPanelBtn.Location = new System.Drawing.Point(951, 214);
            this.ClearPanelBtn.Name = "ClearPanelBtn";
            this.ClearPanelBtn.ShadowDecoration.Parent = this.ClearPanelBtn;
            this.ClearPanelBtn.Size = new System.Drawing.Size(56, 47);
            this.ClearPanelBtn.TabIndex = 10;
            this.ClearPanelBtn.Text = "X";
            this.ClearPanelBtn.Visible = false;
            this.ClearPanelBtn.Click += new System.EventHandler(this.ClearPanelBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 230);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoRoundedCorners = true;
            this.RemoveButton.BorderRadius = 20;
            this.RemoveButton.CheckedState.Parent = this.RemoveButton;
            this.RemoveButton.CustomImages.Parent = this.RemoveButton;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.HoverState.Parent = this.RemoveButton;
            this.RemoveButton.Location = new System.Drawing.Point(73, 154);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.ShadowDecoration.Parent = this.RemoveButton;
            this.RemoveButton.Size = new System.Drawing.Size(110, 42);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoRoundedCorners = true;
            this.UpdateButton.BorderRadius = 20;
            this.UpdateButton.CheckedState.Parent = this.UpdateButton;
            this.UpdateButton.CustomImages.Parent = this.UpdateButton;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.HoverState.Parent = this.UpdateButton;
            this.UpdateButton.Location = new System.Drawing.Point(73, 106);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.ShadowDecoration.Parent = this.UpdateButton;
            this.UpdateButton.Size = new System.Drawing.Size(110, 42);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoRoundedCorners = true;
            this.AddButton.BorderRadius = 20;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Location = new System.Drawing.Point(73, 58);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(110, 42);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dgw_Students
            // 
            this.dgw_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Students.Location = new System.Drawing.Point(234, 58);
            this.dgw_Students.Name = "dgw_Students";
            this.dgw_Students.Size = new System.Drawing.Size(737, 150);
            this.dgw_Students.TabIndex = 11;
            this.dgw_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Students_CellClick);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.DefaultText = "";
            this.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.DisabledState.Parent = this.SearchTxt;
            this.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.FocusedState.Parent = this.SearchTxt;
            this.SearchTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.HoverState.Parent = this.SearchTxt;
            this.SearchTxt.Location = new System.Drawing.Point(350, 12);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PlaceholderText = "Search\r\n";
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.ShadowDecoration.Parent = this.SearchTxt;
            this.SearchTxt.Size = new System.Drawing.Size(329, 36);
            this.SearchTxt.TabIndex = 16;
            this.SearchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyUp);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 458);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.ClearPanelBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dgw_Students);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ClearPanelBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button RemoveButton;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.DataGridView dgw_Students;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxt;
    }
}