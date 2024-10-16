namespace ShoppingListWinforms
{
    partial class MainForm
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            btnAddList = new Button();
            btnRemoveList = new Button();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            listBoxShoppingList = new ListBox(); // Добавляем ListBox
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(800, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged; // Добавляем обработчик
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRemoveItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(btnRemoveList);
            panel1.Controls.Add(btnAddList);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(658, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 427);
            panel1.TabIndex = 1;
            // 
            // btnAddList
            // 
            btnAddList.Dock = DockStyle.Top;
            btnAddList.Location = new Point(0, 0);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(142, 81);
            btnAddList.TabIndex = 0;
            btnAddList.Text = "Добавить список";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += BtnAddList_Click; // Добавляем обработчик
            // 
            // btnRemoveList
            // 
            btnRemoveList.Dock = DockStyle.Top;
            btnRemoveList.Location = new Point(0, 81);
            btnRemoveList.Name = "btnRemoveList";
            btnRemoveList.Size = new Size(142, 81);
            btnRemoveList.TabIndex = 1;
            btnRemoveList.Text = "Удалить список";
            btnRemoveList.UseVisualStyleBackColor = true;
            btnRemoveList.Click += BtnRemoveList_Click; // Добавляем обработчик
            // 
            // btnAddItem
            // 
            btnAddItem.Dock = DockStyle.Top;
            btnAddItem.Location = new Point(0, 162);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(142, 81);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Добавить элемент";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += BtnAddItem_Click; // Добавляем обработчик
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Dock = DockStyle.Top;
            btnRemoveItem.Location = new Point(0, 243);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(142, 81);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Text = "Удалить элемент";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += BtnRemoveItem_Click; // Добавляем обработчик
            // 
            // listBoxShoppingList
            // 
            listBoxShoppingList.Dock = DockStyle.Fill; // Заполняем оставшееся пространство
            listBoxShoppingList.Location = new Point(0, 23);
            listBoxShoppingList.Name = "listBoxShoppingList";
            listBoxShoppingList.Size = new Size(658, 427);
            listBoxShoppingList.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxShoppingList); // Добавляем ListBox в Controls
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Name = "MainForm";
            Text = "Менеджер покупок";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Button btnRemoveItem;
        private Button btnAddItem;
        private Button btnRemoveList;
        private Button btnAddList;
        private ListBox listBoxShoppingList; // Добавляем поле для ListBox
    }
}
