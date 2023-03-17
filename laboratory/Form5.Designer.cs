namespace laboratory
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            startList = new ListBox();
            notFavouriteList = new ListBox();
            favouriteList = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            bSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Любимые";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 47);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Нелюбимые";
            // 
            // startList
            // 
            startList.AllowDrop = true;
            startList.FormattingEnabled = true;
            startList.ItemHeight = 20;
            startList.Location = new Point(303, 80);
            startList.Margin = new Padding(3, 4, 3, 4);
            startList.Name = "startList";
            startList.Size = new Size(182, 404);
            startList.TabIndex = 2;
            startList.MouseClick += FormMouseClick;
            startList.DragDrop += startList_DragDrop;
            startList.DragEnter += ListDragEnter;
            startList.MouseDown += ListMouseDown;
            // 
            // notFavouriteList
            // 
            notFavouriteList.AllowDrop = true;
            notFavouriteList.FormattingEnabled = true;
            notFavouriteList.ItemHeight = 20;
            notFavouriteList.Location = new Point(560, 80);
            notFavouriteList.Margin = new Padding(3, 4, 3, 4);
            notFavouriteList.Name = "notFavouriteList";
            notFavouriteList.Size = new Size(182, 404);
            notFavouriteList.TabIndex = 3;
            notFavouriteList.MouseClick += FormMouseClick;
            notFavouriteList.DragDrop += notFavouriteList_DragDrop;
            notFavouriteList.DragEnter += ListDragEnter;
            notFavouriteList.MouseDown += ListMouseDown;
            // 
            // favouriteList
            // 
            favouriteList.AllowDrop = true;
            favouriteList.FormattingEnabled = true;
            favouriteList.ItemHeight = 20;
            favouriteList.Location = new Point(34, 80);
            favouriteList.Margin = new Padding(3, 4, 3, 4);
            favouriteList.Name = "favouriteList";
            favouriteList.Size = new Size(182, 404);
            favouriteList.TabIndex = 4;
            favouriteList.MouseClick += FormMouseClick;
            favouriteList.DragDrop += favouriteList_DragDrop;
            favouriteList.DragEnter += ListDragEnter;
            favouriteList.MouseDown += ListMouseDown;
            // 
            // button1
            // 
            button1.Location = new Point(240, 176);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 47);
            button1.TabIndex = 5;
            button1.Text = "❮";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 287);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(40, 47);
            button2.TabIndex = 6;
            button2.Text = "❯";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 176);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(40, 47);
            button3.TabIndex = 7;
            button3.Text = "❯";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(503, 287);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(40, 47);
            button4.TabIndex = 8;
            button4.Text = "❮";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(303, 503);
            bSave.Name = "bSave";
            bSave.Size = new Size(182, 29);
            bSave.TabIndex = 10;
            bSave.Text = "Сохранить";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 600);
            Controls.Add(bSave);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(favouriteList);
            Controls.Add(notFavouriteList);
            Controls.Add(startList);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            ShowIcon = false;
            Text = "Form5";
            MouseClick += FormMouseClick;
            MouseMove += FormMouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox startList;
        private ListBox notFavouriteList;
        private ListBox favouriteList;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button bSave;
    }
}