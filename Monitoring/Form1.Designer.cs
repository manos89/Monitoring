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
            this.fllowerslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.followingslbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // usrnmbox
            // 
            this.usrnmbox.Location = new System.Drawing.Point(296, 150);
            this.usrnmbox.Name = "usrnmbox";
            this.usrnmbox.Size = new System.Drawing.Size(246, 20);
            this.usrnmbox.TabIndex = 0;
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(296, 225);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.PasswordChar = '*';
            this.passwdbox.Size = new System.Drawing.Size(246, 20);
            this.passwdbox.TabIndex = 1;
            // 
            // submitbttn
            // 
            this.submitbttn.Location = new System.Drawing.Point(375, 329);
            this.submitbttn.Name = "submitbttn";
            this.submitbttn.Size = new System.Drawing.Size(75, 23);
            this.submitbttn.TabIndex = 2;
            this.submitbttn.Text = "Start Monitoring";
            this.submitbttn.UseVisualStyleBackColor = true;
            this.submitbttn.Click += new System.EventHandler(this.submitbttn_Click);
            // 
            // fllowerslbl
            // 
            this.fllowerslbl.AutoSize = true;
            this.fllowerslbl.Location = new System.Drawing.Point(763, 157);
            this.fllowerslbl.Name = "fllowerslbl";
            this.fllowerslbl.Size = new System.Drawing.Size(13, 13);
            this.fllowerslbl.TabIndex = 3;
            this.fllowerslbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(183, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(181, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(670, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FOLLOWERS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(670, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FOLLOWINGS:";
            // 
            // followingslbl
            // 
            this.followingslbl.AutoSize = true;
            this.followingslbl.Location = new System.Drawing.Point(766, 195);
            this.followingslbl.Name = "followingslbl";
            this.followingslbl.Size = new System.Drawing.Size(13, 13);
            this.followingslbl.TabIndex = 8;
            this.followingslbl.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 343);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.followingslbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fllowerslbl);
            this.Controls.Add(this.submitbttn);
            this.Controls.Add(this.passwdbox);
            this.Controls.Add(this.usrnmbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrnmbox;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Button submitbttn;
        private System.Windows.Forms.Label fllowerslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label followingslbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

