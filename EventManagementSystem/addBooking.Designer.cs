namespace EventManagementSystem
{
    partial class addBooking
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
            this.label7 = new System.Windows.Forms.Label();
            this.participantinput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventInput = new System.Windows.Forms.ComboBox();
            this.RegisterEventsbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(332, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create bookings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(249, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Select participant";
            // 
            // participantinput
            // 
            this.participantinput.FormattingEnabled = true;
            this.participantinput.Location = new System.Drawing.Point(208, 195);
            this.participantinput.Name = "participantinput";
            this.participantinput.Size = new System.Drawing.Size(235, 28);
            this.participantinput.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(544, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Select Event";
            // 
            // eventInput
            // 
            this.eventInput.FormattingEnabled = true;
            this.eventInput.Location = new System.Drawing.Point(485, 195);
            this.eventInput.Name = "eventInput";
            this.eventInput.Size = new System.Drawing.Size(235, 28);
            this.eventInput.TabIndex = 44;
            // 
            // RegisterEventsbtn
            // 
            this.RegisterEventsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEventsbtn.Location = new System.Drawing.Point(502, 275);
            this.RegisterEventsbtn.Name = "RegisterEventsbtn";
            this.RegisterEventsbtn.Size = new System.Drawing.Size(167, 65);
            this.RegisterEventsbtn.TabIndex = 47;
            this.RegisterEventsbtn.Text = "Create booking";
            this.RegisterEventsbtn.UseVisualStyleBackColor = true;
            this.RegisterEventsbtn.Click += new System.EventHandler(this.RegisterEventsbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(239, 275);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(167, 65);
            this.cancelbtn.TabIndex = 46;
            this.cancelbtn.Text = "Back";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 424);
            this.Controls.Add(this.RegisterEventsbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.participantinput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addBooking";
            this.Text = "addBooking";
            this.Load += new System.EventHandler(this.addBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox participantinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eventInput;
        private System.Windows.Forms.Button RegisterEventsbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}