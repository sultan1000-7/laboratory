namespace laboratory
{
    partial class Form3
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
            this.bHeight = new System.Windows.Forms.Label();
            this.bWidth = new System.Windows.Forms.Label();
            this.lMaterial = new System.Windows.Forms.Label();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.cMaterial = new System.Windows.Forms.ComboBox();
            this.horizontalBlinds = new System.Windows.Forms.RadioButton();
            this.verticalBlinds = new System.Windows.Forms.RadioButton();
            this.rollerBlinds = new System.Windows.Forms.RadioButton();
            this.mosaicBlinds = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bHeight
            // 
            this.bHeight.AutoSize = true;
            this.bHeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bHeight.Location = new System.Drawing.Point(70, 90);
            this.bHeight.Name = "bHeight";
            this.bHeight.Size = new System.Drawing.Size(84, 17);
            this.bHeight.TabIndex = 0;
            this.bHeight.Text = "Высота (см)";
            // 
            // bWidth
            // 
            this.bWidth.AutoSize = true;
            this.bWidth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bWidth.Location = new System.Drawing.Point(70, 40);
            this.bWidth.Name = "bWidth";
            this.bWidth.Size = new System.Drawing.Size(90, 17);
            this.bWidth.TabIndex = 1;
            this.bWidth.Text = "Ширина (см)";
            // 
            // lMaterial
            // 
            this.lMaterial.AutoSize = true;
            this.lMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lMaterial.Location = new System.Drawing.Point(70, 190);
            this.lMaterial.Name = "lMaterial";
            this.lMaterial.Size = new System.Drawing.Size(71, 17);
            this.lMaterial.TabIndex = 2;
            this.lMaterial.Text = "Материал";
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(180, 40);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(132, 23);
            this.tHeight.TabIndex = 3;
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(180, 90);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(132, 23);
            this.tWidth.TabIndex = 4;
            // 
            // cMaterial
            // 
            this.cMaterial.FormattingEnabled = true;
            this.cMaterial.Location = new System.Drawing.Point(180, 189);
            this.cMaterial.Name = "cMaterial";
            this.cMaterial.Size = new System.Drawing.Size(174, 23);
            this.cMaterial.TabIndex = 5;
            this.cMaterial.SelectedIndexChanged += new System.EventHandler(this.cMaterial_SelectedIndexChanged);
            // 
            // horizontalBlinds
            // 
            this.horizontalBlinds.AutoSize = true;
            this.horizontalBlinds.Location = new System.Drawing.Point(16, 22);
            this.horizontalBlinds.Name = "horizontalBlinds";
            this.horizontalBlinds.Size = new System.Drawing.Size(117, 19);
            this.horizontalBlinds.TabIndex = 6;
            this.horizontalBlinds.Text = "Горизонтальные";
            this.horizontalBlinds.UseVisualStyleBackColor = true;
            this.horizontalBlinds.CheckedChanged += new System.EventHandler(this.horizontalBlinds_CheckedChanged);
            // 
            // verticalBlinds
            // 
            this.verticalBlinds.AutoSize = true;
            this.verticalBlinds.Location = new System.Drawing.Point(16, 57);
            this.verticalBlinds.Name = "verticalBlinds";
            this.verticalBlinds.Size = new System.Drawing.Size(104, 19);
            this.verticalBlinds.TabIndex = 7;
            this.verticalBlinds.Text = "Вертикальные";
            this.verticalBlinds.UseVisualStyleBackColor = true;
            this.verticalBlinds.CheckedChanged += new System.EventHandler(this.verticalBlinds_CheckedChanged);
            // 
            // rollerBlinds
            // 
            this.rollerBlinds.AutoSize = true;
            this.rollerBlinds.Location = new System.Drawing.Point(16, 92);
            this.rollerBlinds.Name = "rollerBlinds";
            this.rollerBlinds.Size = new System.Drawing.Size(81, 19);
            this.rollerBlinds.TabIndex = 8;
            this.rollerBlinds.Text = "Рулонные";
            this.rollerBlinds.UseVisualStyleBackColor = true;
            this.rollerBlinds.CheckedChanged += new System.EventHandler(this.rollerBlinds_CheckedChanged);
            // 
            // mosaicBlinds
            // 
            this.mosaicBlinds.AutoSize = true;
            this.mosaicBlinds.Location = new System.Drawing.Point(16, 127);
            this.mosaicBlinds.Name = "mosaicBlinds";
            this.mosaicBlinds.Size = new System.Drawing.Size(90, 19);
            this.mosaicBlinds.TabIndex = 9;
            this.mosaicBlinds.Text = "Мозаичные";
            this.mosaicBlinds.UseVisualStyleBackColor = true;
            this.mosaicBlinds.CheckedChanged += new System.EventHandler(this.mosaicBlinds_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mosaicBlinds);
            this.groupBox1.Controls.Add(this.rollerBlinds);
            this.groupBox1.Controls.Add(this.verticalBlinds);
            this.groupBox1.Controls.Add(this.horizontalBlinds);
            this.groupBox1.Location = new System.Drawing.Point(467, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип жалюзи";
            // 
            // bCalculate
            // 
            this.bCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bCalculate.Location = new System.Drawing.Point(70, 299);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(140, 27);
            this.bCalculate.TabIndex = 11;
            this.bCalculate.Text = "Рассчитать";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(251, 299);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(288, 27);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cMaterial);
            this.Controls.Add(this.tWidth);
            this.Controls.Add(this.tHeight);
            this.Controls.Add(this.lMaterial);
            this.Controls.Add(this.bWidth);
            this.Controls.Add(this.bHeight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Жалюзи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bHeight;
        private Label bWidth;
        private Label lMaterial;
        private TextBox tHeight;
        private TextBox tWidth;
        private ComboBox cMaterial;
        private RadioButton horizontalBlinds;
        private RadioButton verticalBlinds;
        private RadioButton rollerBlinds;
        private RadioButton mosaicBlinds;
        private GroupBox groupBox1;
        private Button bCalculate;
        private Label resultLabel;
    }
}