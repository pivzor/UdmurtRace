namespace UdmurtRaceForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Обратите внимание на этот метод
        private void InitializeComponent()
        {
            btnManageClients = new Button();
            btnManageRaces = new Button();
            btnManageSales = new Button();
            SuspendLayout();
            // 
            // btnManageClients
            // 
            btnManageClients.Location = new Point(67, 29);
            btnManageClients.Name = "btnManageClients";
            btnManageClients.Size = new Size(200, 70);
            btnManageClients.TabIndex = 0;
            btnManageClients.Text = "Управление клиентами";
            btnManageClients.UseVisualStyleBackColor = true;
            btnManageClients.Click += btnManageClients_Click;
            // 
            // btnManageRaces
            // 
            btnManageRaces.Location = new Point(67, 113);
            btnManageRaces.Name = "btnManageRaces";
            btnManageRaces.Size = new Size(200, 70);
            btnManageRaces.TabIndex = 1;
            btnManageRaces.Text = "Управление рейсами";
            btnManageRaces.UseVisualStyleBackColor = true;
            btnManageRaces.Click += btnManageRaces_Click;
            // 
            // btnManageSales
            // 
            btnManageSales.Location = new Point(67, 196);
            btnManageSales.Name = "btnManageSales";
            btnManageSales.Size = new Size(200, 70);
            btnManageSales.TabIndex = 2;
            btnManageSales.Text = "Усправление продажами";
            btnManageSales.UseVisualStyleBackColor = true;
            btnManageSales.Click += btnManageSales_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(351, 329);
            Controls.Add(btnManageClients);
            Controls.Add(btnManageRaces);
            Controls.Add(btnManageSales);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рейсы Удмуртии";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnManageRaces;
        private System.Windows.Forms.Button btnManageSales;
    }
}
