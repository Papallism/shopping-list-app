using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class MainForm : Form
    {
        private TodoItem currentTodoItem;

        private int todoItemsCompleted = 0;
        private int todoItemsTotal = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Equals("") || textBoxQuantity.Text.Trim().Equals(""))
            {
                MessageBox.Show("Invalid name/quantity entered",
                                "Input error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                currentTodoItem = new TodoItem()
                {
                    TodoName = textBoxName.Text,
                    TodoQuantity = int.Parse(textBoxQuantity.Text),
                };

                listBoxTodo.Items.Add(currentTodoItem);
                todoItemsTotal++;
                progressBarTodo.Maximum = todoItemsTotal;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedTodoItem = listBoxTodo.SelectedItem;
            if (selectedTodoItem != null)
            {
                listBoxTodo.Items.Remove(selectedTodoItem);
                todoItemsTotal--;
                progressBarTodo.Maximum = todoItemsTotal;
            }
        }

        private void buttonMarkComplete_Click(object sender, EventArgs e)
        {
            var selectedTodoItem = listBoxTodo.SelectedItem;
            if (selectedTodoItem != null)
            {
                listBoxComplete.Items.Add((TodoItem)selectedTodoItem);
                listBoxTodo.Items.Remove(selectedTodoItem);
                todoItemsCompleted++;
                progressBarTodo.Value = todoItemsCompleted;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            int currentlyCompletedTodoItems = listBoxComplete.Items.Count;
            todoItemsTotal -= currentlyCompletedTodoItems;
            progressBarTodo.Maximum = todoItemsTotal;
            todoItemsCompleted = 0;
            progressBarTodo.Value = 0;

            listBoxComplete.Items.Clear();
        }
    }
}
