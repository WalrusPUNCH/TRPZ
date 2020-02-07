namespace OrderMakingApp
{
    partial class Form1
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
            this.TableMenu = new System.Windows.Forms.DataGridView();
            this.MakeOrderButton = new System.Windows.Forms.Button();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishCuisine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishCookingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOrderedDishColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMenu
            // 
            this.TableMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.DishWeight,
            this.DishCuisine,
            this.DishCookingTime,
            this.IsOrderedDishColumn});
            this.TableMenu.Location = new System.Drawing.Point(12, 12);
            this.TableMenu.Name = "TableMenu";
            this.TableMenu.RowHeadersWidth = 51;
            this.TableMenu.RowTemplate.Height = 24;
            this.TableMenu.Size = new System.Drawing.Size(1114, 350);
            this.TableMenu.TabIndex = 0;
            // 
            // MakeOrderButton
            // 
            this.MakeOrderButton.Location = new System.Drawing.Point(496, 368);
            this.MakeOrderButton.Name = "MakeOrderButton";
            this.MakeOrderButton.Size = new System.Drawing.Size(195, 70);
            this.MakeOrderButton.TabIndex = 1;
            this.MakeOrderButton.Text = "Замовити";
            this.MakeOrderButton.UseVisualStyleBackColor = true;
            this.MakeOrderButton.Click += new System.EventHandler(this.MakeOrderButton_Click);
            // 
            // DishName
            // 
            this.DishName.DataPropertyName = "Name";
            this.DishName.HeaderText = "Страва";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.Width = 125;
            // 
            // DishWeight
            // 
            this.DishWeight.DataPropertyName = "WeightInGrams";
            this.DishWeight.HeaderText = "Вага (г.)";
            this.DishWeight.MinimumWidth = 6;
            this.DishWeight.Name = "DishWeight";
            this.DishWeight.Width = 125;
            // 
            // DishCuisine
            // 
            this.DishCuisine.DataPropertyName = "Cuisine";
            this.DishCuisine.HeaderText = "Кухня";
            this.DishCuisine.MinimumWidth = 6;
            this.DishCuisine.Name = "DishCuisine";
            this.DishCuisine.Width = 125;
            // 
            // DishCookingTime
            // 
            this.DishCookingTime.DataPropertyName = "CookingTime";
            this.DishCookingTime.HeaderText = "Час готування";
            this.DishCookingTime.MinimumWidth = 6;
            this.DishCookingTime.Name = "DishCookingTime";
            this.DishCookingTime.Width = 125;
            // 
            // IsOrderedDishColumn
            // 
            this.IsOrderedDishColumn.HeaderText = "Обрати";
            this.IsOrderedDishColumn.MinimumWidth = 6;
            this.IsOrderedDishColumn.Name = "IsOrderedDishColumn";
            this.IsOrderedDishColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.MakeOrderButton);
            this.Controls.Add(this.TableMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableMenu;
        private System.Windows.Forms.Button MakeOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishCuisine;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishCookingTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOrderedDishColumn;
    }
}

