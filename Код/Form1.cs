using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cursach.Model;
using Cursach.Properties;
using Cursach.Utils;
using Cursach.View.EditForms;
using Cursach.View.Filters;
using Cursach.ViewHelpers;
using static System.Char;

namespace Cursach.View
{
    /// <summary>
    /// Главная форма приложения, объединяющая весь функционал программы. "Ядро" приложения
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Мета-данные таблиц
        /// </summary>
        private MetaInfo _metaInfo;

        //Коллекции таблиц
        private List<Person> _personCollection;
        private List<Service> _serviceCollection;
        private List<Household> _householdsCollection;

        //Выбранные элементы в таблице
        private Person _selectedPerson;
        private Service _selectedService;
        private Household _selectedHousehold;

        //Привязка коллекций к view элементам gridView
        private readonly BindingSource _personSource;
        private readonly BindingSource _serviceSource;
        private readonly BindingSource _householdSource;

        //Флаги, указывающие на существования формы с фильтрами
        private bool _isPersonFilterActive;
        private bool _isServiceFilterActive;
        private bool _isHouseholdFilterActive;

        //Флаг, указывающий на состояние файла из другого приложения
        private bool _isExternalFile = false;

        //Путь к внешнему из системы файлу
        private string _externaalFileName;

        //Тип внешней таблице
        private FileType _fileType;

        //Внешняя таблица - таблица, находящаяся вне каталога приложения

        /// <summary>
        /// Инициализация формы и скачивания таблиц из внешнего файла.
        /// Инициализация привязок данных к таблицам
        /// </summary>
        public Form1()
        {
            Application.Run(new SplashScreen());
            InitializeComponent();

            var db = DbContext.GetInstance();
            _metaInfo = db.ReadMetaInfo();

            _personSource = new BindingSource();
            _isPersonFilterActive = false;
            _personCollection = TableConverter.ConvertToPerson(db.ReadFile(DbContext.FILE_NAME.owners));
            if (_personCollection == null || _personCollection.Count == 0)
            {
                _personCollection = new List<Person>();
            }
            else
            {
                _selectedPerson = _personCollection[0];
            }

            _personSource.DataSource = _personCollection;
            TableHelper.SetupPersonTable(dataGridView1, _personSource);

            _serviceSource = new BindingSource();
            _serviceCollection = TableConverter.ConvertToService(db.ReadFile(DbContext.FILE_NAME.service));
            if (_serviceCollection == null || _serviceCollection.Count == 0)
            {
                _serviceCollection = new List<Service>();
            }
            else
            {
                _selectedService = _serviceCollection[0];
            }

            _serviceSource.DataSource = _serviceCollection;
            TableHelper.SetupServiceTable(dataGridViewService, _serviceSource);

            _householdSource = new BindingSource();
            _householdsCollection = TableConverter.ConvertToHousehold(db.ReadFile(DbContext.FILE_NAME.household));
            if (_householdsCollection == null || _householdsCollection.Count == 0)
            {
                _householdsCollection = new List<Household>();
            }
            else
            {
                _selectedHousehold = _householdsCollection[0];
            }

            _householdSource.DataSource = _householdsCollection;
            TableHelper.SetupHouseholdTable(dataGridViewHouse, _householdSource);
        }

        #region Логика таблицы Person

        /// <summary>
        /// Вызывается при нажатии ПКМ на элемент таблицы. Вызов контекстного меню
        /// </summary>
        private void DataGridViewPerson_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var m = new ContextMenu();
            var currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            var delItem = new MenuItem("Удалить");
            var receiptMenu =
                new MenuItem("Посмотреть счет");
            if (currentMouseOverRow >= 0)
            {
                if (_selectedPerson?.Receipts != null && _selectedPerson.Receipts.Count > 0)
                {
                    receiptMenu.Click += ReceiptMenu_Click;
                    m.MenuItems.Add(receiptMenu);
                }

                var changeItem = new MenuItem("Изменить");
                delItem.Click += DelItem_Click;
                changeItem.Click += ChangeItem_Click;
                m.MenuItems.Add(delItem);
                m.MenuItems.Add(changeItem);
            }

            m.Show(dataGridView1, new Point(e.X, e.Y));
        }
        
        /// <summary>
        /// Вызывается при нажатии на пункт меню "Посмотреть счет" в таблице "Жильцы"
        /// </summary>
        private void ReceiptMenu_Click(object sender, EventArgs e)
        {
            if (_selectedPerson == null) return;
            var form = new ReceiptForm(_metaInfo, _selectedPerson);
            form.FormClosed += ReceiptForm_FormClosed;
            form.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при закрытии формы отображения квитанций
        /// </summary>
        private void ReceiptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Изменить" в таблице "Жильцы"
        /// </summary>
        private void ChangeItem_Click(object sender, EventArgs e)
        {
            if (_selectedPerson == null) return;
            var changeForm = new PersonEdit(_selectedPerson);
            changeForm.FormClosed += ChangeForm_FormClosed;
            changeForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Удалить" в таблице "Жильцы"
        /// </summary>
        private void DelItem_Click(object sender, EventArgs e)
        {
            _personSource.RemoveCurrent();
            _selectedPerson = null;
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Добавить запись" в таблице "Жильцы"
        /// </summary>
        private void BtnPersonAdd_Click(object sender, EventArgs e)
        {
            var name = tb_fullname.Text;
            var flat = tb_flatNum.Text;
            var count = tb_resCount.Text;
            if (!(name != "" & flat != "" & count != "")) return;
            var isCollision = _personCollection.Exists(p => p.FlatNumber == Convert.ToInt32(tb_flatNum.Text));
            if (!isCollision)
            {
                _personSource.DataSource = _personCollection;
                ChangeFilterButtonState(btnPersonFilter, false);
                var person = new Person(_metaInfo.PersonNumber++, tb_fullname.Text, Convert.ToInt32(tb_flatNum.Text),
                    Convert.ToInt32(tb_resCount.Text));
                _personSource.Add(person);
                tb_fullname.Text = "";
                tb_flatNum.Text = "";
                tb_resCount.Text = "";
            }
            else
            {
                MessageBox.Show(Resources.PersonAddFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Фильтры" в таблице "Жильцы"
        /// </summary>
        private void BtnPersonFilter_Click(object sender, EventArgs e)
        {
            if (_isPersonFilterActive) return;
            _isPersonFilterActive = true;
            var filterForm = new PersonFilters();
            filterForm.ButtonSortEvent += FilterForm_ButtonEvent;
            filterForm.ButtonSearchEvent += FilterForm_ButtonSearchEvent;
            filterForm.ButtonGroupEvent += FilterForm_ButtonGroupEvent;
            filterForm.FormClosed += FilterForm_FormClosed;
            filterForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при закрытии формы фильтров для таблицы "Жильцы"
        /// </summary>
        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isPersonFilterActive = false;
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при сортировки таблицы "Жильцы"
        /// </summary>
        private void FilterForm_ButtonEvent(IEnumerable<FilterInfo> data, bool isAsc)
        {
            var list = data.ToList();
            if (list.Count == 0) return;
            var first = list[0].ST;
            IOrderedEnumerable<Person> result = null;
            if (isAsc)
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_NAME:
                        result = _personCollection.OrderBy(u => u.Fullname);
                        break;
                    case FilterInfo.SortType.BY_COUNT:
                        result = _personCollection.OrderBy(u => u.ResidentsNumber);
                        break;
                    case FilterInfo.SortType.BY_FLAT:
                        result = _personCollection.OrderBy(u => u.FlatNumber);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_NAME:
                            result = result.ThenBy(u => u.Fullname);
                            break;
                        case FilterInfo.SortType.BY_COUNT:
                            result = result.ThenBy(u => u.ResidentsNumber);
                            break;
                        case FilterInfo.SortType.BY_FLAT:
                            result = result.ThenBy(u => u.FlatNumber);
                            break;
                    }
                }
            }
            else
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_NAME:
                        result = _personCollection.OrderByDescending(u => u.Fullname);
                        break;
                    case FilterInfo.SortType.BY_COUNT:
                        result = _personCollection.OrderByDescending(u => u.ResidentsNumber);
                        break;
                    case FilterInfo.SortType.BY_FLAT:
                        result = _personCollection.OrderByDescending(u => u.FlatNumber);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_NAME:
                            result = result.ThenByDescending(u => u.Fullname);
                            break;
                        case FilterInfo.SortType.BY_COUNT:
                            result = result.ThenByDescending(u => u.ResidentsNumber);
                            break;
                        case FilterInfo.SortType.BY_FLAT:
                            result = result.ThenByDescending(u => u.FlatNumber);
                            break;
                    }
                }
            }
            ChangeFilterButtonState(btnPersonFilter, true);
            _personSource.DataSource = result.ToList();
        }

        /// <summary>
        /// Вызывается при группировке таблицы "Жильцы"
        /// </summary>
        private void FilterForm_ButtonGroupEvent(FilterInfo.GroupType groupType, int min, int max)
        {
            IEnumerable<Person> res = null;
            switch (groupType)
            {
                case FilterInfo.GroupType.COUNT:
                    res = _personCollection.Where(p => p.ResidentsNumber >= min & p.ResidentsNumber <= max);
                    break;

                case FilterInfo.GroupType.FLAT:
                    res = _personCollection.Where(p => p.FlatNumber >= min & p.FlatNumber <= max);
                    break;
            }

            if (res.Count() != 0)
            {
                ChangeFilterButtonState(btnPersonFilter, true);
                _personSource.DataSource = res.ToList();
            }
            else
            {
                MessageBox.Show(Resources.GroupFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при поиске в таблице "Жильцы"
        /// </summary>
        private void FilterForm_ButtonSearchEvent(FilterInfo.SearchType searchType, string data)
        {
            if (data == "") return;
            IEnumerable<Person> res = null;
            object x;
            if (searchType == FilterInfo.SearchType.NAME)
            {
                x = data;
            }
            else
            {
                try
                {
                    x = Convert.ToInt32(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
                    return;
                }
            }

            switch (searchType)
            {
                case FilterInfo.SearchType.NAME:
                    res = _personCollection.Where(p => p.Fullname.ToLower().Contains(((string) x).ToLower()));
                    break;
                case FilterInfo.SearchType.COUNT:
                    res = _personCollection.Where(p => p.ResidentsNumber == (int) x);
                    break;

                case FilterInfo.SearchType.FLAT:
                    res = _personCollection.Where(p => p.FlatNumber == (int) x);
                    break;
            }

            if (res.Count() != 0)
            {
                _personSource.DataSource = res;
                ChangeFilterButtonState(btnPersonFilter, true);
            }
            else
            {
                MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Сбросить фильтры" в таблице "Жильцы"
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            _personSource.DataSource = _personCollection;
            ChangeFilterButtonState(btnPersonFilter, false);
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Добавить счет" в таблице "Жильцы"
        /// </summary>
        private void BtnPersonReceiptAdd_Click(object sender, EventArgs e)
        {
            if (_selectedPerson == null) return;
            var form = new ReceiptAdd(_selectedPerson);
            form.OnAddEvent += Form_OnAddEvent;
            form.Show();
            form.FormClosed += ReceiptAdd_FormClosed;
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при закрытии формы с добавление квитанции
        /// </summary>
        private void ReceiptAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при добавлении новой квитанции в таблице "Жильцы"
        /// </summary>
        private void Form_OnAddEvent(string name, string date, double d)
        {
            if (_selectedPerson.Receipts == null)
            {
                _selectedPerson.Receipts = new List<Receipt>();
            }

            var receipt = new Receipt(_metaInfo.ReceiptNumber++, name, date, d);
            _selectedPerson.Receipts.Add(receipt);
        }

        /// <summary>
        /// Вызывается при изменении выбраной записи в таблице "Жильцы"
        /// </summary>
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0) return;
            var index = dataGridView1.SelectedCells[0].RowIndex;
            _selectedPerson = (Person) _personSource[index];
        }

        #endregion

        #region Логика таблицы Service

        /// <summary>
        /// Вызывается при нажатии на кнопку "Добавить запись" в таблице "Расходы на обслуживание"
        /// </summary>
        private void BtnServiceAdd_Click(object sender, EventArgs e)
        {
            var name = tbServiceName.Text;
            var cost = tbServiceCost.Text;
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            if (!(name != "" & cost != "")) return;
            var isCollesion = _serviceCollection.Exists(s => s.Date == date & s.Title == name);
            if (!isCollesion)
            {
                ChangeFilterButtonState(btnFilters, false);
                _serviceSource.DataSource = _serviceCollection;
                var service = new Service(_metaInfo.ServiceNumber++, name, date, Convert.ToDouble(cost));
                _serviceSource.Add(service);
                tbServiceName.Text = "";
                tbServiceCost.Text = "";
            }
            else
            {
                MessageBox.Show(Resources.ServiceAddErrorMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при вызове контекстного меню в таблице "Расходы на обслуживание"
        /// </summary>
        private void DataGridViewService_MouseClick(object sender, MouseEventArgs e)
        {
            TableHelper.CreateMenu(dataGridViewService, e, _selectedService,
                ServiceDelItem_Click, ServiceChangeItem_Click);
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Изменить" в таблице "Расходы на обслуживание"
        /// </summary>
        private void ServiceChangeItem_Click(object sender, EventArgs e)
        {
            if (_selectedService == null) return;
            var changeForm = new ServiceEdit(_selectedService);
            changeForm.FormClosed += ChangeForm_FormClosed;
            changeForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Удалить" в таблице "Расходы на обслуживание"
        /// </summary>
        private void ServiceDelItem_Click(object sender, EventArgs e)
        {
            _serviceSource.RemoveCurrent();
            _selectedService = null;
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Фильтры" в таблице "Расходы на обслуживание"
        /// </summary>
        private void BtnServiceFilters_Click(object sender, EventArgs e)
        {
            if (_isServiceFilterActive) return;
            _isServiceFilterActive = true;
            var filterForm = new ServiceFilters();
            filterForm.ButtonSortEvent += ServiceFilterForm_ButtonSortEvent;
            filterForm.ButtonSearchEvent += ServiceFilterForm_ButtonSearchEvent;
            filterForm.ButtonGroupEvent += ServiceFilterForm_ButtonGroupEvent;
            filterForm.FormClosed += ServiceFilterForm_FormClosed;
            filterForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при закрытии фильтров таблицы "Расходы на обслуживание"
        /// </summary>
        private void ServiceFilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isServiceFilterActive = false;
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при группировки таблицы "Расходы на обслуживание"
        /// </summary>
        private void ServiceFilterForm_ButtonGroupEvent(FilterInfo.GroupType groupType, int min, int max, string dateLow,
            string dateHigh)
        {
            IEnumerable<Service> res = null;
            switch (groupType)
            {
                case FilterInfo.GroupType.FINAL_COST:
                    res = _serviceCollection.Where(p => p.Cost >= min & p.Cost <= max);
                    break;

                case FilterInfo.GroupType.DATE:
                    res = _serviceCollection.Where(p =>
                        p.Date.CompareTo(dateLow) >= 0 & p.Date.CompareTo(dateHigh) <= 0);
                    break;
            }

            if (res.Count() != 0)
            {
                _serviceSource.DataSource = res;
                ChangeFilterButtonState(btnFilters, true);
            }
            else
            {
                MessageBox.Show(Resources.GroupFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при поиске записи в таблице "Расходы на обслуживание"
        /// </summary>
        private void ServiceFilterForm_ButtonSearchEvent(FilterInfo.SearchType searchType, string data)
        {
            if (data == "") return;
            IEnumerable<Service> res = null;
            object x;
            if (searchType == FilterInfo.SearchType.FINAL_COST)
            {
                try
                {
                    x = Convert.ToDouble(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
                    return;
                }
            }
            else
            {
                x = data;
            }

            switch (searchType)
            {
                case FilterInfo.SearchType.SERVICE_NAME:
                    res = _serviceCollection.Where(p => p.Title.ToLower().Contains(((string) x).ToLower()));
                    break;
                case FilterInfo.SearchType.DATE:
                    res = _serviceCollection.Where(p => p.Date.Contains((string) x));
                    break;

                case FilterInfo.SearchType.FINAL_COST:
                    res = _serviceCollection.Where(p => p.Cost == (double) x);
                    break;
            }

            if (res.Count() != 0)
            {
                _serviceSource.DataSource = res;
                ChangeFilterButtonState(btnFilters, true);
            }
            else
            {
                MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при группировки таблицы "Расходы на обслуживание"
        /// </summary>
        private void ServiceFilterForm_ButtonSortEvent(IEnumerable<FilterInfo> data, bool isASC)
        {
            var list = data.ToList();
            if (list.Count == 0) return;
            var first = list[0].ST;
            IOrderedEnumerable<Service> result = null;
            if (isASC)
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_SERVICE_NAME:
                        result = _serviceCollection.OrderBy(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _serviceCollection.OrderBy(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _serviceCollection.OrderBy(u => u.Cost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_SERVICE_NAME:
                            result = result.ThenBy(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.ThenBy(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.ThenBy(u => u.Cost);
                            break;
                    }
                }
            }
            else
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_SERVICE_NAME:
                        result = _serviceCollection.OrderByDescending(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _serviceCollection.OrderByDescending(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _serviceCollection.OrderByDescending(u => u.Cost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_SERVICE_NAME:
                            result = result.OrderByDescending(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.OrderByDescending(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.OrderByDescending(u => u.Cost);
                            break;
                    }
                }
            }

            ChangeFilterButtonState(btnFilters, true);
            _serviceSource.DataSource = result.ToList();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Сбросить фильтры" в таблице "Расходы на обслуживание"
        /// </summary>
        private void BtnServiceClear_Click(object sender, EventArgs e)
        {
            _serviceSource.DataSource = _serviceCollection;
            ChangeFilterButtonState(btnFilters, false);
        }

        /// <summary>
        /// Вызывается при изменении выбранного элемента таблицы "Расходы на обслуживание"
        /// </summary>
        private void DataGridViewService_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedCells.Count <= 0) return;
            var index = dataGridViewService.SelectedCells[0].RowIndex;
            _selectedService = (Service) _serviceSource[index];
        }

        #endregion

        #region Логика таблицы Household

        /// <summary>
        /// Вызывается при нажатии на кнопку "Добавить запись" таблицы "Хоз.расходы"
        /// </summary>
        private void BtnHouseAdd_Click(object sender, EventArgs e)
        {
            if (tbHouseName.Text.Length <= 0 || tbHouseCount.Text.Length <= 0 || tbHouseCost.Text.Length <= 0) return;
            var name = tbHouseName.Text;
            var count = Convert.ToInt32(tbHouseCount.Text);
            var cost = Convert.ToInt32(tbHouseCost.Text);
            var date = DateTime.Now.ToString("dd.MM.yyyy");

            if (count > 0 && cost > 0)
            {
                ChangeFilterButtonState(btnHouseFilter, false);
                _householdSource.DataSource = _householdsCollection;
                var household = new Household(_metaInfo.HouseholdNumber++, name, date, count, cost, count * cost);
                _householdSource.Add(household);

                tbHouseName.Text = "";
                tbHouseCount.Text = "";
                tbHouseCost.Text = "";
            }
            else
            {
                MessageBox.Show(Resources.HouseholdAddFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при вызове контекстного меню таблицы "Хоз.расходы"
        /// </summary>
        private void DataGridViewHouse_MouseClick(object sender, MouseEventArgs e)
        {
            TableHelper.CreateMenu(dataGridViewHouse, e, _selectedHousehold,
                HouseholdDelItem_Click, HouseholdChangeItem_Click);
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Изменить" таблицы "Хоз.расходы"
        /// </summary>
        private void HouseholdChangeItem_Click(object sender, EventArgs e)
        {
            if (_selectedService == null) return;
            var changeForm = new HouseholdEdit(_selectedHousehold);
            changeForm.FormClosed += ChangeForm_FormClosed;
            changeForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Удалить" таблицы "Хоз.расходы"
        /// </summary>
        private void HouseholdDelItem_Click(object sender, EventArgs e)
        {
            _householdSource.RemoveCurrent();
            _selectedHousehold = null;
        }

        /// <summary>
        /// Вызывается при изменении выбраной записи таблицы "Хоз.расходы"
        /// </summary>
        private void DataGridViewHouse_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHouse.SelectedCells.Count <= 0) return;
            var index = dataGridViewHouse.SelectedCells[0].RowIndex;
            _selectedHousehold = (Household) _householdSource[index];
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Фильтры" таблицы "Хоз.расходы"
        /// </summary>
        private void BtnHouseFilter_Click(object sender, EventArgs e)
        {
            if (_isHouseholdFilterActive) return;
            _isHouseholdFilterActive = true;
            var filterForm = new HouseholdFilters();
            filterForm.ButtonSortEvent += HouseholdFilterForm_ButtonSortEvent;
            filterForm.ButtonSearchEvent += HouseholdFilterForm_ButtonSearchEvent;
            filterForm.ButtonGroupEvent += HouseholdFilterForm_ButtonGroupEvent;
            filterForm.FormClosed += HouseholdFilterForm_FormClosed;
            filterForm.Show();
            Enabled = false;
        }

        /// <summary>
        /// Вызывается при закрытии фильтров таблицы "Хоз.расходы"
        /// </summary>
        private void HouseholdFilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isHouseholdFilterActive = false;
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при группировки таблицы "Хоз.расходы"
        /// </summary>
        private void HouseholdFilterForm_ButtonGroupEvent(FilterInfo.GroupType groupType, int min, int max,
            string dateLow, string dateHigh)
        {
            IEnumerable<Household> res = null;
            switch (groupType)
            {
                case FilterInfo.GroupType.DATE:
                    res = _householdsCollection.Where(p =>
                        p.Date.CompareTo(dateLow) >= 0 & p.Date.CompareTo(dateHigh) <= 0);
                    break;
                case FilterInfo.GroupType.COUNT:
                    res = _householdsCollection.Where(p => p.Count >= min & p.Count <= max);
                    break;
                case FilterInfo.GroupType.COST:
                    res = _householdsCollection.Where(p => p.Cost >= min & p.Cost <= max);
                    break;
                case FilterInfo.GroupType.FINAL_COST:
                    res = _householdsCollection.Where(p => p.FinalCost >= min & p.FinalCost <= max);
                    break;
            }

            if (res.Count() != 0)
            {
                _householdSource.DataSource = res;
                ChangeFilterButtonState(btnHouseFilter, true);
            }
            else
            {
                MessageBox.Show(Resources.GroupFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при поиске записи в таблице "Хоз.расходы"
        /// </summary>
        private void HouseholdFilterForm_ButtonSearchEvent(FilterInfo.SearchType searchType, string data)
        {
            if (data == "") return;
            IEnumerable<Household> res = null;
            object x;
            if (searchType != FilterInfo.SearchType.SERVICE_NAME && searchType != FilterInfo.SearchType.DATE)
            {
                if (searchType == FilterInfo.SearchType.COUNT)
                {
                    try
                    {
                        x = Convert.ToInt32(data);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        x = Convert.ToDouble(data);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
                        return;
                    }
                }
            }
            else
            {
                x = data;
            }

            switch (searchType)
            {
                case FilterInfo.SearchType.SERVICE_NAME:
                    res = _householdsCollection.Where(p => p.Title.ToLower().Contains(((string) x).ToLower()));
                    break;
                case FilterInfo.SearchType.DATE:
                    res = _householdsCollection.Where(p => p.Date.Contains((string) x));
                    break;

                case FilterInfo.SearchType.COUNT:
                    res = _householdsCollection.Where(p => p.Count == (int) x);
                    break;

                case FilterInfo.SearchType.COST:
                    res = _householdsCollection.Where(p => p.Cost == (double) x);
                    break;

                case FilterInfo.SearchType.FINAL_COST:
                    res = _householdsCollection.Where(p => p.FinalCost == (double) x);
                    break;
            }

            if (res.Count() != 0)
            {
                _householdSource.DataSource = res;
                ChangeFilterButtonState(btnHouseFilter, true);
            }
            else
            {
                MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
            }
        }

        /// <summary>
        /// Вызывается при сортировки таблицы "Хоз.расходы"
        /// </summary>
        private void HouseholdFilterForm_ButtonSortEvent(IEnumerable<FilterInfo> data, bool isASC)
        {
            var list = data.ToList();
            if (list.Count == 0) return;
            var first = list[0].ST;
            IOrderedEnumerable<Household> result = null;
            if (isASC)
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_SERVICE_NAME:
                        result = _householdsCollection.OrderBy(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _householdsCollection.OrderBy(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_COUNT:
                        result = _householdsCollection.OrderBy(u => u.Count);
                        break;
                    case FilterInfo.SortType.BY_COST:
                        result = _householdsCollection.OrderBy(u => u.Cost);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _householdsCollection.OrderBy(u => u.FinalCost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_SERVICE_NAME:
                            result = result.ThenBy(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.ThenBy(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_COUNT:
                            result = result.ThenBy(u => u.Count);
                            break;
                        case FilterInfo.SortType.BY_COST:
                            result = result.ThenBy(u => u.Cost);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.ThenBy(u => u.FinalCost);
                            break;
                    }
                }
            }
            else
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_SERVICE_NAME:
                        result = _householdsCollection.OrderByDescending(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _householdsCollection.OrderByDescending(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_COUNT:
                        result = _householdsCollection.OrderByDescending(u => u.Count);
                        break;
                    case FilterInfo.SortType.BY_COST:
                        result = _householdsCollection.OrderByDescending(u => u.Cost);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _householdsCollection.OrderByDescending(u => u.FinalCost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_SERVICE_NAME:
                            result = result.ThenByDescending(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.ThenByDescending(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_COUNT:
                            result = result.ThenByDescending(u => u.Count);
                            break;
                        case FilterInfo.SortType.BY_COST:
                            result = result.ThenByDescending(u => u.Cost);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.ThenByDescending(u => u.FinalCost);
                            break;
                    }
                }
            }

            _householdSource.DataSource = result.ToList();
            ChangeFilterButtonState(btnHouseFilter, true);
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Сбросить фильтры" таблицы "Хоз.расходы"
        /// </summary>
        private void BtnHouseClear_Click(object sender, EventArgs e)
        {
            _householdSource.DataSource = _householdsCollection;
            ChangeFilterButtonState(btnHouseFilter, false);
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Вызывается при изменении состояния кнопки "Фильтры"
        /// </summary>
        private void ChangeFilterButtonState(Button button, bool isActive)
        {
            if (isActive)
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Coral;
            }
            else
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.Transparent;
            }
        }

        #endregion

        #region Обработка нажатия клавиш в текстовые поля


        /// <summary>
        /// Только буквенные символы
        /// </summary>
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsLetter(e.KeyChar) || IsWhiteSpace(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }

        /// <summary>
        /// Только цифры
        /// </summary>
        private void OnKeyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }

        /// <summary>
        /// Цифры и ,
        /// </summary>
        private void OnKeyDoublePress(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
            {
                return;
            }

            e.Handled = true;
        }

        #endregion

        #region Логика работы с файлом

        /// <summary>
        /// Вызывается при закрытии формы "Изменить"
        /// </summary>
        private void ChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Refresh();
            dataGridViewService.Refresh();
            dataGridViewHouse.Refresh();
            Enabled = true;
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Сохранить в зашифрованном виде"
        /// </summary>
        private void MenuItemSaveLock_Click(object sender, EventArgs e)
        {
            List<Model.Model> coll = null;
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    saveFileDialog.FileName = "Person";
                    coll = TableConverter.ConvertToModel(_personCollection);
                    break;
                case 1:
                    saveFileDialog.FileName = "Service";
                    coll = TableConverter.ConvertToModel(_serviceCollection);
                    break;
                case 2:
                    saveFileDialog.FileName = "Household";
                    coll = TableConverter.ConvertToModel(_householdsCollection);
                    break;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            var filename = saveFileDialog.FileName;
            DbContext.GetInstance()
                .WriteFile(filename, coll);
            // сохраняем текст в файл
            MessageBox.Show(Resources.FileSaveMessage);
        }

        /// <summary>
        /// Вызывается при закрытии текущей формы
        /// </summary>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var db = DbContext.GetInstance();
            if (!_isExternalFile)
            {
                db.WriteFile(DbContext.FILE_NAME.owners, TableConverter.ConvertToModel(_personCollection));
                db.WriteFile(DbContext.FILE_NAME.service, TableConverter.ConvertToModel(_serviceCollection));
                db.WriteFile(DbContext.FILE_NAME.household, TableConverter.ConvertToModel(_householdsCollection));
            }
            else
            {
                switch (_fileType)
                {
                    case FileType.person:
                        db.WriteFile(_externaalFileName, TableConverter.ConvertToModel(_personCollection));
                        db.WriteFile(DbContext.FILE_NAME.service, TableConverter.ConvertToModel(_serviceCollection));
                        db.WriteFile(DbContext.FILE_NAME.household, TableConverter.ConvertToModel(_householdsCollection));
                        break;
                    case FileType.service:
                        db.WriteFile(_externaalFileName, TableConverter.ConvertToModel(_serviceCollection));
                        db.WriteFile(DbContext.FILE_NAME.owners, TableConverter.ConvertToModel(_personCollection));
                        db.WriteFile(DbContext.FILE_NAME.household, TableConverter.ConvertToModel(_householdsCollection));
                        break;
                    case FileType.household:
                        db.WriteFile(_externaalFileName, TableConverter.ConvertToModel(_householdsCollection));
                        db.WriteFile(DbContext.FILE_NAME.service, TableConverter.ConvertToModel(_serviceCollection));
                        db.WriteFile(DbContext.FILE_NAME.household, TableConverter.ConvertToModel(_householdsCollection));
                        break;
                }
            }
            db.WriteMetaInfo(_metaInfo);
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Сохранить в JSON"
        /// </summary>
        private void MenuItemSaveJson_Click(object sender, EventArgs e)
        {
            List<Model.Model> coll = null;
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    saveJsonFileDialog.FileName = "Person";
                    coll = TableConverter.ConvertToModel(_personCollection);
                    break;
                case 1:
                    saveJsonFileDialog.FileName = "Service";
                    coll = TableConverter.ConvertToModel(_serviceCollection);
                    break;
                case 2:
                    saveJsonFileDialog.FileName = "Household";
                    coll = TableConverter.ConvertToModel(_householdsCollection);
                    break;
            }

            if (saveJsonFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveJsonFileDialog.FileName;
            DbContext.GetInstance()
                .WriteJsonFile(filename, coll);
            // сохраняем текст в файл
            MessageBox.Show(Resources.FileSaveMessage);
        }

        /// <summary>
        /// Вызывается при нажатии на пункт меню "Открыть файл"
        /// </summary>
        private void MenuItemOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = openFileDialog.FileName;
            var db = DbContext.GetInstance();
            List<Model.Model> file = null;
            try
            {
                file = db.ReadFile(filename);
            }
            catch(Exception)
            {
                MessageBox.Show(Resources.FileOpenFailMessage, Resources.CaptionMessageBox);
            }

            if (file == null) return;
            _isExternalFile = true;
            _externaalFileName = filename;
            var failCount = 0;
            try
            {
                _personCollection = TableConverter.ConvertToPerson(file);
                _personSource.DataSource = _personCollection;
                _fileType = FileType.person;
                tabControl.SelectedIndex = 0;
                ChangeFilterButtonState(btnPersonFilter, false);
                return;
            }
            catch
            {
                failCount++;
            }

            try
            {
                _serviceCollection = TableConverter.ConvertToService(file);
                _serviceSource.DataSource = _serviceCollection;
                _fileType = FileType.service;
                tabControl.SelectedIndex = 1;
                ChangeFilterButtonState(btnFilters, false);
                return;
            }
            catch
            {
                failCount++;
            }

            try
            {
                _householdsCollection = TableConverter.ConvertToHousehold(file);
                _householdSource.DataSource = _householdsCollection;
                _fileType = FileType.household;
                tabControl.SelectedIndex = 2;
                ChangeFilterButtonState(btnHouseFilter, false);
                return;
            }
            catch
            {
                failCount++;
            }

            if (failCount < 3)
            {
                MessageBox.Show(Resources.FileOpenMessage, Resources.CaptionMessageBox);

            }
            else
            {
                MessageBox.Show(Resources.FileOpenFailMessage, Resources.CaptionMessageBox);
            }

        }

        #endregion

        /// <summary>
        /// Тип файла
        /// </summary>
        private enum FileType
        {
            person,
            service,
            household
        }
    }
}