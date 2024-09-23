namespace EventManagementSystem
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.Label();
            this.roletxt = new System.Windows.Forms.Label();
            this.myeventsview = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.unregisterbtn = new System.Windows.Forms.Button();
            this.viewEventsbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.RegisterEventsbtn = new System.Windows.Forms.Button();
            this.createEventbtn = new System.Windows.Forms.Button();
            this.editEventbtn = new System.Windows.Forms.Button();
            this.deleteEventbtn = new System.Windows.Forms.Button();
            this.viewBookingsbtn = new System.Windows.Forms.Button();
            this.addAdminbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myeventsview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 42F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // usernametxt
            // 
            this.usernametxt.AutoSize = true;
            this.usernametxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usernametxt.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold);
            this.usernametxt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usernametxt.Location = new System.Drawing.Point(1259, 11);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(245, 55);
            this.usernametxt.TabIndex = 1;
            this.usernametxt.Text = "Username";
            this.usernametxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roletxt
            // 
            this.roletxt.AutoSize = true;
            this.roletxt.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.roletxt.ForeColor = System.Drawing.Color.Red;
            this.roletxt.Location = new System.Drawing.Point(1272, 68);
            this.roletxt.Name = "roletxt";
            this.roletxt.Size = new System.Drawing.Size(47, 22);
            this.roletxt.TabIndex = 2;
            this.roletxt.Text = "Role";
            this.roletxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myeventsview
            // 
            this.myeventsview.AllowUserToAddRows = false;
            this.myeventsview.AllowUserToDeleteRows = false;
            this.myeventsview.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myeventsview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myeventsview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.myeventsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myeventsview.DefaultCellStyle = dataGridViewCellStyle58;
            this.myeventsview.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myeventsview.Location = new System.Drawing.Point(256, 191);
            this.myeventsview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myeventsview.Name = "myeventsview";
            this.myeventsview.ReadOnly = true;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myeventsview.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.myeventsview.RowHeadersWidth = 51;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myeventsview.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.myeventsview.RowTemplate.Height = 24;
            this.myeventsview.Size = new System.Drawing.Size(1132, 464);
            this.myeventsview.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(256, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "My Events";
            // 
            // unregisterbtn
            // 
            this.unregisterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unregisterbtn.Location = new System.Drawing.Point(1109, 721);
            this.unregisterbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unregisterbtn.Name = "unregisterbtn";
            this.unregisterbtn.Size = new System.Drawing.Size(243, 71);
            this.unregisterbtn.TabIndex = 5;
            this.unregisterbtn.Text = "Unregister";
            this.unregisterbtn.UseVisualStyleBackColor = true;
            this.unregisterbtn.Click += new System.EventHandler(this.unregisterbtn_Click);
            // 
            // viewEventsbtn
            // 
            this.viewEventsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEventsbtn.Location = new System.Drawing.Point(682, 732);
            this.viewEventsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewEventsbtn.Name = "viewEventsbtn";
            this.viewEventsbtn.Size = new System.Drawing.Size(316, 73);
            this.viewEventsbtn.TabIndex = 6;
            this.viewEventsbtn.Text = "View available events";
            this.viewEventsbtn.UseVisualStyleBackColor = true;
            this.viewEventsbtn.Click += new System.EventHandler(this.viewEventsbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(12, 780);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(120, 43);
            this.logoutbtn.TabIndex = 7;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // RegisterEventsbtn
            // 
            this.RegisterEventsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEventsbtn.Location = new System.Drawing.Point(310, 721);
            this.RegisterEventsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterEventsbtn.Name = "RegisterEventsbtn";
            this.RegisterEventsbtn.Size = new System.Drawing.Size(253, 73);
            this.RegisterEventsbtn.TabIndex = 8;
            this.RegisterEventsbtn.Text = "Register for an event";
            this.RegisterEventsbtn.UseVisualStyleBackColor = true;
            this.RegisterEventsbtn.Click += new System.EventHandler(this.RegisterEventsbtn_Click);
            // 
            // createEventbtn
            // 
            this.createEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventbtn.Location = new System.Drawing.Point(58, 231);
            this.createEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createEventbtn.Name = "createEventbtn";
            this.createEventbtn.Size = new System.Drawing.Size(131, 96);
            this.createEventbtn.TabIndex = 9;
            this.createEventbtn.Text = "Create event";
            this.createEventbtn.UseVisualStyleBackColor = true;
            this.createEventbtn.Click += new System.EventHandler(this.createEventbtn_Click);
            // 
            // editEventbtn
            // 
            this.editEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventbtn.Location = new System.Drawing.Point(58, 378);
            this.editEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editEventbtn.Name = "editEventbtn";
            this.editEventbtn.Size = new System.Drawing.Size(131, 92);
            this.editEventbtn.TabIndex = 10;
            this.editEventbtn.Text = "Edit event";
            this.editEventbtn.UseVisualStyleBackColor = true;
            this.editEventbtn.Click += new System.EventHandler(this.editEventbtn_Click);
            // 
            // deleteEventbtn
            // 
            this.deleteEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventbtn.Location = new System.Drawing.Point(58, 526);
            this.deleteEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEventbtn.Name = "deleteEventbtn";
            this.deleteEventbtn.Size = new System.Drawing.Size(131, 92);
            this.deleteEventbtn.TabIndex = 11;
            this.deleteEventbtn.Text = "Delete event";
            this.deleteEventbtn.UseVisualStyleBackColor = true;
            this.deleteEventbtn.Click += new System.EventHandler(this.deleteEventbtn_Click);
            // 
            // viewBookingsbtn
            // 
            this.viewBookingsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.viewBookingsbtn.ForeColor = System.Drawing.Color.Black;
            this.viewBookingsbtn.Location = new System.Drawing.Point(587, 100);
            this.viewBookingsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBookingsbtn.Name = "viewBookingsbtn";
            this.viewBookingsbtn.Size = new System.Drawing.Size(191, 62);
            this.viewBookingsbtn.TabIndex = 12;
            this.viewBookingsbtn.Text = "Manage all bookings";
            this.viewBookingsbtn.UseVisualStyleBackColor = true;
            this.viewBookingsbtn.Click += new System.EventHandler(this.viewBookingsbtn_Click);
            // 
            // addAdminbtn
            // 
            this.addAdminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminbtn.Location = new System.Drawing.Point(913, 100);
            this.addAdminbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAdminbtn.Name = "addAdminbtn";
            this.addAdminbtn.Size = new System.Drawing.Size(191, 62);
            this.addAdminbtn.TabIndex = 15;
            this.addAdminbtn.Text = "Add Admins and Organizers";
            this.addAdminbtn.UseVisualStyleBackColor = true;
            this.addAdminbtn.Click += new System.EventHandler(this.addAdminbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.refreshbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshbtn.Location = new System.Drawing.Point(772, 659);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(136, 43);
            this.refreshbtn.TabIndex = 16;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1516, 887);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.addAdminbtn);
            this.Controls.Add(this.viewBookingsbtn);
            this.Controls.Add(this.deleteEventbtn);
            this.Controls.Add(this.editEventbtn);
            this.Controls.Add(this.createEventbtn);
            this.Controls.Add(this.RegisterEventsbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.viewEventsbtn);
            this.Controls.Add(this.unregisterbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myeventsview);
            this.Controls.Add(this.roletxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myeventsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernametxt;
        private System.Windows.Forms.Label roletxt;
        private System.Windows.Forms.DataGridView myeventsview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button unregisterbtn;
        private System.Windows.Forms.Button viewEventsbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button RegisterEventsbtn;
        private System.Windows.Forms.Button createEventbtn;
        private System.Windows.Forms.Button editEventbtn;
        private System.Windows.Forms.Button deleteEventbtn;
        private System.Windows.Forms.Button viewBookingsbtn;
        private System.Windows.Forms.Button addAdminbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}