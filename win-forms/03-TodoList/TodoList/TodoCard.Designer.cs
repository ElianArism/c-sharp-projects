namespace TodoList
{
    partial class TodoCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateTodo = new System.Windows.Forms.Button();
            this.deleteTodo = new System.Windows.Forms.Button();
            this.todoTitle = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateTodo
            // 
            this.updateTodo.Location = new System.Drawing.Point(1041, 37);
            this.updateTodo.Name = "updateTodo";
            this.updateTodo.Size = new System.Drawing.Size(94, 29);
            this.updateTodo.TabIndex = 0;
            this.updateTodo.Text = "Update";
            this.updateTodo.UseVisualStyleBackColor = true;
            // 
            // deleteTodo
            // 
            this.deleteTodo.Location = new System.Drawing.Point(932, 37);
            this.deleteTodo.Name = "deleteTodo";
            this.deleteTodo.Size = new System.Drawing.Size(94, 29);
            this.deleteTodo.TabIndex = 1;
            this.deleteTodo.Text = "Delete";
            this.deleteTodo.UseVisualStyleBackColor = true;
            this.deleteTodo.Click += new System.EventHandler(this.deleteTodo_Click);
            // 
            // todoTitle
            // 
            this.todoTitle.Location = new System.Drawing.Point(14, 39);
            this.todoTitle.Name = "todoTitle";
            this.todoTitle.ReadOnly = true;
            this.todoTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.todoTitle.Size = new System.Drawing.Size(350, 27);
            this.todoTitle.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateLabel.Location = new System.Drawing.Point(14, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(85, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date Hello ";
            // 
            // TodoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.todoTitle);
            this.Controls.Add(this.deleteTodo);
            this.Controls.Add(this.updateTodo);
            this.Name = "TodoCard";
            this.Size = new System.Drawing.Size(1169, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateTodo;
        private Button deleteTodo;
        private TextBox todoTitle;
        private Label dateLabel;
    }
}
