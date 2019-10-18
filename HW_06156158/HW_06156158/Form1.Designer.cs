namespace HW_06156158
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Bmilab = new System.Windows.Forms.Label();
            this.talllab = new System.Windows.Forms.Label();
            this.weightlab = new System.Windows.Forms.Label();
            this.talltextbox = new System.Windows.Forms.TextBox();
            this.weighttextbox = new System.Windows.Forms.TextBox();
            this.cmradio = new System.Windows.Forms.RadioButton();
            this.Mradio = new System.Windows.Forms.RadioButton();
            this.kglab = new System.Windows.Forms.Label();
            this.countbt = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.showbmilab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Bmilab
            // 
            this.Bmilab.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bmilab.Location = new System.Drawing.Point(29, 49);
            this.Bmilab.Name = "Bmilab";
            this.Bmilab.Size = new System.Drawing.Size(95, 30);
            this.Bmilab.TabIndex = 0;
            this.Bmilab.Text = "BMI計算";
            // 
            // talllab
            // 
            this.talllab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.talllab.Location = new System.Drawing.Point(43, 100);
            this.talllab.Name = "talllab";
            this.talllab.Size = new System.Drawing.Size(58, 18);
            this.talllab.TabIndex = 1;
            this.talllab.Text = "身高:";
            // 
            // weightlab
            // 
            this.weightlab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightlab.Location = new System.Drawing.Point(43, 144);
            this.weightlab.Name = "weightlab";
            this.weightlab.Size = new System.Drawing.Size(58, 18);
            this.weightlab.TabIndex = 2;
            this.weightlab.Text = "體重:";
            // 
            // talltextbox
            // 
            this.talltextbox.Location = new System.Drawing.Point(107, 100);
            this.talltextbox.Name = "talltextbox";
            this.talltextbox.Size = new System.Drawing.Size(76, 22);
            this.talltextbox.TabIndex = 3;
            // 
            // weighttextbox
            // 
            this.weighttextbox.Location = new System.Drawing.Point(107, 144);
            this.weighttextbox.Name = "weighttextbox";
            this.weighttextbox.Size = new System.Drawing.Size(76, 22);
            this.weighttextbox.TabIndex = 4;
            // 
            // cmradio
            // 
            this.cmradio.AutoSize = true;
            this.cmradio.Checked = true;
            this.cmradio.Location = new System.Drawing.Point(189, 102);
            this.cmradio.Name = "cmradio";
            this.cmradio.Size = new System.Drawing.Size(47, 16);
            this.cmradio.TabIndex = 5;
            this.cmradio.TabStop = true;
            this.cmradio.Text = "公分";
            this.cmradio.UseVisualStyleBackColor = true;
            // 
            // Mradio
            // 
            this.Mradio.AutoSize = true;
            this.Mradio.Location = new System.Drawing.Point(242, 102);
            this.Mradio.Name = "Mradio";
            this.Mradio.Size = new System.Drawing.Size(47, 16);
            this.Mradio.TabIndex = 6;
            this.Mradio.Text = "公尺";
            this.Mradio.UseVisualStyleBackColor = true;
            // 
            // kglab
            // 
            this.kglab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kglab.Location = new System.Drawing.Point(189, 148);
            this.kglab.Name = "kglab";
            this.kglab.Size = new System.Drawing.Size(47, 18);
            this.kglab.TabIndex = 7;
            this.kglab.Text = "公斤";
            // 
            // countbt
            // 
            this.countbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.countbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countbt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.countbt.Location = new System.Drawing.Point(33, 198);
            this.countbt.Name = "countbt";
            this.countbt.Size = new System.Drawing.Size(238, 41);
            this.countbt.TabIndex = 8;
            this.countbt.Text = "計算標準體重";
            this.countbt.UseVisualStyleBackColor = false;
            this.countbt.Click += new System.EventHandler(this.countbt_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(85, 261);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 78);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // showbmilab
            // 
            this.showbmilab.AutoSize = true;
            this.showbmilab.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbmilab.Location = new System.Drawing.Point(130, 342);
            this.showbmilab.Name = "showbmilab";
            this.showbmilab.Size = new System.Drawing.Size(30, 12);
            this.showbmilab.TabIndex = 10;
            this.showbmilab.Text = "BMI";
            this.showbmilab.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 383);
            this.Controls.Add(this.showbmilab);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.countbt);
            this.Controls.Add(this.kglab);
            this.Controls.Add(this.Mradio);
            this.Controls.Add(this.cmradio);
            this.Controls.Add(this.weighttextbox);
            this.Controls.Add(this.talltextbox);
            this.Controls.Add(this.weightlab);
            this.Controls.Add(this.talllab);
            this.Controls.Add(this.Bmilab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bmilab;
        private System.Windows.Forms.Label talllab;
        private System.Windows.Forms.Label weightlab;
        private System.Windows.Forms.TextBox talltextbox;
        private System.Windows.Forms.TextBox weighttextbox;
        private System.Windows.Forms.RadioButton cmradio;
        private System.Windows.Forms.RadioButton Mradio;
        private System.Windows.Forms.Label kglab;
        private System.Windows.Forms.Button countbt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label showbmilab;
    }
}

