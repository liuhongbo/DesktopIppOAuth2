namespace DesktopIppOAuthSample
{
    partial class FormMain
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxClientSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccessTokenExpiresIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRealmId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccessToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRefreshToken = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRedirectUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEnvironment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxState2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(142, 205);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(207, 42);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(142, 38);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(284, 20);
            this.textBoxClientID.TabIndex = 2;
            // 
            // textBoxClientSecret
            // 
            this.textBoxClientSecret.Location = new System.Drawing.Point(142, 70);
            this.textBoxClientSecret.Name = "textBoxClientSecret";
            this.textBoxClientSecret.Size = new System.Drawing.Size(284, 20);
            this.textBoxClientSecret.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Secret";
            // 
            // textBoxAccessTokenExpiresIn
            // 
            this.textBoxAccessTokenExpiresIn.Location = new System.Drawing.Point(142, 355);
            this.textBoxAccessTokenExpiresIn.Name = "textBoxAccessTokenExpiresIn";
            this.textBoxAccessTokenExpiresIn.Size = new System.Drawing.Size(284, 20);
            this.textBoxAccessTokenExpiresIn.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Access Token ExpiresIn";
            // 
            // textBoxRealmId
            // 
            this.textBoxRealmId.Location = new System.Drawing.Point(142, 262);
            this.textBoxRealmId.Name = "textBoxRealmId";
            this.textBoxRealmId.Size = new System.Drawing.Size(284, 20);
            this.textBoxRealmId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Realm Id";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Location = new System.Drawing.Point(142, 293);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(423, 20);
            this.textBoxAccessToken.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Access Token";
            // 
            // textBoxRefreshToken
            // 
            this.textBoxRefreshToken.Location = new System.Drawing.Point(142, 324);
            this.textBoxRefreshToken.Name = "textBoxRefreshToken";
            this.textBoxRefreshToken.Size = new System.Drawing.Size(423, 20);
            this.textBoxRefreshToken.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Refresh Token";
            // 
            // textBoxRedirectUrl
            // 
            this.textBoxRedirectUrl.Location = new System.Drawing.Point(143, 101);
            this.textBoxRedirectUrl.Name = "textBoxRedirectUrl";
            this.textBoxRedirectUrl.Size = new System.Drawing.Size(284, 20);
            this.textBoxRedirectUrl.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Redirect Url";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(143, 133);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(284, 20);
            this.textBoxState.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "State";
            // 
            // textBoxEnvironment
            // 
            this.textBoxEnvironment.Location = new System.Drawing.Point(144, 166);
            this.textBoxEnvironment.Name = "textBoxEnvironment";
            this.textBoxEnvironment.Size = new System.Drawing.Size(284, 20);
            this.textBoxEnvironment.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "environment";
            // 
            // textBoxState2
            // 
            this.textBoxState2.Location = new System.Drawing.Point(142, 388);
            this.textBoxState2.Name = "textBoxState2";
            this.textBoxState2.Size = new System.Drawing.Size(284, 20);
            this.textBoxState2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "State";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(142, 422);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(284, 20);
            this.textBoxError.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Error";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 461);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxState2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEnvironment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRedirectUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRefreshToken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAccessToken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAccessTokenExpiresIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRealmId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxClientSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Name = "FormMain";
            this.Text = "Desktop Ipp OAuth2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxClientSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccessTokenExpiresIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRealmId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAccessToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRefreshToken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRedirectUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEnvironment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxState2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Label label11;
    }
}

