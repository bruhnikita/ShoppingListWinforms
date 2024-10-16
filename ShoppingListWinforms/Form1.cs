using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoppingListWinforms
{
    public partial class MainForm : Form
    {
        private List<ShoppingList> shoppingLists;
        private ShoppingList currentList;

        public MainForm()
        {
            InitializeComponent();
            shoppingLists = new List<ShoppingList>();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnAddList.Click += BtnAddList_Click;
            btnRemoveList.Click += BtnRemoveList_Click;
            btnAddItem.Click += BtnAddItem_Click;
            btnRemoveItem.Click += BtnRemoveItem_Click;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentList = shoppingLists[comboBox1.SelectedIndex];
            UpdateListBox();
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            string listName = Microsoft.VisualBasic.Interaction.InputBox("������� �������� ������:", "������� ������", "����� ������");
            if (!string.IsNullOrEmpty(listName))
            {
                var newList = new ShoppingList(listName);
                shoppingLists.Add(newList);
                comboBox1.Items.Add(newList.Name);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1; 
            }
        }

        private void BtnRemoveList_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int index = comboBox1.SelectedIndex;
                shoppingLists.RemoveAt(index);
                comboBox1.Items.RemoveAt(index);
                currentList = null; 
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ��������.");
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (currentList != null)
            {
                string item = Microsoft.VisualBasic.Interaction.InputBox("������� ������� ��� ����������:", "�������� �������");
                if (!string.IsNullOrEmpty(item))
                {
                    currentList.Items.Add(item);
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("������� ����� ��� ����������.");
                }
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (currentList != null)
            {
                string item = Microsoft.VisualBasic.Interaction.InputBox("������� ������� ��� ��������:", "������� �������");
                if (currentList.Items.Remove(item))
                {
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("������� �� ������.");
                }
            }
        }

        private void UpdateListBox()
        {
            listBoxShoppingList.Items.Clear();
            if (currentList != null)
            {
                foreach (var item in currentList.Items)
                {
                    listBoxShoppingList.Items.Add(item);
                }
            }
        }
    }

    public class ShoppingList
    {
        public string Name { get; set; }
        public List<string> Items { get; set; }

        public ShoppingList(string name)
        {
            Name = name;
            Items = new List<string>();
        }
    }
}
