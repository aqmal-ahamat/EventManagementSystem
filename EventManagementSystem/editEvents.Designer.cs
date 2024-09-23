namespace EventManagementSystem
{
    partial class editEvents
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.eventvenuetxt = new System.Windows.Forms.TextBox();
            this.eventnametxt = new System.Windows.Forms.TextBox();
            this.maxparticipantsinput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alleventsinput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minutesinput = new System.Windows.Forms.NumericUpDown();
            this.hourinput = new System.Windows.Forms.NumericUpDown();
            this.yearinput = new System.Windows.Forms.NumericUpDown();
            this.monthinput = new System.Windows.Forms.NumericUpDown();
            this.dayinput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.eventPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxparticipantsinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayinput)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.Location = new System.Drawing.Point(51, 395);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(149, 70);
            this.cancelbtn.TabIndex = 31;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.savebtn.Location = new System.Drawing.Point(649, 395);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(224, 70);
            this.savebtn.TabIndex = 30;
            this.savebtn.Text = "Save changes";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // eventvenuetxt
            // 
            this.eventvenuetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eventvenuetxt.Location = new System.Drawing.Point(159, 235);
            this.eventvenuetxt.Name = "eventvenuetxt";
            this.eventvenuetxt.Size = new System.Drawing.Size(289, 26);
            this.eventvenuetxt.TabIndex = 27;
            // 
            // eventnametxt
            // 
            this.eventnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eventnametxt.Location = new System.Drawing.Point(159, 179);
            this.eventnametxt.Name = "eventnametxt";
            this.eventnametxt.Size = new System.Drawing.Size(289, 26);
            this.eventnametxt.TabIndex = 26;
            // 
            // maxparticipantsinput
            // 
            this.maxparticipantsinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxparticipantsinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxparticipantsinput.Location = new System.Drawing.Point(761, 235);
            this.maxparticipantsinput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxparticipantsinput.Name = "maxparticipantsinput";
            this.maxparticipantsinput.Size = new System.Drawing.Size(131, 26);
            this.maxparticipantsinput.TabIndex = 24;
            this.maxparticipantsinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(493, 237);
            this.label6.MaximumSize = new System.Drawing.Size(300, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Maximum number of participants";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(484, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(488, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(49, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Venue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "Edit event";
            // 
            // alleventsinput
            // 
            this.alleventsinput.FormattingEnabled = true;
            this.alleventsinput.Location = new System.Drawing.Point(492, 94);
            this.alleventsinput.Name = "alleventsinput";
            this.alleventsinput.Size = new System.Drawing.Size(235, 28);
            this.alleventsinput.TabIndex = 34;
            this.alleventsinput.SelectedIndexChanged += new System.EventHandler(this.alleventsinput_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(333, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Select Event";
            // 
            // minutesinput
            // 
            this.minutesinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minutesinput.Location = new System.Drawing.Point(708, 181);
            this.minutesinput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesinput.Name = "minutesinput";
            this.minutesinput.Size = new System.Drawing.Size(109, 26);
            this.minutesinput.TabIndex = 37;
            this.minutesinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hourinput
            // 
            this.hourinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hourinput.Location = new System.Drawing.Point(558, 180);
            this.hourinput.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourinput.Name = "hourinput";
            this.hourinput.Size = new System.Drawing.Size(117, 26);
            this.hourinput.TabIndex = 36;
            this.hourinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearinput
            // 
            this.yearinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yearinput.Location = new System.Drawing.Point(761, 295);
            this.yearinput.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.yearinput.Name = "yearinput";
            this.yearinput.Size = new System.Drawing.Size(117, 26);
            this.yearinput.TabIndex = 40;
            this.yearinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthinput
            // 
            this.monthinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.monthinput.Location = new System.Drawing.Point(668, 295);
            this.monthinput.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.monthinput.Name = "monthinput";
            this.monthinput.Size = new System.Drawing.Size(76, 26);
            this.monthinput.TabIndex = 39;
            this.monthinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dayinput
            // 
            this.dayinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dayinput.Location = new System.Drawing.Point(558, 296);
            this.dayinput.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayinput.Name = "dayinput";
            this.dayinput.Size = new System.Drawing.Size(90, 26);
            this.dayinput.TabIndex = 38;
            this.dayinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(576, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(678, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(791, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Year";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label.Location = new System.Drawing.Point(83, 307);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 45;
            this.label.Text = "Price";
            // 
            // eventPrice
            // 
            this.eventPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eventPrice.Location = new System.Drawing.Point(159, 301);
            this.eventPrice.Name = "eventPrice";
            this.eventPrice.Size = new System.Drawing.Size(289, 26);
            this.eventPrice.TabIndex = 46;
            // 
            // editEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 491);
            this.Controls.Add(this.eventPrice);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yearinput);
            this.Controls.Add(this.monthinput);
            this.Controls.Add(this.dayinput);
            this.Controls.Add(this.minutesinput);
            this.Controls.Add(this.hourinput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alleventsinput);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.eventvenuetxt);
            this.Controls.Add(this.eventnametxt);
            this.Controls.Add(this.maxparticipantsinput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editEvents";
            this.Text = "editEvents";
            this.Load += new System.EventHandler(this.editEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxparticipantsinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox eventvenuetxt;
        private System.Windows.Forms.TextBox eventnametxt;
        private System.Windows.Forms.NumericUpDown maxparticipantsinput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox alleventsinput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown minutesinput;
        private System.Windows.Forms.NumericUpDown hourinput;
        private System.Windows.Forms.NumericUpDown yearinput;
        private System.Windows.Forms.NumericUpDown monthinput;
        private System.Windows.Forms.NumericUpDown dayinput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox eventPrice;
    }
}