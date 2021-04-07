
namespace SinifForm
{
    partial class Form1
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
            this.EndBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndBtn
            // 
            this.EndBtn.CheckedState.Parent = this.EndBtn;
            this.EndBtn.CustomImages.Parent = this.EndBtn;
            this.EndBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndBtn.ForeColor = System.Drawing.Color.White;
            this.EndBtn.HoverState.Parent = this.EndBtn;
            this.EndBtn.Location = new System.Drawing.Point(215, 300);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.ShadowDecoration.Parent = this.EndBtn;
            this.EndBtn.Size = new System.Drawing.Size(180, 45);
            this.EndBtn.TabIndex = 21;
            this.EndBtn.Text = "End";
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoRoundedCorners = true;
            this.PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PasswordTxt.BorderRadius = 8;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.Parent = this.PasswordTxt;
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.FocusedState.Parent = this.PasswordTxt;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxt.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.HoverState.Parent = this.PasswordTxt;
            this.PasswordTxt.Location = new System.Drawing.Point(140, 135);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.PlaceholderText = "Password";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.ShadowDecoration.Parent = this.PasswordTxt;
            this.PasswordTxt.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxt.TabIndex = 16;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AutoRoundedCorners = true;
            this.UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsernameTxt.BorderRadius = 8;
            this.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxt.DefaultText = "";
            this.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.DisabledState.Parent = this.UsernameTxt;
            this.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxt.FocusedState.Parent = this.UsernameTxt;
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxt.HoverState.Parent = this.UsernameTxt;
            this.UsernameTxt.Location = new System.Drawing.Point(140, 93);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.PlaceholderText = "Username\r\n";
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.ShadowDecoration.Parent = this.UsernameTxt;
            this.UsernameTxt.Size = new System.Drawing.Size(200, 36);
            this.UsernameTxt.TabIndex = 15;
            // 
            // ShowCheck
            // 
            this.ShowCheck.AutoSize = true;
            this.ShowCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowCheck.CheckedState.BorderRadius = 0;
            this.ShowCheck.CheckedState.BorderThickness = 0;
            this.ShowCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ShowCheck.Location = new System.Drawing.Point(140, 193);
            this.ShowCheck.Name = "ShowCheck";
            this.ShowCheck.Size = new System.Drawing.Size(102, 17);
            this.ShowCheck.TabIndex = 20;
            this.ShowCheck.Text = "Show Password";
            this.ShowCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowCheck.UncheckedState.BorderRadius = 0;
            this.ShowCheck.UncheckedState.BorderThickness = 0;
            this.ShowCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowCheck.CheckedChanged += new System.EventHandler(this.ShowCheck_CheckedChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.AutoRoundedCorners = true;
            this.ClearBtn.BorderRadius = 14;
            this.ClearBtn.CheckedState.Parent = this.ClearBtn;
            this.ClearBtn.CustomImages.Parent = this.ClearBtn;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.HoverState.Parent = this.ClearBtn;
            this.ClearBtn.Location = new System.Drawing.Point(364, 180);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(106, 30);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear ";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(140, 229);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(330, 34);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(167, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "LOG IN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinifForm.Properties.Resources.skynight;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.ShowCheck);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button EndBtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private Guna.UI2.WinForms.Guna2CheckBox ShowCheck;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
    }
}

