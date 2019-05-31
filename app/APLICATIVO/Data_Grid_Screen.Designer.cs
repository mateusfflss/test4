namespace APLICATIVO
{
    partial class Data_Grid_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Grid_Screen));
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Box_Minimize = new System.Windows.Forms.PictureBox();
            this.Pic_box_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_box_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Grid_View
            // 
            this.Data_Grid_View.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.Data_Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Grid_View.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Data_Grid_View.GridColor = System.Drawing.SystemColors.Highlight;
            this.Data_Grid_View.Location = new System.Drawing.Point(1, 59);
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.Size = new System.Drawing.Size(463, 242);
            this.Data_Grid_View.TabIndex = 0;
            this.Data_Grid_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco de Dados";
            // 
            // Pic_Box_Minimize
            // 
            this.Pic_Box_Minimize.BackColor = System.Drawing.SystemColors.Control;
            this.Pic_Box_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Box_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box_Minimize.Image")));
            this.Pic_Box_Minimize.Location = new System.Drawing.Point(415, -1);
            this.Pic_Box_Minimize.Name = "Pic_Box_Minimize";
            this.Pic_Box_Minimize.Size = new System.Drawing.Size(25, 24);
            this.Pic_Box_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box_Minimize.TabIndex = 4;
            this.Pic_Box_Minimize.TabStop = false;
            this.Pic_Box_Minimize.Click += new System.EventHandler(this.Pic_Box_Minimize_Click);
            // 
            // Pic_box_Close
            // 
            this.Pic_box_Close.BackColor = System.Drawing.SystemColors.Control;
            this.Pic_box_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_box_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pic_box_Close.Image")));
            this.Pic_box_Close.Location = new System.Drawing.Point(440, -1);
            this.Pic_box_Close.Name = "Pic_box_Close";
            this.Pic_box_Close.Size = new System.Drawing.Size(25, 24);
            this.Pic_box_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_box_Close.TabIndex = 5;
            this.Pic_box_Close.TabStop = false;
            this.Pic_box_Close.Click += new System.EventHandler(this.Pic_box_Close_Click);
            // 
            // Data_Grid_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 301);
            this.Controls.Add(this.Pic_Box_Minimize);
            this.Controls.Add(this.Pic_box_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_Grid_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data_Grid_Screen";
            this.Text = "Data_Grid_Screen";
            this.Load += new System.EventHandler(this.Data_Grid_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_box_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_Box_Minimize;
        private System.Windows.Forms.PictureBox Pic_box_Close;
    }
}