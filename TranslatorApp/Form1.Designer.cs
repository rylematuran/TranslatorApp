namespace TranslatorApp
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
            System.Windows.Forms.Label label1;
            this.textInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.textOutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SourceLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.TargetLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.buttonTranslate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.Color.Transparent;
            this.textInput.BorderColor = System.Drawing.Color.Transparent;
            this.textInput.BorderRadius = 25;
            this.textInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FillColor = System.Drawing.Color.Teal;
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Location = new System.Drawing.Point(24, 77);
            this.textInput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderText = "Type here...";
            this.textInput.SelectedText = "";
            this.textInput.Size = new System.Drawing.Size(206, 182);
            this.textInput.TabIndex = 0;
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.Transparent;
            this.textOutput.BorderColor = System.Drawing.Color.Transparent;
            this.textOutput.BorderRadius = 25;
            this.textOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOutput.DefaultText = "";
            this.textOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.FillColor = System.Drawing.Color.Teal;
            this.textOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.textOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.Location = new System.Drawing.Point(240, 77);
            this.textOutput.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.PasswordChar = '\0';
            this.textOutput.PlaceholderText = "Translated Text";
            this.textOutput.SelectedText = "";
            this.textOutput.Size = new System.Drawing.Size(206, 182);
            this.textOutput.TabIndex = 1;
            // 
            // SourceLanguage
            // 
            this.SourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.SourceLanguage.BorderColor = System.Drawing.Color.Black;
            this.SourceLanguage.BorderRadius = 20;
            this.SourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SourceLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SourceLanguage.ItemHeight = 30;
            this.SourceLanguage.Location = new System.Drawing.Point(34, 402);
            this.SourceLanguage.Name = "SourceLanguage";
            this.SourceLanguage.Size = new System.Drawing.Size(184, 36);
            this.SourceLanguage.TabIndex = 2;
            this.SourceLanguage.SelectedIndexChanged += new System.EventHandler(this.SourceLanguage_SelectedIndexChanged);
            // 
            // TargetLanguage
            // 
            this.TargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.TargetLanguage.BorderColor = System.Drawing.Color.Black;
            this.TargetLanguage.BorderRadius = 20;
            this.TargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TargetLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TargetLanguage.ItemHeight = 30;
            this.TargetLanguage.Location = new System.Drawing.Point(266, 402);
            this.TargetLanguage.Name = "TargetLanguage";
            this.TargetLanguage.Size = new System.Drawing.Size(180, 36);
            this.TargetLanguage.TabIndex = 3;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.BackColor = System.Drawing.Color.Transparent;
            this.buttonTranslate.BorderColor = System.Drawing.Color.Transparent;
            this.buttonTranslate.BorderRadius = 15;
            this.buttonTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTranslate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTranslate.FillColor = System.Drawing.Color.Teal;
            this.buttonTranslate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTranslate.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.buttonTranslate.ForeColor = System.Drawing.Color.MintCream;
            this.buttonTranslate.Location = new System.Drawing.Point(136, 479);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(215, 65);
            this.buttonTranslate.TabIndex = 4;
            this.buttonTranslate.Text = "TRANSLATE";
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Menu;
            label1.Location = new System.Drawing.Point(79, 18);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(308, 38);
            label1.TabIndex = 5;
            label1.Text = "Lets Translate!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TranslatorApp.Properties.Resources.sddasd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(470, 637);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.TargetLanguage);
            this.Controls.Add(this.SourceLanguage);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "TRANSLATION APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textOutput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox TargetLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton buttonTranslate;
    }
}

