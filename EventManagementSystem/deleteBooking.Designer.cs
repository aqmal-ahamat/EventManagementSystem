namespace EventManagementSystem
{
    partial class deleteBooking
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
            this.RegisterEventsbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eventinput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.participantinput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterEventsbtn
            // 
            this.RegisterEventsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEventsbtn.Location = new System.Drawing.Point(459, 282);
            this.RegisterEventsbtn.Name = "RegisterEventsbtn";
            this.RegisterEventsbtn.Size = new System.Drawing.Size(167, 65);
            this.RegisterEventsbtn.TabIndex = 54;
            this.RegisterEventsbtn.Text = "Delete booking";
            this.RegisterEventsbtn.UseVisualStyleBackColor = true;
            this.RegisterEventsbtn.Click += new System.EventHandler(this.RegisterEventsbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(250, 282);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(167, 65);
            this.cancelbtn.TabIndex = 53;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(518, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Select Event";
            // 
            // eventinput
            // 
            this.eventinput.FormattingEnabled = true;
            this.eventinput.Location = new System.Drawing.Point(459, 206);
            this.eventinput.Name = "eventinput";
            this.eventinput.Size = new System.Drawing.Size(235, 28);
            this.eventinput.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(223, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Select participant";
            // 
            // participantinput
            // 
            this.participantinput.FormattingEnabled = true;
            this.participantinput.Location = new System.Drawing.Point(182, 206);
            this.participantinput.Name = "participantinput";
            this.participantinput.Size = new System.Drawing.Size(235, 28);
            this.participantinput.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 48;
            this.label1.Text = "Delete bookings";
            // 
            // deleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 468);
            this.Controls.Add(this.RegisterEventsbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventinput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.participantinput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "deleteBooking";
            this.Text = "deleteBooking";
            this.Load += new System.EventHandler(this.deleteBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterEventsbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eventinput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox participantinput;
        private System.Windows.Forms.Label label1;
    }
}