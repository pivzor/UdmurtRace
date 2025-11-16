namespace UdmurtRaceForm
{
    partial class AddSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox raceComboBox;
        private ComboBox clientComboBox;
        private TextBox saleStatusInput;
        private TextBox notesInput;
        private Button addBtn;
        private Label raceLabel;
        private Label clientLabel;
        private Label saleStatusLabel;
        private Label notesLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSaleForm));
            raceComboBox = new ComboBox();
            clientComboBox = new ComboBox();
            saleStatusInput = new TextBox();
            notesInput = new TextBox();
            addBtn = new Button();
            raceLabel = new Label();
            clientLabel = new Label();
            saleStatusLabel = new Label();
            notesLabel = new Label();
            SuspendLayout();
            // 
            // raceComboBox
            // 
            raceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            raceComboBox.FormattingEnabled = true;
            raceComboBox.Location = new Point(363, 25);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(200, 32);
            raceComboBox.TabIndex = 0;
            // 
            // clientComboBox
            // 
            clientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(363, 65);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(200, 32);
            clientComboBox.TabIndex = 1;
            // 
            // saleStatusInput
            // 
            saleStatusInput.Location = new Point(363, 105);
            saleStatusInput.Name = "saleStatusInput";
            saleStatusInput.Size = new Size(200, 30);
            saleStatusInput.TabIndex = 2;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(363, 145);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 30);
            notesInput.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(413, 209);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 50);
            addBtn.TabIndex = 4;
            addBtn.Text = "Добавить";
            addBtn.Click += addBtn_Click;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new Point(18, 25);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(64, 24);
            raceLabel.TabIndex = 5;
            raceLabel.Text = "Рейс:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new Point(18, 65);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(86, 24);
            clientLabel.TabIndex = 6;
            clientLabel.Text = "Клиент:";
            // 
            // saleStatusLabel
            // 
            saleStatusLabel.AutoSize = true;
            saleStatusLabel.Location = new Point(18, 105);
            saleStatusLabel.Name = "saleStatusLabel";
            saleStatusLabel.Size = new Size(349, 24);
            saleStatusLabel.TabIndex = 7;
            saleStatusLabel.Text = "Статус продажи(Возврат/Продан):";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(18, 145);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(140, 24);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Примечания:";
            // 
            // AddSaleForm
            // 
            ClientSize = new Size(582, 270);
            Controls.Add(raceComboBox);
            Controls.Add(clientComboBox);
            Controls.Add(saleStatusInput);
            Controls.Add(notesInput);
            Controls.Add(addBtn);
            Controls.Add(raceLabel);
            Controls.Add(clientLabel);
            Controls.Add(saleStatusLabel);
            Controls.Add(notesLabel);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddSaleForm";
            Text = "Добавить продажу";
            Load += AddSaleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}