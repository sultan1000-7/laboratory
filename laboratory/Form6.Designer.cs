namespace laboratory
{
    partial class Form6
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
            txtStateNumber = new TextBox();
            txtModel = new TextBox();
            txtColor = new TextBox();
            txtFullName = new TextBox();
            lStateNumber = new Label();
            lModel = new Label();
            lColor = new Label();
            lFullName = new Label();
            groupBox1 = new GroupBox();
            bSave = new Button();
            bClear = new Button();
            cmbNumbers = new ComboBox();
            lListNumbers = new Label();
            bDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtStateNumber
            // 
            txtStateNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStateNumber.Location = new Point(189, 33);
            txtStateNumber.Name = "txtStateNumber";
            txtStateNumber.Size = new Size(300, 30);
            txtStateNumber.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.Location = new Point(189, 83);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(300, 30);
            txtModel.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(189, 133);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(300, 30);
            txtColor.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(189, 183);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 30);
            txtFullName.TabIndex = 4;
            // 
            // lStateNumber
            // 
            lStateNumber.AutoSize = true;
            lStateNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lStateNumber.Location = new Point(17, 33);
            lStateNumber.Name = "lStateNumber";
            lStateNumber.Size = new Size(97, 25);
            lStateNumber.TabIndex = 5;
            lStateNumber.Text = "Госномер";
            // 
            // lModel
            // 
            lModel.AutoSize = true;
            lModel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lModel.Location = new Point(17, 83);
            lModel.Name = "lModel";
            lModel.Size = new Size(82, 25);
            lModel.TabIndex = 6;
            lModel.Text = "Модель";
            // 
            // lColor
            // 
            lColor.AutoSize = true;
            lColor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lColor.Location = new Point(17, 133);
            lColor.Name = "lColor";
            lColor.Size = new Size(55, 25);
            lColor.TabIndex = 7;
            lColor.Text = "Цвет";
            // 
            // lFullName
            // 
            lFullName.AutoSize = true;
            lFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lFullName.Location = new Point(17, 183);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(155, 25);
            lFullName.TabIndex = 8;
            lFullName.Text = "ФИО владельца";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bSave);
            groupBox1.Controls.Add(bClear);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(lFullName);
            groupBox1.Controls.Add(txtStateNumber);
            groupBox1.Controls.Add(lColor);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(lModel);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(lStateNumber);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(277, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 341);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные";
            // 
            // bSave
            // 
            bSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bSave.Location = new Point(17, 282);
            bSave.Name = "bSave";
            bSave.Size = new Size(167, 32);
            bSave.TabIndex = 13;
            bSave.Text = "Сохранить";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bClear
            // 
            bClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bClear.Location = new Point(251, 282);
            bClear.Name = "bClear";
            bClear.Size = new Size(263, 32);
            bClear.TabIndex = 14;
            bClear.Text = "Отменить изменения";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // cmbNumbers
            // 
            cmbNumbers.FormattingEnabled = true;
            cmbNumbers.ImeMode = ImeMode.NoControl;
            cmbNumbers.Location = new Point(35, 80);
            cmbNumbers.MaxDropDownItems = 10;
            cmbNumbers.Name = "cmbNumbers";
            cmbNumbers.Size = new Size(217, 28);
            cmbNumbers.TabIndex = 10;
            cmbNumbers.TextChanged += cmbNumbers_TextChanged;
            // 
            // lListNumbers
            // 
            lListNumbers.AutoSize = true;
            lListNumbers.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lListNumbers.Location = new Point(69, 42);
            lListNumbers.Name = "lListNumbers";
            lListNumbers.Size = new Size(158, 25);
            lListNumbers.TabIndex = 11;
            lListNumbers.Text = "Список номеров";
            // 
            // bDelete
            // 
            bDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            bDelete.Location = new Point(69, 344);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(158, 32);
            bDelete.TabIndex = 12;
            bDelete.Text = "Удалить";
            bDelete.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(bDelete);
            Controls.Add(lListNumbers);
            Controls.Add(cmbNumbers);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form6";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label lResult;
        private TextBox txtStateNumber;
        private TextBox txtModel;
        private TextBox txtColor;
        private Label lStateNumber;
        private Label lModel;
        private Label lColor;
        private Label lFullName;
        private GroupBox groupBox1;
        private ComboBox cmbNumbers;
        private Button bSave;
        private Button bClear;
        private Label lListNumbers;
        private Button bDelete;
    }
}