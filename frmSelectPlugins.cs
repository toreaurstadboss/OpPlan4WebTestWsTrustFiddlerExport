using Fiddler.WebTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Fiddler
{
	public class frmSelectPlugins : Form
	{
		private Button btnOk;

		private Button btnCancel;

		private CheckedListBox chkListPlugins;

		private List<PluginClassReference> m_AvailablePlugins;

		private List<PluginClassReference> m_SelectedPlugins;

		internal CheckBox cbAllowAutoComments;
        internal CheckBox cbWebTestCredentials;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbDomainName;
        private TextBox tbOpPlanRole;
        private TextBox tbAuthorizedForOrganization;
        private Label label1;
        private Label lblUsername;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAuthorizedForOrganization;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox tbDisplayName;
        private Label lblDisplayName;
        private System.ComponentModel.Container components;

		internal List<PluginClassReference> SelectedPlugins
		{
			get
			{
				return this.m_SelectedPlugins;
			}
			set
			{
				this.m_SelectedPlugins = value;
			}
		}

		internal frmSelectPlugins(List<PluginClassReference> AvailablePlugins)
		{
			this.InitializeComponent();
			this.m_AvailablePlugins = AvailablePlugins;
			this.PopulateListView();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.m_SelectedPlugins = new List<PluginClassReference>();
			foreach (PluginClassReference pluginRef in this.chkListPlugins.CheckedItems)
			{
				this.m_SelectedPlugins.Add(pluginRef);
			}
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPlugins));
            this.chkListPlugins = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAllowAutoComments = new System.Windows.Forms.CheckBox();
            this.cbWebTestCredentials = new System.Windows.Forms.CheckBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.tbOpPlanRole = new System.Windows.Forms.TextBox();
            this.tbAuthorizedForOrganization = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAuthorizedForOrganization = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkListPlugins
            // 
            this.chkListPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListPlugins.CheckOnClick = true;
            this.chkListPlugins.Location = new System.Drawing.Point(3, 16);
            this.chkListPlugins.Name = "chkListPlugins";
            this.chkListPlugins.Size = new System.Drawing.Size(858, 169);
            this.chkListPlugins.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(710, 444);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(791, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            // 
            // cbAllowAutoComments
            // 
            this.cbAllowAutoComments.AutoSize = true;
            this.cbAllowAutoComments.Checked = true;
            this.cbAllowAutoComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowAutoComments.Location = new System.Drawing.Point(12, 159);
            this.cbAllowAutoComments.Name = "cbAllowAutoComments";
            this.cbAllowAutoComments.Size = new System.Drawing.Size(187, 17);
            this.cbAllowAutoComments.TabIndex = 3;
            this.cbAllowAutoComments.Text = "&Include AutoGenerated comments";
            this.cbAllowAutoComments.UseVisualStyleBackColor = true;
            // 
            // cbWebTestCredentials
            // 
            this.cbWebTestCredentials.AutoSize = true;
            this.cbWebTestCredentials.Checked = true;
            this.cbWebTestCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWebTestCredentials.Location = new System.Drawing.Point(20, 198);
            this.cbWebTestCredentials.Name = "cbWebTestCredentials";
            this.cbWebTestCredentials.Size = new System.Drawing.Size(450, 22);
            this.cbWebTestCredentials.TabIndex = 4;
            this.cbWebTestCredentials.Text = "&Include authorized OpPlan 4 WebTest Plugin credentials below";
            this.cbWebTestCredentials.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(210, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(339, 25);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.Text = "u282";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(210, 58);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(339, 25);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "somepassword";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(210, 84);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(339, 25);
            this.tbDomainName.TabIndex = 7;
            this.tbDomainName.Text = "HELSEMN";
            // 
            // tbOpPlanRole
            // 
            this.tbOpPlanRole.Location = new System.Drawing.Point(210, 110);
            this.tbOpPlanRole.Name = "tbOpPlanRole";
            this.tbOpPlanRole.Size = new System.Drawing.Size(339, 25);
            this.tbOpPlanRole.TabIndex = 8;
            this.tbOpPlanRole.Text = "RessursAdministrator";
            // 
            // tbAuthorizedForOrganization
            // 
            this.tbAuthorizedForOrganization.Location = new System.Drawing.Point(210, 136);
            this.tbAuthorizedForOrganization.Name = "tbAuthorizedForOrganization";
            this.tbAuthorizedForOrganization.Size = new System.Drawing.Size(339, 25);
            this.tbAuthorizedForOrganization.TabIndex = 9;
            this.tbAuthorizedForOrganization.Text = "AuthorizedForOrganization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 18);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Domain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "AuthorizedForRole";
            // 
            // lblAuthorizedForOrganization
            // 
            this.lblAuthorizedForOrganization.AutoSize = true;
            this.lblAuthorizedForOrganization.Location = new System.Drawing.Point(17, 139);
            this.lblAuthorizedForOrganization.Name = "lblAuthorizedForOrganization";
            this.lblAuthorizedForOrganization.Size = new System.Drawing.Size(187, 18);
            this.lblAuthorizedForOrganization.TabIndex = 15;
            this.lblAuthorizedForOrganization.Text = "AuthorizedForOrganization";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.tbDisplayName);
            this.groupBox1.Controls.Add(this.lblDisplayName);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblAuthorizedForOrganization);
            this.groupBox1.Controls.Add(this.cbWebTestCredentials);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDomainName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbOpPlanRole);
            this.groupBox1.Controls.Add(this.tbAuthorizedForOrganization);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure credentials for WebTest against Sts (adjust)";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(210, 167);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(339, 25);
            this.tbDisplayName.TabIndex = 17;
            this.tbDisplayName.Text = "Kursbruker U28X, KA";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(17, 170);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(96, 18);
            this.lblDisplayName.TabIndex = 16;
            this.lblDisplayName.Text = "DisplayName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 247);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmSelectPlugins
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(876, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllowAutoComments);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkListPlugins);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "frmSelectPlugins";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Plugins for OpPan 4 Web Test Samltoken parameterized Plug-in v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
 
        public static void SafeInvoke(Control uiElement, Action updater, bool forceSynchronous)
        {
            if (uiElement == null)
            {
                throw new ArgumentNullException("uiElement");
            }

            if (uiElement.InvokeRequired)
            {
                if (forceSynchronous)
                {
                    uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                }
                else
                {
                    uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                }
            }
            else
            {
                if (uiElement.IsDisposed)
                {
                    throw new ObjectDisposedException("Control is already disposed.");
                }

                updater();
            }
        }

        public CheckBox IsWebTestCredentialsDefined
	    {
	        get { return this.cbWebTestCredentials; }
	        set { cbWebTestCredentials = value; }
	    }

	    public TextBox TbUsername
	    {
	        get { return this.tbUsername; }
	        set { tbUsername = value; }
	    }

	    public TextBox TbPassword
	    {
	        get { return this.tbPassword; }
	        set { tbPassword = value; }
	    }


	    public TextBox TbDomainName
	    {
	        get { return this.tbDomainName; }
	        set { tbDomainName = value; }
	    }


	    public TextBox TbAuthorizedRole
	    {
	        get { return this.tbOpPlanRole; }
	        set { tbOpPlanRole = value; }
	    }

	    public TextBox TbAuthorizedForOrganization
	    {
	        get { return this.tbAuthorizedForOrganization; }
	        set { tbAuthorizedForOrganization = value; }
	    }

	    public TextBox TbDisplayName
	    {
	        get { return this.tbDisplayName; }
	        set { this.tbDisplayName = value; }
	    }

        private void PopulateListView()
		{
			foreach (PluginClassReference pluginRef in this.m_AvailablePlugins)
			{
				this.chkListPlugins.Items.Add(pluginRef, true);
			}
		}
	}
}