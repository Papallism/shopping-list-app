namespace ShoppingList
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
            this.groupBoxNewItem = new System.Windows.Forms.GroupBox();
            this.groupBoxTodo = new System.Windows.Forms.GroupBox();
            this.groupBoxCompleted = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMarkComplete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxTodo = new System.Windows.Forms.ListBox();
            this.listBoxComplete = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxNewItem.SuspendLayout();
            this.groupBoxTodo.SuspendLayout();
            this.groupBoxCompleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewItem
            // 
            this.groupBoxNewItem.Controls.Add(this.textBoxQuantity);
            this.groupBoxNewItem.Controls.Add(this.textBoxName);
            this.groupBoxNewItem.Controls.Add(this.buttonAdd);
            this.groupBoxNewItem.Controls.Add(this.labelQuantity);
            this.groupBoxNewItem.Controls.Add(this.labelName);
            this.groupBoxNewItem.Location = new System.Drawing.Point(30, 71);
            this.groupBoxNewItem.Name = "groupBoxNewItem";
            this.groupBoxNewItem.Size = new System.Drawing.Size(312, 218);
            this.groupBoxNewItem.TabIndex = 0;
            this.groupBoxNewItem.TabStop = false;
            this.groupBoxNewItem.Text = "New Item";
            // 
            // groupBoxTodo
            // 
            this.groupBoxTodo.Controls.Add(this.listBoxTodo);
            this.groupBoxTodo.Controls.Add(this.buttonMarkComplete);
            this.groupBoxTodo.Controls.Add(this.buttonDelete);
            this.groupBoxTodo.Location = new System.Drawing.Point(385, 71);
            this.groupBoxTodo.Name = "groupBoxTodo";
            this.groupBoxTodo.Size = new System.Drawing.Size(312, 218);
            this.groupBoxTodo.TabIndex = 1;
            this.groupBoxTodo.TabStop = false;
            this.groupBoxTodo.Text = "To do";
            // 
            // groupBoxCompleted
            // 
            this.groupBoxCompleted.Controls.Add(this.progressBar1);
            this.groupBoxCompleted.Controls.Add(this.listBoxComplete);
            this.groupBoxCompleted.Controls.Add(this.buttonClear);
            this.groupBoxCompleted.Location = new System.Drawing.Point(740, 71);
            this.groupBoxCompleted.Name = "groupBoxCompleted";
            this.groupBoxCompleted.Size = new System.Drawing.Size(312, 218);
            this.groupBoxCompleted.TabIndex = 2;
            this.groupBoxCompleted.TabStop = false;
            this.groupBoxCompleted.Text = "Completed";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(20, 108);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 15);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(99, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(87, 104);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(206, 23);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(30, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 32);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonMarkComplete
            // 
            this.buttonMarkComplete.Location = new System.Drawing.Point(167, 180);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(115, 32);
            this.buttonMarkComplete.TabIndex = 6;
            this.buttonMarkComplete.Text = "Mark as complete";
            this.buttonMarkComplete.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(168, 180);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 32);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // listBoxTodo
            // 
            this.listBoxTodo.FormattingEnabled = true;
            this.listBoxTodo.ItemHeight = 15;
            this.listBoxTodo.Location = new System.Drawing.Point(6, 22);
            this.listBoxTodo.Name = "listBoxTodo";
            this.listBoxTodo.Size = new System.Drawing.Size(300, 154);
            this.listBoxTodo.TabIndex = 7;
            // 
            // listBoxComplete
            // 
            this.listBoxComplete.FormattingEnabled = true;
            this.listBoxComplete.ItemHeight = 15;
            this.listBoxComplete.Location = new System.Drawing.Point(6, 22);
            this.listBoxComplete.Name = "listBoxComplete";
            this.listBoxComplete.Size = new System.Drawing.Size(300, 154);
            this.listBoxComplete.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(115, 32);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 361);
            this.Controls.Add(this.groupBoxCompleted);
            this.Controls.Add(this.groupBoxTodo);
            this.Controls.Add(this.groupBoxNewItem);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.groupBoxNewItem.ResumeLayout(false);
            this.groupBoxNewItem.PerformLayout();
            this.groupBoxTodo.ResumeLayout(false);
            this.groupBoxCompleted.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewItem;
        private System.Windows.Forms.GroupBox groupBoxTodo;
        private System.Windows.Forms.GroupBox groupBoxCompleted;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxTodo;
        private System.Windows.Forms.Button buttonMarkComplete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBoxComplete;
        private System.Windows.Forms.Button buttonClear;
    }
}
