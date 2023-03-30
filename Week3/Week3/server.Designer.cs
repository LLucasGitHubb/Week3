namespace Week3
{
    partial class server
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
            this.lb_port = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.lv_message = new System.Windows.Forms.ListView();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_port.Location = new System.Drawing.Point(39, 56);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(52, 23);
            this.lb_port.TabIndex = 2;
            this.lb_port.Text = "Port ";
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_port.Location = new System.Drawing.Point(86, 49);
            this.tb_port.Multiline = true;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(139, 30);
            this.tb_port.TabIndex = 4;
            this.tb_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_message
            // 
            this.lv_message.HideSelection = false;
            this.lv_message.Location = new System.Drawing.Point(43, 97);
            this.lv_message.Name = "lv_message";
            this.lv_message.Size = new System.Drawing.Size(770, 197);
            this.lv_message.TabIndex = 5;
            this.lv_message.UseCompatibleStateImageBehavior = false;
            // 
            // tb_message
            // 
            this.tb_message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.Location = new System.Drawing.Point(43, 324);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(664, 73);
            this.tb_message.TabIndex = 6;
            // 
            // bt_send
            // 
            this.bt_send.AutoSize = true;
            this.bt_send.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(738, 365);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 32);
            this.bt_send.TabIndex = 7;
            this.bt_send.Text = "Send ";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click_1);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lv_message);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.lb_port);
            this.Name = "server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.ListView lv_message;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button bt_send;
    }
}

