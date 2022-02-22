
namespace Bakiye_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txturun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.btngelir = new System.Windows.Forms.Button();
            this.btngider = new System.Windows.Forms.Button();
            this.lstgecmis = new System.Windows.Forms.ListBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(10, 36);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(128, 23);
            this.txturun.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün İsmi;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Değeri; (₺)";
            // 
            // txtdeger
            // 
            this.txtdeger.Location = new System.Drawing.Point(157, 36);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(128, 23);
            this.txtdeger.TabIndex = 2;
            // 
            // btngelir
            // 
            this.btngelir.Location = new System.Drawing.Point(10, 65);
            this.btngelir.Name = "btngelir";
            this.btngelir.Size = new System.Drawing.Size(128, 41);
            this.btngelir.TabIndex = 4;
            this.btngelir.Text = "Gelir (+)";
            this.btngelir.UseVisualStyleBackColor = true;
            this.btngelir.Click += new System.EventHandler(this.btngelir_Click);
            // 
            // btngider
            // 
            this.btngider.Location = new System.Drawing.Point(157, 65);
            this.btngider.Name = "btngider";
            this.btngider.Size = new System.Drawing.Size(128, 41);
            this.btngider.TabIndex = 5;
            this.btngider.Text = "Gider (-)";
            this.btngider.UseVisualStyleBackColor = true;
            this.btngider.Click += new System.EventHandler(this.btngider_Click);
            // 
            // lstgecmis
            // 
            this.lstgecmis.FormattingEnabled = true;
            this.lstgecmis.ItemHeight = 17;
            this.lstgecmis.Items.AddRange(new object[] {
            ""});
            this.lstgecmis.Location = new System.Drawing.Point(12, 112);
            this.lstgecmis.Name = "lstgecmis";
            this.lstgecmis.Size = new System.Drawing.Size(273, 208);
            this.lstgecmis.TabIndex = 6;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 326);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(273, 33);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Geçmişi Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bakiyen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "0.00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.lstgecmis);
            this.Controls.Add(this.btngider);
            this.Controls.Add(this.btngelir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdeger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturun);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Asnus Bakiye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.Button btngelir;
        private System.Windows.Forms.Button btngider;
        private System.Windows.Forms.ListBox lstgecmis;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

