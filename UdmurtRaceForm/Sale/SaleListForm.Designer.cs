namespace UdmurtRaceForm
{
    partial class SaleListForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridViewSales;
        private Button addBtn;
        private Button deleteBtn;
        private Button updateBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleListForm));
            dataGridViewSales = new DataGridView();
            addBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(21, 26);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.Size = new Size(1140, 604);
            dataGridViewSales.TabIndex = 0;
            dataGridViewSales.CellClick += dataGridViewSales_CellClick;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Arial", 9.8F, FontStyle.Bold);
            addBtn.Location = new Point(115, 658);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(200, 70);
            addBtn.TabIndex = 2;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Arial", 9.8F, FontStyle.Bold);
            deleteBtn.Location = new Point(507, 658);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(200, 70);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Arial", 9.8F, FontStyle.Bold);
            updateBtn.Location = new Point(848, 658);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(200, 70);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Редактировать";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // SaleListForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridViewSales);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "SaleListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продажи билетов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
        }
    }
}
