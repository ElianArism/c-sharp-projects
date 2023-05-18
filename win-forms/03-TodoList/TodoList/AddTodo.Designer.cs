namespace TodoList
{
    partial class AddTodoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.todoTitleLabel = new System.Windows.Forms.Label();
            this.addTodoBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleInput);
            this.panel1.Controls.Add(this.descInput);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.todoTitleLabel);
            this.panel1.Controls.Add(this.addTodoBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 799);
            this.panel1.TabIndex = 0;
            // 
            // titleInput
            // 
            this.titleInput.AcceptsTab = true;
            this.titleInput.AllowDrop = true;
            this.titleInput.Location = new System.Drawing.Point(14, 88);
            this.titleInput.Multiline = true;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(1162, 51);
            this.titleInput.TabIndex = 4;
            // 
            // descInput
            // 
            this.descInput.AcceptsTab = true;
            this.descInput.AllowDrop = true;
            this.descInput.Location = new System.Drawing.Point(14, 291);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(1148, 367);
            this.descInput.TabIndex = 3;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(3, 249);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(188, 39);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Description";
            // 
            // todoTitleLabel
            // 
            this.todoTitleLabel.AutoSize = true;
            this.todoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todoTitleLabel.Location = new System.Drawing.Point(3, 46);
            this.todoTitleLabel.Name = "todoTitleLabel";
            this.todoTitleLabel.Size = new System.Drawing.Size(82, 39);
            this.todoTitleLabel.TabIndex = 1;
            this.todoTitleLabel.Text = "Title";
            // 
            // addTodoBtn
            // 
            this.addTodoBtn.Location = new System.Drawing.Point(468, 723);
            this.addTodoBtn.Name = "addTodoBtn";
            this.addTodoBtn.Size = new System.Drawing.Size(288, 64);
            this.addTodoBtn.TabIndex = 0;
            this.addTodoBtn.Text = "Add";
            this.addTodoBtn.UseVisualStyleBackColor = true;
            this.addTodoBtn.Click += new System.EventHandler(this.addTodoBtn_Click);
            // 
            // AddTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 799);
            this.Controls.Add(this.panel1);
            this.Name = "AddTodoForm";
            this.Text = "Add Todo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button addTodoBtn;
        private TextBox titleInput;
        private TextBox descInput;
        private Label descLabel;
        private Label todoTitleLabel;
    }
}
