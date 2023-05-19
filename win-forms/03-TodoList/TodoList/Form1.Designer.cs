namespace TodoList
{
    partial class TodoListContainer
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
            this.todoTitle = new System.Windows.Forms.Label();
            this.addTodoBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.todosContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoTitle
            // 
            this.todoTitle.AutoSize = true;
            this.todoTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todoTitle.Location = new System.Drawing.Point(3, 9);
            this.todoTitle.Name = "todoTitle";
            this.todoTitle.Size = new System.Drawing.Size(154, 46);
            this.todoTitle.TabIndex = 0;
            this.todoTitle.Text = "Todo List";
            // 
            // addTodoBtn
            // 
            this.addTodoBtn.Location = new System.Drawing.Point(1023, 12);
            this.addTodoBtn.Name = "addTodoBtn";
            this.addTodoBtn.Size = new System.Drawing.Size(135, 43);
            this.addTodoBtn.TabIndex = 2;
            this.addTodoBtn.Text = "Add";
            this.addTodoBtn.UseVisualStyleBackColor = true;
            this.addTodoBtn.Click += new System.EventHandler(this.addTodoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addTodoBtn);
            this.panel1.Controls.Add(this.todoTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 88);
            this.panel1.TabIndex = 2;
            // 
            // todosContainer
            // 
            this.todosContainer.AutoScroll = true;
            this.todosContainer.ColumnCount = 1;
            this.todosContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.todosContainer.Location = new System.Drawing.Point(3, 94);
            this.todosContainer.MaximumSize = new System.Drawing.Size(1161, 701);
            this.todosContainer.Name = "todosContainer";
            this.todosContainer.RowCount = 1;
            this.todosContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.todosContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.todosContainer.Size = new System.Drawing.Size(1161, 701);
            this.todosContainer.TabIndex = 3;
            // 
            // TodoListContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 799);
            this.Controls.Add(this.todosContainer);
            this.Controls.Add(this.panel1);
            this.Name = "TodoListContainer";
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.TodoListContainer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label todoTitle;
        private Button addTodoBtn;
        private Panel panel1;
        private TableLayoutPanel todosContainer;
    }
}