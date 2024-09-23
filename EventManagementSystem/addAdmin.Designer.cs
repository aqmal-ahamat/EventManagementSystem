namespace EventManagementSystem
{
    partial class addAdmin
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
            this.label7 = new System.Windows.Forms.Label();
            this.alluserinput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.organizerbtn = new System.Windows.Forms.RadioButton();
            this.adminbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(103, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Select User";
            // 
            // alluserinput
            // 
            this.alluserinput.FormattingEnabled = true;
            this.alluserinput.Location = new System.Drawing.Point(262, 128);
            this.alluserinput.Name = "alluserinput";
            this.alluserinput.Size = new System.Drawing.Size(235, 24);
            this.alluserinput.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(187, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 47);
            this.label1.TabIndex = 36;
            this.label1.Text = "Add admins";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(98, 246);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(149, 61);
            this.cancelbtn.TabIndex = 40;
            this.cancelbtn.Text = "Back";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.savebtn.Location = new System.Drawing.Point(301, 246);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(196, 61);
            this.savebtn.TabIndex = 39;
            this.savebtn.Text = "Save changes";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // organizerbtn
            // 
            this.organizerbtn.AutoSize = true;
            this.organizerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerbtn.Location = new System.Drawing.Point(384, 181);
            this.organizerbtn.Name = "organizerbtn";
            this.organizerbtn.Size = new System.Drawing.Size(113, 24);
            this.organizerbtn.TabIndex = 41;
            this.organizerbtn.TabStop = true;
            this.organizerbtn.Text = "Organizer";
            this.organizerbtn.UseVisualStyleBackColor = true;
            // 
            // adminbtn
            // 
            this.adminbtn.AutoSize = true;
            this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(262, 179);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(82, 24);
            this.adminbtn.TabIndex = 42;
            this.adminbtn.TabStop = true;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(103, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Role";
            // 
            // addAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.organizerbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alluserinput);
            this.Controls.Add(this.label1);
            this.Name = "addAdmin";
            this.Text = "addAdmin";
            this.Load += new System.EventHandler(this.addAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox alluserinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.RadioButton organizerbtn;
        private System.Windows.Forms.RadioButton adminbtn;
        private System.Windows.Forms.Label label2;
    }
}