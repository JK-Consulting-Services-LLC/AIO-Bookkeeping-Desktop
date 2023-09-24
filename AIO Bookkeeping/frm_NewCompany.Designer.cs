namespace AIO_Bookkeeping
{
    partial class frm_NewCompany
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
            tabControl1 = new TabControl();
            tbp_CompanyInfo = new TabPage();
            btn_SaveNewCompany = new Button();
            btn_Cancel = new Button();
            txt_CompanyName = new TextBox();
            lbl_CompanyName = new Label();
            tabControl1.SuspendLayout();
            tbp_CompanyInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbp_CompanyInfo);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tbp_CompanyInfo
            // 
            tbp_CompanyInfo.Controls.Add(btn_SaveNewCompany);
            tbp_CompanyInfo.Controls.Add(btn_Cancel);
            tbp_CompanyInfo.Controls.Add(txt_CompanyName);
            tbp_CompanyInfo.Controls.Add(lbl_CompanyName);
            tbp_CompanyInfo.Location = new Point(4, 24);
            tbp_CompanyInfo.Name = "tbp_CompanyInfo";
            tbp_CompanyInfo.Padding = new Padding(3);
            tbp_CompanyInfo.Size = new Size(792, 422);
            tbp_CompanyInfo.TabIndex = 0;
            tbp_CompanyInfo.Text = "Company Info";
            tbp_CompanyInfo.UseVisualStyleBackColor = true;
            // 
            // btn_SaveNewCompany
            // 
            btn_SaveNewCompany.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SaveNewCompany.Location = new Point(570, 391);
            btn_SaveNewCompany.Name = "btn_SaveNewCompany";
            btn_SaveNewCompany.Size = new Size(104, 23);
            btn_SaveNewCompany.TabIndex = 3;
            btn_SaveNewCompany.Text = "Create Company";
            btn_SaveNewCompany.UseVisualStyleBackColor = true;
            btn_SaveNewCompany.Click += btn_SaveNewCompany_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cancel.Location = new Point(680, 391);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(104, 23);
            btn_Cancel.TabIndex = 2;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // txt_CompanyName
            // 
            txt_CompanyName.Location = new Point(112, 6);
            txt_CompanyName.Name = "txt_CompanyName";
            txt_CompanyName.Size = new Size(270, 23);
            txt_CompanyName.TabIndex = 1;
            // 
            // lbl_CompanyName
            // 
            lbl_CompanyName.AutoSize = true;
            lbl_CompanyName.Location = new Point(6, 9);
            lbl_CompanyName.Name = "lbl_CompanyName";
            lbl_CompanyName.Size = new Size(100, 15);
            lbl_CompanyName.TabIndex = 0;
            lbl_CompanyName.Text = "Company Name: ";
            // 
            // frm_NewCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frm_NewCompany";
            Text = "New Company";
            tabControl1.ResumeLayout(false);
            tbp_CompanyInfo.ResumeLayout(false);
            tbp_CompanyInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbp_CompanyInfo;
        private Button btn_SaveNewCompany;
        private Button btn_Cancel;
        private TextBox txt_CompanyName;
        private Label lbl_CompanyName;
    }
}