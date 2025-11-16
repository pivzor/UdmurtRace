using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class AddClientForm : Form
    {
        private readonly IClientRepository _repository;
        private Action _loadClients;

        public AddClientForm(IClientRepository repository, Action loadClients)
        {
            InitializeComponent();
            _repository = repository;
            _loadClients = loadClients;
        }

        private void addBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Введите корректный email (например: ivan@gmail.com).", "Ошибка",
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
                var client = new ClientEntity
                {
                    LastName = lastNameInput.Text,
                    Name = nameInput.Text,
                    Patronymic = patronymicInput.Text,
                    Email = emailInput.Text,
                    PhoneNumber = phoneInput.Text,
                    Address = addressInput.Text
                };

                _repository.Add(client);
                MessageBox.Show("Клиент успешно добавлен!");
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