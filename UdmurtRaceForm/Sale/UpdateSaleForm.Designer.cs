// UpdateSaleForm.Designer.cs
namespace UdmurtRaceForm
{
    partial class UpdateSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox raceComboBox;
        private ComboBox clientComboBox;
        private TextBox saleStatusInput;
        private TextBox notesInput;
        private Button updateBtn;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSaleForm));
            raceComboBox = new ComboBox();
            clientComboBox = new ComboBox();
            saleStatusInput = new TextBox();
            notesInput = new TextBox();
            updateBtn = new Button();
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
            raceComboBox.Location = new Point(358, 30);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(200, 32);
            raceComboBox.TabIndex = 0;
            // 
            // clientComboBox
            // 
            clientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(358, 70);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(200, 32);
            clientComboBox.TabIndex = 1;
            // 
            // saleStatusInput
            // 
            saleStatusInput.Location = new Point(358, 110);
            saleStatusInput.Name = "saleStatusInput";
            saleStatusInput.Size = new Size(200, 30);
            saleStatusInput.TabIndex = 2;
            // 
            // notesInput
            // 
            notesInput.Location = new Point(358, 150);
            notesInput.Name = "notesInput";
            notesInput.Size = new Size(200, 30);
            notesInput.TabIndex = 3;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(408, 208);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(150, 50);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Обновить";
            updateBtn.Click += updateBtn_Click;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new Point(12, 33);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(64, 24);
            raceLabel.TabIndex = 5;
            raceLabel.Text = "Рейс:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new Point(12, 73);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(86, 24);
            clientLabel.TabIndex = 6;
            clientLabel.Text = "Клиент:";
            // 
            // saleStatusLabel
            // 
            saleStatusLabel.AutoSize = true;
            saleStatusLabel.Location = new Point(12, 113);
            saleStatusLabel.Name = "saleStatusLabel";
            saleStatusLabel.Size = new Size(349, 24);
            saleStatusLabel.TabIndex = 7;
            saleStatusLabel.Text = "Статус продажи(Продан/Возврат):";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(12, 153);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(140, 24);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Примечания:";
            // 
            // UpdateSaleForm
            // 
            ClientSize = new Size(582, 270);
            Controls.Add(raceComboBox);
            Controls.Add(clientComboBox);
            Controls.Add(saleStatusInput);
            Controls.Add(notesInput);
            Controls.Add(updateBtn);
            Controls.Add(raceLabel);
            Controls.Add(clientLabel);
            Controls.Add(saleStatusLabel);
            Controls.Add(notesLabel);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UpdateSaleForm";
            Text = "Редактировать продажу";
            Load += UpdateSaleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}