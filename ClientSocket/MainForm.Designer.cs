namespace ClientSocket
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtServerMsg = new System.Windows.Forms.TextBox();
            this.txtClientMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 219);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(372, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send To Server";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 13);
            this.lblHeader.TabIndex = 1;
            // 
            // txtServerMsg
            // 
            this.txtServerMsg.Location = new System.Drawing.Point(16, 48);
            this.txtServerMsg.Multiline = true;
            this.txtServerMsg.Name = "txtServerMsg";
            this.txtServerMsg.Size = new System.Drawing.Size(372, 165);
            this.txtServerMsg.TabIndex = 2;
            // 
            // txtClientMessage
            // 
            this.txtClientMessage.Location = new System.Drawing.Point(16, 261);
            this.txtClientMessage.Multiline = true;
            this.txtClientMessage.Name = "txtClientMessage";
            this.txtClientMessage.Size = new System.Drawing.Size(372, 195);
            this.txtClientMessage.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 468);
            this.Controls.Add(this.txtClientMessage);
            this.Controls.Add(this.txtServerMsg);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSend);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtServerMsg;
        private System.Windows.Forms.TextBox txtClientMessage;
    }
}