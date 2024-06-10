namespace shysap_bài_tập_2
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
            this.btndientich = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hkbchuvi = new System.Windows.Forms.CheckBox();
            this.hkbdientich = new System.Windows.Forms.CheckBox();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(136, 232);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 0;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(573, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(117, 91);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(50, 13);
            this.lblbankinh.TabIndex = 2;
            this.lblbankinh.Text = "bán kính";
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(34, 19);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 3;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(192, 91);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 4;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(117, 164);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(43, 13);
            this.lblketqua.TabIndex = 5;
            this.lblketqua.Text = "kết quả";
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(252, 232);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 7;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Location = new System.Drawing.Point(482, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(34, 57);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(57, 17);
            this.rdbchuvi.TabIndex = 4;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi ";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(578, 154);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 9;
            this.btntinh1.Text = "tính";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hkbchuvi);
            this.groupBox2.Controls.Add(this.hkbdientich);
            this.groupBox2.Location = new System.Drawing.Point(490, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 113);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // hkbchuvi
            // 
            this.hkbchuvi.AutoSize = true;
            this.hkbchuvi.Location = new System.Drawing.Point(48, 66);
            this.hkbchuvi.Name = "hkbchuvi";
            this.hkbchuvi.Size = new System.Drawing.Size(58, 17);
            this.hkbchuvi.TabIndex = 1;
            this.hkbchuvi.Text = "chu vi ";
            this.hkbchuvi.UseVisualStyleBackColor = true;
            // 
            // hkbdientich
            // 
            this.hkbdientich.AutoSize = true;
            this.hkbdientich.Location = new System.Drawing.Point(48, 32);
            this.hkbdientich.Name = "hkbdientich";
            this.hkbdientich.Size = new System.Drawing.Size(68, 17);
            this.hkbdientich.TabIndex = 0;
            this.hkbdientich.Text = "diện tích";
            this.hkbdientich.UseVisualStyleBackColor = true;
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(578, 376);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 11;
            this.btntinh2.Text = "tính";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(192, 161);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btndientich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox hkbchuvi;
        private System.Windows.Forms.CheckBox hkbdientich;
        private System.Windows.Forms.Button btntinh2;
        private System.Windows.Forms.TextBox txtketqua;
    }
}

