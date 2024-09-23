namespace EventManagementSystem
{
    partial class viewBookings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allbookingsview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.eventinput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userinput = new System.Windows.Forms.ComboBox();
            this.filterbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.addParticipantsbtn = new System.Windows.Forms.Button();
            this.removeParticipantsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allbookingsview)).BeginInit();
            this.SuspendLayout();
            // 
            // allbookingsview
            // 
            this.allbookingsview.AllowUserToAddRows = false;
            this.allbookingsview.AllowUserToDeleteRows = false;
            this.allbookingsview.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.allbookingsview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allbookingsview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allbookingsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allbookingsview.DefaultCellStyle = dataGridViewCellStyle2;
            this.allbookingsview.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.allbookingsview.Location = new System.Drawing.Point(379, 120);
            this.allbookingsview.Name = "allbookingsview";
            this.allbookingsview.ReadOnly = true;
            this.allbookingsview.RowHeadersWidth = 51;
            this.allbookingsview.RowTemplate.Height = 24;
            this.allbookingsview.Size = new System.Drawing.Size(453, 450);
            this.allbookingsview.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "All bookings";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 608);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(103, 36);
            this.backbtn.TabIndex = 51;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // eventinput
            // 
            this.eventinput.FormattingEnabled = true;
            this.eventinput.Location = new System.Drawing.Point(33, 147);
            this.eventinput.Name = "eventinput";
            this.eventinput.Size = new System.Drawing.Size(283, 28);
            this.eventinput.TabIndex = 52;
            this.eventinput.SelectedIndexChanged += new System.EventHandler(this.eventinput_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Select Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Select User";
            // 
            // userinput
            // 
            this.userinput.FormattingEnabled = true;
            this.userinput.Location = new System.Drawing.Point(160, 198);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(156, 28);
            this.userinput.TabIndex = 55;
            // 
            // filterbtn
            // 
            this.filterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.filterbtn.ForeColor = System.Drawing.Color.Black;
            this.filterbtn.Location = new System.Drawing.Point(86, 253);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(146, 38);
            this.filterbtn.TabIndex = 56;
            this.filterbtn.Text = "Filter";
            this.filterbtn.UseVisualStyleBackColor = true;
            this.filterbtn.Click += new System.EventHandler(this.filterbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.refreshbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshbtn.Location = new System.Drawing.Point(532, 585);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(146, 38);
            this.refreshbtn.TabIndex = 57;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // addParticipantsbtn
            // 
            this.addParticipantsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.addParticipantsbtn.ForeColor = System.Drawing.Color.Black;
            this.addParticipantsbtn.Location = new System.Drawing.Point(68, 383);
            this.addParticipantsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addParticipantsbtn.Name = "addParticipantsbtn";
            this.addParticipantsbtn.Size = new System.Drawing.Size(222, 64);
            this.addParticipantsbtn.TabIndex = 58;
            this.addParticipantsbtn.Text = "Create Booking";
            this.addParticipantsbtn.UseVisualStyleBackColor = true;
            this.addParticipantsbtn.Click += new System.EventHandler(this.addParticipantsbtn_Click);
            // 
            // removeParticipantsbtn
            // 
            this.removeParticipantsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.removeParticipantsbtn.ForeColor = System.Drawing.Color.Black;
            this.removeParticipantsbtn.Location = new System.Drawing.Point(68, 477);
            this.removeParticipantsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeParticipantsbtn.Name = "removeParticipantsbtn";
            this.removeParticipantsbtn.Size = new System.Drawing.Size(222, 62);
            this.removeParticipantsbtn.TabIndex = 59;
            this.removeParticipantsbtn.Text = "Remove Booking";
            this.removeParticipantsbtn.UseVisualStyleBackColor = true;
            this.removeParticipantsbtn.Click += new System.EventHandler(this.removeParticipantsbtn_Click);
            // 
            // viewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 656);
            this.Controls.Add(this.removeParticipantsbtn);
            this.Controls.Add(this.addParticipantsbtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.filterbtn);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventinput);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allbookingsview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewBookings";
            this.Text = "viewBookings";
            this.Load += new System.EventHandler(this.viewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allbookingsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allbookingsview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox eventinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userinput;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button addParticipantsbtn;
        private System.Windows.Forms.Button removeParticipantsbtn;
    }
}