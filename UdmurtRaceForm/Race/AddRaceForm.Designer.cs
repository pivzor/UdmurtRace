namespace UdmurtRaceForm
{
    partial class AddRaceForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox tripNumberInput;
        private TextBox departureDateInput;
        private TextBox departureTimeInput;
        private TextBox destinationInput;
        private TextBox ticketPriceInput;
        private TextBox totalSeatsInput;
        private TextBox tripDescriptionInput;
        private Button addBtn;
        private Label tripNumberLabel;
        private Label departureDateLabel;
        private Label departureTimeLabel;
        private Label destinationLabel;
        private Label ticketPriceLabel;
        private Label totalSeatsLabel;
        private Label tripDescriptionLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRaceForm));
            tripNumberInput = new TextBox();
            departureDateInput = new TextBox();
            departureTimeInput = new TextBox();
            destinationInput = new TextBox();
            ticketPriceInput = new TextBox();
            totalSeatsInput = new TextBox();
            tripDescriptionInput = new TextBox();
            addBtn = new Button();
            tripNumberLabel = new Label();
            departureDateLabel = new Label();
            departureTimeLabel = new Label();
            destinationLabel = new Label();
            ticketPriceLabel = new Label();
            totalSeatsLabel = new Label();
            tripDescriptionLabel = new Label();
            SuspendLayout();
            // 
            // tripNumberInput
            // 
            tripNumberInput.Location = new Point(370, 27);
            tripNumberInput.Name = "tripNumberInput";
            tripNumberInput.Size = new Size(200, 30);
            tripNumberInput.TabIndex = 0;
            // 
            // departureDateInput
            // 
            departureDateInput.Location = new Point(370, 70);
            departureDateInput.Name = "departureDateInput";
            departureDateInput.Size = new Size(200, 30);
            departureDateInput.TabIndex = 1;
            // 
            // departureTimeInput
            // 
            departureTimeInput.Location = new Point(370, 110);
            departureTimeInput.Name = "departureTimeInput";
            departureTimeInput.Size = new Size(200, 30);
            departureTimeInput.TabIndex = 2;
            // 
            // destinationInput
            // 
            destinationInput.Location = new Point(370, 150);
            destinationInput.Name = "destinationInput";
            destinationInput.Size = new Size(200, 30);
            destinationInput.TabIndex = 3;
            // 
            // ticketPriceInput
            // 
            ticketPriceInput.Location = new Point(370, 194);
            ticketPriceInput.Name = "ticketPriceInput";
            ticketPriceInput.Size = new Size(200, 30);
            ticketPriceInput.TabIndex = 4;
            // 
            // totalSeatsInput
            // 
            totalSeatsInput.Location = new Point(370, 230);
            totalSeatsInput.Name = "totalSeatsInput";
            totalSeatsInput.Size = new Size(200, 30);
            totalSeatsInput.TabIndex = 5;
            // 
            // tripDescriptionInput
            // 
            tripDescriptionInput.Location = new Point(370, 270);
            tripDescriptionInput.Name = "tripDescriptionInput";
            tripDescriptionInput.Size = new Size(200, 30);
            tripDescriptionInput.TabIndex = 6;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(399, 329);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 50);
            addBtn.TabIndex = 7;
            addBtn.Text = "Добавить";
            addBtn.Click += addBtn_Click;
            // 
            // tripNumberLabel
            // 
            tripNumberLabel.AutoSize = true;
            tripNumberLabel.Location = new Point(30, 30);
            tripNumberLabel.Name = "tripNumberLabel";
            tripNumberLabel.Size = new Size(144, 24);
            tripNumberLabel.TabIndex = 8;
            tripNumberLabel.Text = "Номер рейса:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new Point(30, 70);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new Size(311, 24);
            departureDateLabel.TabIndex = 9;
            departureDateLabel.Text = "Дата отправления (11.11.1111):";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new Point(30, 110);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new Size(284, 24);
            departureTimeLabel.TabIndex = 10;
            departureTimeLabel.Text = "Время отправления (11:11):";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(30, 150);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(194, 24);
            destinationLabel.TabIndex = 11;
            destinationLabel.Text = "Пункт назначения:";
            // 
            // ticketPriceLabel
            // 
            ticketPriceLabel.AutoSize = true;
            ticketPriceLabel.Location = new Point(30, 190);
            ticketPriceLabel.Name = "ticketPriceLabel";
            ticketPriceLabel.Size = new Size(140, 24);
            ticketPriceLabel.TabIndex = 12;
            ticketPriceLabel.Text = "Цена билета:";
            // 
            // totalSeatsLabel
            // 
            totalSeatsLabel.AutoSize = true;
            totalSeatsLabel.Location = new Point(30, 230);
            totalSeatsLabel.Name = "totalSeatsLabel";
            totalSeatsLabel.Size = new Size(257, 24);
            totalSeatsLabel.TabIndex = 13;
            totalSeatsLabel.Text = "Общее количество мест:";
            // 
            // tripDescriptionLabel
            // 
            tripDescriptionLabel.AutoSize = true;
            tripDescriptionLabel.Location = new Point(30, 270);
            tripDescriptionLabel.Name = "tripDescriptionLabel";
            tripDescriptionLabel.Size = new Size(177, 24);
            tripDescriptionLabel.TabIndex = 14;
            tripDescriptionLabel.Text = "Описание рейса:";
            // 
            // AddRaceForm
            // 
            ClientSize = new Size(582, 403);
            Controls.Add(tripNumberInput);
            Controls.Add(departureDateInput);
            Controls.Add(departureTimeInput);
            Controls.Add(destinationInput);
            Controls.Add(ticketPriceInput);
            Controls.Add(totalSeatsInput);
            Controls.Add(tripDescriptionInput);
            Controls.Add(addBtn);
            Controls.Add(tripNumberLabel);
            Controls.Add(departureDateLabel);
            Controls.Add(departureTimeLabel);
            Controls.Add(destinationLabel);
            Controls.Add(ticketPriceLabel);
            Controls.Add(totalSeatsLabel);
            Controls.Add(tripDescriptionLabel);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddRaceForm";
            Text = "Добавить рейс";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
