namespace EventManagementSystem
{
    partial class registerForEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.alleventsinput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(369, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(254, 280);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(390, 52);
            this.cancelbtn.TabIndex = 30;
            this.cancelbtn.Text = "Back";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.White;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.registerbtn.Location = new System.Drawing.Point(233, 185);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(425, 59);
            this.registerbtn.TabIndex = 29;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(229, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Select Event";
            // 
            // alleventsinput
            // 
            this.alleventsinput.FormattingEnabled = true;
            this.alleventsinput.Location = new System.Drawing.Point(388, 111);
            this.alleventsinput.Name = "alleventsinput";
            this.alleventsinput.Size = new System.Drawing.Size(270, 28);
            this.alleventsinput.TabIndex = 38;
            // 
            // registerForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 392);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alleventsinput);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registerForEvent";
            this.Text = "registerForEvent";
            this.Load += new System.EventHandler(this.registerForEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox alleventsinput;
    }
}