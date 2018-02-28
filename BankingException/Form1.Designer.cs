namespace BankingException
{
    partial class Form1
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
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.grpAccountActivity = new System.Windows.Forms.GroupBox();
            this.rdoWithdraw = new System.Windows.Forms.RadioButton();
            this.rdoDeposit = new System.Windows.Forms.RadioButton();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.grpAccountActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalance.Location = new System.Drawing.Point(218, 7);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(95, 26);
            this.txtAccountBalance.TabIndex = 0;
            this.txtAccountBalance.Text = "0.00";
            this.txtAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(106, 147);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(97, 23);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.Text = "0.00";
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.Enter += new System.EventHandler(this.txtDeposit_Enter);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(153, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance";
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(44, 150);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(56, 17);
            this.lblDepositAmount.TabIndex = 5;
            this.lblDepositAmount.Text = "Amount";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(229, 142);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(84, 32);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // grpAccountActivity
            // 
            this.grpAccountActivity.Controls.Add(this.rdoWithdraw);
            this.grpAccountActivity.Controls.Add(this.rdoDeposit);
            this.grpAccountActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountActivity.Location = new System.Drawing.Point(19, 50);
            this.grpAccountActivity.Name = "grpAccountActivity";
            this.grpAccountActivity.Size = new System.Drawing.Size(294, 74);
            this.grpAccountActivity.TabIndex = 10;
            this.grpAccountActivity.TabStop = false;
            this.grpAccountActivity.Text = "AccountActivity";
            // 
            // rdoWithdraw
            // 
            this.rdoWithdraw.AutoSize = true;
            this.rdoWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWithdraw.Location = new System.Drawing.Point(171, 29);
            this.rdoWithdraw.Name = "rdoWithdraw";
            this.rdoWithdraw.Size = new System.Drawing.Size(84, 21);
            this.rdoWithdraw.TabIndex = 1;
            this.rdoWithdraw.TabStop = true;
            this.rdoWithdraw.Text = "Withdraw";
            this.rdoWithdraw.UseVisualStyleBackColor = true;
            this.rdoWithdraw.CheckedChanged += new System.EventHandler(this.rdoWithdraw_CheckedChanged);
            // 
            // rdoDeposit
            // 
            this.rdoDeposit.AutoSize = true;
            this.rdoDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDeposit.Location = new System.Drawing.Point(28, 29);
            this.rdoDeposit.Name = "rdoDeposit";
            this.rdoDeposit.Size = new System.Drawing.Size(74, 21);
            this.rdoDeposit.TabIndex = 0;
            this.rdoDeposit.TabStop = true;
            this.rdoDeposit.Text = "Deposit";
            this.rdoDeposit.UseVisualStyleBackColor = true;
            this.rdoDeposit.CheckedChanged += new System.EventHandler(this.rdoDeposit_CheckedChanged);
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorMessage.Location = new System.Drawing.Point(47, 185);
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(266, 41);
            this.txtErrorMessage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 238);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.grpAccountActivity);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.txtDeposit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAccountActivity.ResumeLayout(false);
            this.grpAccountActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.GroupBox grpAccountActivity;
        private System.Windows.Forms.RadioButton rdoWithdraw;
        private System.Windows.Forms.RadioButton rdoDeposit;
        private System.Windows.Forms.TextBox txtErrorMessage;
    }
}

