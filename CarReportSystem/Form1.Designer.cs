namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvItiran = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btHirekuData = new System.Windows.Forms.Button();
            this.btHozonData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btHirakuImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btTuika = new System.Windows.Forms.Button();
            this.btSyusei = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.Maker = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItiran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.Maker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(82, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(298, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付：";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(81, 72);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(299, 20);
            this.cbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "車名：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(90, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(174, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(262, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(351, 12);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "外車";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(435, 12);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "レポート：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(82, 181);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(298, 20);
            this.cbCarName.TabIndex = 13;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(82, 246);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(498, 128);
            this.tbReport.TabIndex = 14;
            // 
            // dgvItiran
            // 
            this.dgvItiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItiran.Location = new System.Drawing.Point(82, 380);
            this.dgvItiran.Name = "dgvItiran";
            this.dgvItiran.RowTemplate.Height = 21;
            this.dgvItiran.Size = new System.Drawing.Size(839, 150);
            this.dgvItiran.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "記事一覧：";
            // 
            // btHirekuData
            // 
            this.btHirekuData.Location = new System.Drawing.Point(17, 403);
            this.btHirekuData.Name = "btHirekuData";
            this.btHirekuData.Size = new System.Drawing.Size(59, 42);
            this.btHirekuData.TabIndex = 17;
            this.btHirekuData.Text = "開く";
            this.btHirekuData.UseVisualStyleBackColor = true;
            // 
            // btHozonData
            // 
            this.btHozonData.Location = new System.Drawing.Point(17, 451);
            this.btHozonData.Name = "btHozonData";
            this.btHozonData.Size = new System.Drawing.Size(59, 42);
            this.btHozonData.TabIndex = 18;
            this.btHozonData.Text = "保存";
            this.btHozonData.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(782, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "終了";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btHirakuImage
            // 
            this.btHirakuImage.Location = new System.Drawing.Point(696, 33);
            this.btHirakuImage.Name = "btHirakuImage";
            this.btHirakuImage.Size = new System.Drawing.Size(75, 23);
            this.btHirakuImage.TabIndex = 20;
            this.btHirakuImage.Text = "開く";
            this.btHirakuImage.UseVisualStyleBackColor = true;
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Location = new System.Drawing.Point(815, 33);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 21;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "画像：";
            // 
            // btTuika
            // 
            this.btTuika.Location = new System.Drawing.Point(677, 351);
            this.btTuika.Name = "btTuika";
            this.btTuika.Size = new System.Drawing.Size(75, 23);
            this.btTuika.TabIndex = 23;
            this.btTuika.Text = "追加";
            this.btTuika.UseVisualStyleBackColor = true;
            // 
            // btSyusei
            // 
            this.btSyusei.Location = new System.Drawing.Point(761, 351);
            this.btSyusei.Name = "btSyusei";
            this.btSyusei.Size = new System.Drawing.Size(75, 23);
            this.btSyusei.TabIndex = 24;
            this.btSyusei.Text = "修正";
            this.btSyusei.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(845, 351);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 25;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(586, 72);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(335, 273);
            this.pbImage.TabIndex = 26;
            this.pbImage.TabStop = false;
            // 
            // Maker
            // 
            this.Maker.Controls.Add(this.radioButton6);
            this.Maker.Controls.Add(this.radioButton5);
            this.Maker.Controls.Add(this.radioButton4);
            this.Maker.Controls.Add(this.radioButton3);
            this.Maker.Controls.Add(this.radioButton2);
            this.Maker.Controls.Add(this.radioButton1);
            this.Maker.Location = new System.Drawing.Point(82, 118);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(498, 39);
            this.Maker.TabIndex = 27;
            this.Maker.TabStop = false;
            this.Maker.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 593);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSyusei);
            this.Controls.Add(this.btTuika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btHirakuImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btHozonData);
            this.Controls.Add(this.btHirekuData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvItiran);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItiran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.Maker.ResumeLayout(false);
            this.Maker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvItiran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btHirekuData;
        private System.Windows.Forms.Button btHozonData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btHirakuImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTuika;
        private System.Windows.Forms.Button btSyusei;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox Maker;
    }
}

