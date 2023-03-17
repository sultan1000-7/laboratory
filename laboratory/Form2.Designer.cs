namespace laboratory
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showTotalPrice = new System.Windows.Forms.TextBox();
            this.showBasePrice = new System.Windows.Forms.TextBox();
            this.carPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(40, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // option
            // 
            this.option.AutoSize = true;
            this.option.Location = new System.Drawing.Point(40, 160);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(141, 15);
            this.option.TabIndex = 2;
            this.option.Text = "Дополнительные опции";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "АБС";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(60, 235);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Противотуманки";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(60, 270);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 19);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Патроник";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(60, 305);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 19);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Кожаный салон";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Базовая цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Модель";
            // 
            // showTotalPrice
            // 
            this.showTotalPrice.Location = new System.Drawing.Point(305, 403);
            this.showTotalPrice.Name = "showTotalPrice";
            this.showTotalPrice.ReadOnly = true;
            this.showTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.showTotalPrice.TabIndex = 9;
            this.showTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // showBasePrice
            // 
            this.showBasePrice.Location = new System.Drawing.Point(337, 43);
            this.showBasePrice.Name = "showBasePrice";
            this.showBasePrice.ReadOnly = true;
            this.showBasePrice.Size = new System.Drawing.Size(100, 23);
            this.showBasePrice.TabIndex = 10;
            this.showBasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.showBasePrice.TextChanged += new System.EventHandler(this.showBasePrice_TextChanged);
            // 
            // carPhoto
            // 
            this.carPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPhoto.ErrorImage = null;
            this.carPhoto.InitialImage = null;
            this.carPhoto.Location = new System.Drawing.Point(239, 102);
            this.carPhoto.Name = "carPhoto";
            this.carPhoto.Size = new System.Drawing.Size(221, 175);
            this.carPhoto.TabIndex = 11;
            this.carPhoto.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.carPhoto);
            this.Controls.Add(this.showBasePrice);
            this.Controls.Add(this.showTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.option);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.carPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label option;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
        private Label label2;
        private TextBox showTotalPrice;
        private TextBox showBasePrice;
        private PictureBox carPhoto;
    }
}