using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class SaleListForm : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly IClientRepository _clientRepository;

        public SaleListForm(ISaleRepository saleRepository,
                       IRaceRepository raceRepository,
                       IClientRepository clientRepository)
        {
            InitializeComponent();
            _saleRepository = saleRepository;
            _raceRepository = raceRepository;
            _clientRepository = clientRepository;
            LoadSales();
            RenameColumnsNames();
        }

        private void RenameColumnsNames()
        {
            dataGridViewSales.Columns[0].HeaderText = "ID";
            dataGridViewSales.Columns[1].HeaderText = "Номер рейса";
            dataGridViewSales.Columns[2].HeaderText = "Дата отправления";
            dataGridViewSales.Columns[3].HeaderText = "Время отправления";
            dataGridViewSales.Columns[4].HeaderText = "Цена билета";
            dataGridViewSales.Columns[5].HeaderText = "Имя клиента";
            dataGridViewSales.Columns[6].HeaderText = "Адрес клиента";
            dataGridViewSales.Columns[7].HeaderText = "Телефон";
            dataGridViewSales.Columns[8].HeaderText = "Статус продажи";
            dataGridViewSales.Columns[9].HeaderText = "Примечания";
            dataGridViewSales.Columns[10].HeaderText = "Создано";

            dataGridViewSales.Columns["SaleId"].Visible = true;
        }

        private void LoadSales()
        {
            var sales = _saleRepository.GetAll();

            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = sales;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddSaleForm form = new AddSaleForm(_saleRepository, _raceRepository, _clientRepository, LoadSales);
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewSales.SelectedRows[0];
            var saleId = selectedRow.Cells["SaleId"].Value;

            if (saleId == null || !int.TryParse(saleId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор продажи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var sale = _saleRepository.GetById(id);

                if (sale == null)
                {
                    MessageBox.Show("Продажа не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateSaleForm form = new UpdateSaleForm(_saleRepository, _raceRepository, _clientRepository, sale, LoadSales);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewSales.SelectedRows[0];
            var saleId = selectedRow.Cells["SaleId"].Value;

            if (saleId == null || !int.TryParse(saleId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор продажи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _saleRepository.Delete(id);
                LoadSales();
                MessageBox.Show("Продажа успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewSales.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}