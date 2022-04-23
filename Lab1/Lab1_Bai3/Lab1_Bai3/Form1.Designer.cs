
namespace Lab1_Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDanhSachIP = new System.Windows.Forms.TextBox();
            this.txtTenMien = new System.Windows.Forms.TextBox();
            this.btnPhanGiai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDefaultGateway = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtIPv4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDanhSachIP);
            this.groupBox1.Controls.Add(this.txtTenMien);
            this.groupBox1.Controls.Add(this.btnPhanGiai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PhanGiaiTenMien";
            // 
            // txtDanhSachIP
            // 
            this.txtDanhSachIP.Location = new System.Drawing.Point(140, 63);
            this.txtDanhSachIP.Name = "txtDanhSachIP";
            this.txtDanhSachIP.ReadOnly = true;
            this.txtDanhSachIP.Size = new System.Drawing.Size(210, 20);
            this.txtDanhSachIP.TabIndex = 4;
            // 
            // txtTenMien
            // 
            this.txtTenMien.Location = new System.Drawing.Point(140, 30);
            this.txtTenMien.Name = "txtTenMien";
            this.txtTenMien.Size = new System.Drawing.Size(210, 20);
            this.txtTenMien.TabIndex = 3;
            // 
            // btnPhanGiai
            // 
            this.btnPhanGiai.Location = new System.Drawing.Point(140, 98);
            this.btnPhanGiai.Name = "btnPhanGiai";
            this.btnPhanGiai.Size = new System.Drawing.Size(112, 23);
            this.btnPhanGiai.TabIndex = 2;
            this.btnPhanGiai.Text = "Phan Giai Ten Mien";
            this.btnPhanGiai.UseVisualStyleBackColor = true;
            this.btnPhanGiai.Click += new System.EventHandler(this.btnPhanGiai_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Mien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia chi IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDefaultGateway);
            this.groupBox2.Controls.Add(this.txtSubnetMask);
            this.groupBox2.Controls.Add(this.txtIPv4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ThongTinLocalHost";
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.Location = new System.Drawing.Point(140, 127);
            this.txtDefaultGateway.Name = "txtDefaultGateway";
            this.txtDefaultGateway.Size = new System.Drawing.Size(210, 20);
            this.txtDefaultGateway.TabIndex = 6;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(140, 83);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(210, 20);
            this.txtSubnetMask.TabIndex = 5;
            // 
            // txtIPv4
            // 
            this.txtIPv4.Location = new System.Drawing.Point(140, 36);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.Size = new System.Drawing.Size(210, 20);
            this.txtIPv4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DefaultGateway";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SubnetMask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IPV4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDanhSachIP;
        private System.Windows.Forms.TextBox txtTenMien;
        private System.Windows.Forms.Button btnPhanGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDefaultGateway;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtIPv4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

