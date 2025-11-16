namespace UdmurtRaceForm
{
    partial class UpdateClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox lastNameInput;
        private TextBox nameInput;
        private TextBox patronymicInput;
        private TextBox emailInput;
        private TextBox phoneInput;
        private TextBox addressInput;
        private Button updateBtn;
        private Label lastNameLabel;
        private Label nameLabel;
        private Label patronymicLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label addressLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClientForm));
            lastNameInput = new TextBox();
            nameInput = new TextBox();
            patronymicInput = new TextBox();
            emailInput = new TextBox();
            phoneInput = new TextBox();
            addressInput = new TextBox();
            updateBtn = new Button();
            lastNameLabel = new Label();
            nameLabel = new Label();
            patronymicLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            addressLabel = new Label();
            SuspendLayout();
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(150, 30);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(200, 30);
            lastNameInput.TabIndex = 0;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(150, 70);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(200, 30);
            nameInput.TabIndex = 1;
            // 
            // patronymicInput
            // 
            patronymicInput.Location = new Point(150, 110);
            patronymicInput.Name = "patronymicInput";
            patronymicInput.Size = new Size(200, 30);
            patronymicInput.TabIndex = 2;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(150, 150);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(200, 30);
            emailInput.TabIndex = 3;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(150, 190);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(200, 30);
            phoneInput.TabIndex = 4;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(150, 230);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(200, 30);
            addressInput.TabIndex = 5;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(184, 266);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(149, 30);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Обновить";
            updateBtn.Click += updateBtn_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(30, 30);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(115, 24);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Фамилия :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(30, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(58, 24);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new Point(30, 110);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new Size(109, 24);
            patronymicLabel.TabIndex = 9;
            patronymicLabel.Text = "Отчество:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(30, 150);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(75, 24);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(30, 190);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(105, 24);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(30, 230);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(77, 24);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Адрес:";
            // 
            // UpdateClientForm
            // 
            ClientSize = new Size(400, 350);
            Controls.Add(lastNameInput);
            Controls.Add(nameInput);
            Controls.Add(patronymicInput);
            Controls.Add(emailInput);
            Controls.Add(phoneInput);
            Controls.Add(addressInput);
            Controls.Add(updateBtn);
            Controls.Add(lastNameLabel);
            Controls.Add(nameLabel);
            Controls.Add(patronymicLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(addressLabel);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "UpdateClientForm";
            Text = "Редактировать клиента";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
