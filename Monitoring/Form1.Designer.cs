namespace Monitoring
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
            this.usrnmbox = new System.Windows.Forms.TextBox();
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.submitbttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delaybox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usrsfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usrchcklbl = new System.Windows.Forms.Label();
            this.filelbl = new System.Windows.Forms.Label();
            this.loglbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usrnmbox
            // 
            this.usrnmbox.Location = new System.Drawing.Point(232, 74);
            this.usrnmbox.Name = "usrnmbox";
            this.usrnmbox.Size = new System.Drawing.Size(246, 20);
            this.usrnmbox.TabIndex = 0;
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(232, 134);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.PasswordChar = '*';
            this.passwdbox.Size = new System.Drawing.Size(246, 20);
            this.passwdbox.TabIndex = 1;
            // 
            // submitbttn
            // 
            this.submitbttn.Location = new System.Drawing.Point(232, 343);
            this.submitbttn.Name = "submitbttn";
            this.submitbttn.Size = new System.Drawing.Size(75, 23);
            this.submitbttn.TabIndex = 2;
            this.submitbttn.Text = "Start Monitoring";
            this.submitbttn.UseVisualStyleBackColor = true;
            this.submitbttn.Click += new System.EventHandler(this.submitbttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(104, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(102, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(45, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DELAY (IN SECONDS)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(102, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "USERS FILE";
            // 
            // delaybox
            // 
            this.delaybox.Location = new System.Drawing.Point(232, 192);
            this.delaybox.Name = "delaybox";
            this.delaybox.Size = new System.Drawing.Size(246, 20);
            this.delaybox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usrsfiledialog
            // 
            this.usrsfiledialog.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 574);
            this.dataGridView1.TabIndex = 14;
            // 
            // usrchcklbl
            // 
            this.usrchcklbl.AutoSize = true;
            this.usrchcklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrchcklbl.Location = new System.Drawing.Point(639, 49);
            this.usrchcklbl.Name = "usrchcklbl";
            this.usrchcklbl.Size = new System.Drawing.Size(0, 13);
            this.usrchcklbl.TabIndex = 15;
            // 
            // filelbl
            // 
            this.filelbl.AutoSize = true;
            this.filelbl.Location = new System.Drawing.Point(333, 250);
            this.filelbl.MaximumSize = new System.Drawing.Size(140, 0);
            this.filelbl.Name = "filelbl";
            this.filelbl.Size = new System.Drawing.Size(0, 13);
            this.filelbl.TabIndex = 16;
            // 
            // loglbl
            // 
            this.loglbl.AutoSize = true;
            this.loglbl.Location = new System.Drawing.Point(232, 407);
            this.loglbl.Name = "loglbl";
            this.loglbl.Size = new System.Drawing.Size(0, 13);
            this.loglbl.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.loglbl);
            this.Controls.Add(this.filelbl);
            this.Controls.Add(this.usrchcklbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delaybox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbttn);
            this.Controls.Add(this.passwdbox);
            this.Controls.Add(this.usrnmbox);
            this.Name = "Form1";
            this.Text = "Instagram Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrnmbox;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Button submitbttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delaybox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog usrsfiledialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label usrchcklbl;
        private System.Windows.Forms.Label filelbl;
        private System.Windows.Forms.Label loglbl;
    }
}

