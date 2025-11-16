using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class UpdateClientForm : Form
    {
        private readonly IClientRepository _repository;
        private ClientEntity _currentClient;
        private Action _loadClients;

        public UpdateClientForm(IClientRepository repository, ClientEntity client, Action loadClients)
        {
            InitializeComponent();
            _repository = repository;
            _currentClient = client;
            _loadClients = loadClients;

            lastNameInput.Text = _currentClient.LastName;
            nameInput.Text = _currentClient.Name;
            patronymicInput.Text = _currentClient.Patronymic;
            emailInput.Text = _currentClient.Email;
            phoneInput.Text = _currentClient.PhoneNumber;
            addressInput.Text = _currentClient.Address;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameInput.Text) ||
                string.IsNullOrWhiteSpace(nameInput.Text) ||
                string.IsNullOrWhiteSpace(patronymicInput.Text))
            {
                MessageBox.Show("Фамилия, имя и отчество не должны быть пустыми.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = emailInput.Text;
            if (!string.IsNullOrWhiteSpace(email))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    MessageBox.Show("Введите корректный email (например: asdf@gmail.com).", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string phone = phoneInput.Text;
            if (!string.IsNullOrWhiteSpace(phone))
            {
                string phonePattern = @"^\+7\d{10}$";
                if (!Regex.IsMatch(phone, phonePattern))
                {
                    MessageBox.Show("Введите корректный номер телефона в формате +7XXXXXXXXXX (например: +71234567890).",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                _currentClient.LastName = lastNameInput.Text;
                _currentClient.Name = nameInput.Text;
                _currentClient.Patronymic = patronymicInput.Text;
                _currentClient.Email = emailInput.Text;
                _currentClient.PhoneNumber = phoneInput.Text;
                _currentClient.Address = addressInput.Text;

                _repository.Update(_currentClient);
                MessageBox.Show("Клиент успешно обновлен!");
                _loadClients?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}