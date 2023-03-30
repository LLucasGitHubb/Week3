namespace Client
{
    partial class client
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
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ipad = new System.Windows.Forms.TextBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_ipad = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.lv_messageclient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_port.Location = new System.Drawing.Point(466, 49);
            this.tb_port.Multiline = true;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(139, 30);
            this.tb_port.TabIndex = 8;
            this.tb_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ipad
            // 
            this.tb_ipad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ipad.Location = new System.Drawing.Point(134, 49);
            this.tb_ipad.Multiline = true;
            this.tb_ipad.Name = "tb_ipad";
            this.tb_ipad.Size = new System.Drawing.Size(135, 30);
            this.tb_ipad.TabIndex = 7;
            this.tb_ipad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_port.Location = new System.Drawing.Point(408, 56);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(52, 23);
            this.lb_port.TabIndex = 6;
            this.lb_port.Text = "Port ";
            // 
            // lb_ipad
            // 
            this.lb_ipad.AutoSize = true;
            this.lb_ipad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ipad.Location = new System.Drawing.Point(23, 56);
            this.lb_ipad.Name = "lb_ipad";
            this.lb_ipad.Size = new System.Drawing.Size(105, 23);
            this.lb_ipad.TabIndex = 5;
            this.lb_ipad.Text = "IP Address ";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(27, 366);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(577, 58);
            this.tb_message.TabIndex = 9;
            // 
            // bt_send
            // 
            this.bt_send.AutoSize = true;
            this.bt_send.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_send.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(630, 394);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(80, 30);
            this.bt_send.TabIndex = 11;
            this.bt_send.Text = "Send ";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // lv_messageclient
            // 
            this.lv_messageclient.HideSelection = false;
            this.lv_messageclient.Location = new System.Drawing.Point(27, 121);
            this.lv_messageclient.Name = "lv_messageclient";
            this.lv_messageclient.Size = new System.Drawing.Size(578, 239);
            this.lv_messageclient.TabIndex = 12;
            this.lv_messageclient.UseCompatibleStateImageBehavior = false;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_messageclient);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ipad);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_ipad);
            this.Name = "client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ipad;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_ipad;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.ListView lv_messageclient;
    }
}

