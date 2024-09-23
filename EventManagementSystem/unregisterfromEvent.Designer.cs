namespace EventManagementSystem
{
    partial class unregisterfromEvent
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
            this.unregisterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(311, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unregister";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(212, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Select Event";
            // 
            // alleventsinput
            // 
            this.alleventsinput.FormattingEnabled = true;
            this.alleventsinput.Location = new System.Drawing.Point(371, 137);
            this.alleventsinput.Name = "alleventsinput";
            this.alleventsinput.Size = new System.Drawing.Size(235, 28);
            this.alleventsinput.TabIndex = 40;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(443, 208);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(262, 52);
            this.cancelbtn.TabIndex = 43;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // unregisterbtn
            // 
            this.unregisterbtn.BackColor = System.Drawing.Color.White;
            this.unregisterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.unregisterbtn.Location = new System.Drawing.Point(144, 208);
            this.unregisterbtn.Name = "unregisterbtn";
            this.unregisterbtn.Size = new System.Drawing.Size(262, 52);
            this.unregisterbtn.TabIndex = 42;
            this.unregisterbtn.Text = "Unregister";
            this.unregisterbtn.UseVisualStyleBackColor = false;
            this.unregisterbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // unregisterfromEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 373);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.unregisterbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alleventsinput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "unregisterfromEvent";
            this.Text = "unregisterfromEvent";
            this.Load += new System.EventHandler(this.unregisterfromEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox alleventsinput;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button unregisterbtn;
    }
}