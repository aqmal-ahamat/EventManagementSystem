namespace EventManagementSystem
{
    partial class viewAvailableEvents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterEventsbtn = new System.Windows.Forms.Button();
            this.alleventsgrid = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alleventsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Events";
            // 
            // RegisterEventsbtn
            // 
            this.RegisterEventsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEventsbtn.Location = new System.Drawing.Point(744, 519);
            this.RegisterEventsbtn.Name = "RegisterEventsbtn";
            this.RegisterEventsbtn.Size = new System.Drawing.Size(167, 65);
            this.RegisterEventsbtn.TabIndex = 10;
            this.RegisterEventsbtn.Text = "Register for an event";
            this.RegisterEventsbtn.UseVisualStyleBackColor = true;
            this.RegisterEventsbtn.Click += new System.EventHandler(this.RegisterEventsbtn_Click);
            // 
            // alleventsgrid
            // 
            this.alleventsgrid.AllowUserToAddRows = false;
            this.alleventsgrid.AllowUserToDeleteRows = false;
            this.alleventsgrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.alleventsgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alleventsgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alleventsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alleventsgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.alleventsgrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.alleventsgrid.Location = new System.Drawing.Point(45, 68);
            this.alleventsgrid.Name = "alleventsgrid";
            this.alleventsgrid.ReadOnly = true;
            this.alleventsgrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alleventsgrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.alleventsgrid.RowTemplate.Height = 24;
            this.alleventsgrid.Size = new System.Drawing.Size(987, 423);
            this.alleventsgrid.TabIndex = 11;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(169, 529);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(167, 65);
            this.backbtn.TabIndex = 13;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(472, 497);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(125, 51);
            this.refreshbtn.TabIndex = 14;
            this.refreshbtn.Text = "Refresh table";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // viewAvailableEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 631);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.alleventsgrid);
            this.Controls.Add(this.RegisterEventsbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewAvailableEvents";
            this.Text = "viewAvailableEvents";
            this.Load += new System.EventHandler(this.viewAvailableEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alleventsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterEventsbtn;
        private System.Windows.Forms.DataGridView alleventsgrid;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}