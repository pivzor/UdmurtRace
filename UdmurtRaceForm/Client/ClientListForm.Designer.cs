namespace UdmurtRaceForm
{
    partial class ClientListForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridViewClients;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListForm));
            dataGridViewClients = new DataGridView();
            addBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(21, 26);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(933, 602);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Arial", 9.8F, FontStyle.Bold);
            addBtn.Location = new Point(21, 650);
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
            deleteBtn.Location = new Point(413, 650);
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
            updateBtn.Location = new Point(754, 650);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(200, 70);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Редактировать";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // ClientListForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridViewClients);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "ClientListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }
    }
}
