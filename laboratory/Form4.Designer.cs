namespace laboratory
{
    partial class Form4
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
            this.costOrder = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bigMac = new System.Windows.Forms.CheckBox();
            this.sauce = new System.Windows.Forms.CheckBox();
            this.beacon = new System.Windows.Forms.CheckBox();
            this.potato = new System.Windows.Forms.CheckBox();
            this.bShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // costOrder
            // 
            this.costOrder.AutoSize = true;
            this.costOrder.Location = new System.Drawing.Point(12, 27);
            this.costOrder.Name = "costOrder";
            this.costOrder.Size = new System.Drawing.Size(104, 15);
            this.costOrder.TabIndex = 0;
            this.costOrder.Text = "Стоимость заказа";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(137, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bigMac
            // 
            this.bigMac.AutoSize = true;
            this.bigMac.Location = new System.Drawing.Point(50, 90);
            this.bigMac.Name = "bigMac";
            this.bigMac.Size = new System.Drawing.Size(73, 19);
            this.bigMac.TabIndex = 2;
            this.bigMac.Text = "Биг-Мак";
            this.bigMac.UseVisualStyleBackColor = true;
            // 
            // sauce
            // 
            this.sauce.AutoSize = true;
            this.sauce.Location = new System.Drawing.Point(50, 120);
            this.sauce.Name = "sauce";
            this.sauce.Size = new System.Drawing.Size(53, 19);
            this.sauce.TabIndex = 3;
            this.sauce.Text = "Соус";
            this.sauce.UseVisualStyleBackColor = true;
            // 
            // beacon
            // 
            this.beacon.AutoSize = true;
            this.beacon.Location = new System.Drawing.Point(50, 150);
            this.beacon.Name = "beacon";
            this.beacon.Size = new System.Drawing.Size(60, 19);
            this.beacon.TabIndex = 4;
            this.beacon.Text = "Бикон";
            this.beacon.UseVisualStyleBackColor = true;
            // 
            // potato
            // 
            this.potato.AutoSize = true;
            this.potato.Location = new System.Drawing.Point(50, 180);
            this.potato.Name = "potato";
            this.potato.Size = new System.Drawing.Size(81, 19);
            this.potato.TabIndex = 5;
            this.potato.Text = "Картошка";
            this.potato.UseVisualStyleBackColor = true;
            // 
            // bShowResult
            // 
            this.bShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowResult.Location = new System.Drawing.Point(96, 247);
            this.bShowResult.Name = "bShowResult";
            this.bShowResult.Size = new System.Drawing.Size(81, 25);
            this.bShowResult.TabIndex = 6;
            this.bShowResult.Text = "Ок";
            this.bShowResult.UseVisualStyleBackColor = true;
            this.bShowResult.Click += new System.EventHandler(this.bShowResult_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.bShowResult);
            this.Controls.Add(this.potato);
            this.Controls.Add(this.beacon);
            this.Controls.Add(this.sauce);
            this.Controls.Add(this.bigMac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.costOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label costOrder;
        private TextBox textBox1;
        private CheckBox bigMac;
        private CheckBox sauce;
        private CheckBox beacon;
        private CheckBox potato;
        private Button bShowResult;
    }
}