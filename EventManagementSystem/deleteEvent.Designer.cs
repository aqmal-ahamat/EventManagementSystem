namespace EventManagementSystem
{
    partial class deleteEvent
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
            this.alleventsinput = new System.Windows.Forms.ComboBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delete event";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(260, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Select Event";
            // 
            // alleventsinput
            // 
            this.alleventsinput.FormattingEnabled = true;
            this.alleventsinput.Location = new System.Drawing.Point(395, 129);
            this.alleventsinput.Name = "alleventsinput";
            this.alleventsinput.Size = new System.Drawing.Size(297, 28);
            this.alleventsinput.TabIndex = 36;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(264, 199);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(149, 70);
            this.cancelbtn.TabIndex = 39;
            this.cancelbtn.Text = "back";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.deletebtn.Location = new System.Drawing.Point(468, 199);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(224, 70);
            this.deletebtn.TabIndex = 38;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 389);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alleventsinput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "deleteEvent";
            this.Text = "deleteEvent";
            this.Load += new System.EventHandler(this.deleteEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox alleventsinput;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}