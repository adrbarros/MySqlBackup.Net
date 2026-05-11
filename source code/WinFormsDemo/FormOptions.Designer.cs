namespace WinFormsDemo
{
    partial class FormOptions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.pgExport = new System.Windows.Forms.PropertyGrid();
            this.btResetExport = new System.Windows.Forms.Button();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.pgImport = new System.Windows.Forms.PropertyGrid();
            this.btResetImport = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabExport);
            this.tabControl1.Controls.Add(this.tabImport);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 540);
            this.tabControl1.TabIndex = 0;
            //
            // tabExport
            //
            this.tabExport.Controls.Add(this.pgExport);
            this.tabExport.Controls.Add(this.btResetExport);
            this.tabExport.Location = new System.Drawing.Point(4, 25);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(652, 511);
            this.tabExport.TabIndex = 0;
            this.tabExport.Text = "Export Options";
            this.tabExport.UseVisualStyleBackColor = true;
            //
            // pgExport
            //
            this.pgExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgExport.Location = new System.Drawing.Point(6, 6);
            this.pgExport.Name = "pgExport";
            this.pgExport.Size = new System.Drawing.Size(640, 460);
            this.pgExport.TabIndex = 0;
            //
            // btResetExport
            //
            this.btResetExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btResetExport.Location = new System.Drawing.Point(6, 475);
            this.btResetExport.Name = "btResetExport";
            this.btResetExport.Size = new System.Drawing.Size(150, 30);
            this.btResetExport.TabIndex = 1;
            this.btResetExport.Text = "Reset to Defaults";
            this.btResetExport.UseVisualStyleBackColor = true;
            this.btResetExport.Click += new System.EventHandler(this.btResetExport_Click);
            //
            // tabImport
            //
            this.tabImport.Controls.Add(this.pgImport);
            this.tabImport.Controls.Add(this.btResetImport);
            this.tabImport.Location = new System.Drawing.Point(4, 25);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(652, 511);
            this.tabImport.TabIndex = 1;
            this.tabImport.Text = "Import Options";
            this.tabImport.UseVisualStyleBackColor = true;
            //
            // pgImport
            //
            this.pgImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgImport.Location = new System.Drawing.Point(6, 6);
            this.pgImport.Name = "pgImport";
            this.pgImport.Size = new System.Drawing.Size(640, 460);
            this.pgImport.TabIndex = 0;
            //
            // btResetImport
            //
            this.btResetImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btResetImport.Location = new System.Drawing.Point(6, 475);
            this.btResetImport.Name = "btResetImport";
            this.btResetImport.Size = new System.Drawing.Size(150, 30);
            this.btResetImport.TabIndex = 1;
            this.btResetImport.Text = "Reset to Defaults";
            this.btResetImport.UseVisualStyleBackColor = true;
            this.btResetImport.Click += new System.EventHandler(this.btResetImport_Click);
            //
            // btOK
            //
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Location = new System.Drawing.Point(478, 562);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(90, 30);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            //
            // btCancel
            //
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(582, 562);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 30);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            //
            // FormOptions
            //
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(684, 604);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup / Restore Options";
            this.tabControl1.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.PropertyGrid pgExport;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.PropertyGrid pgImport;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btResetExport;
        private System.Windows.Forms.Button btResetImport;
    }
}
