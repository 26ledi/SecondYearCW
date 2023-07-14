using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Entities;
using System.Xml;

namespace CinemaApp.Presentation
{

    public partial class FormAdmiBalance : Form
    {
        private readonly OrderService _orderservice;
        private List<Order> ordersDto;
        private DateTime _startDate;
        private DateTime _endDate;
        private XmlDocument xmlDoc;
        private XmlElement balanceDataElement;

        public FormAdmiBalance(OrderService orderService)
        {
            _orderservice = orderService;
            // Initialiser le document XML
            xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement rootElement = xmlDoc.DocumentElement;
            xmlDoc.InsertBefore(xmlDeclaration, rootElement);

            if (xmlDoc.DocumentElement == null)
            {
                balanceDataElement = xmlDoc.CreateElement("BalanceData");
                xmlDoc.AppendChild(balanceDataElement);
            }
            InitializeComponent();
        }

        private void FormAdmiBalance_Load(object sender, EventArgs e)
        {
            InitializeDates();
        }

        private void InitializeDates()
        {
            _startDate = dateTimePickerStart.Value;
            _endDate = dateTimePicker1.Value;

        }

        private void btnShowAverage_Click(object sender, EventArgs e)
        {
            InitializeDates(); // Met à jour les dates avant d'afficher les résultats
            ordersDto = _orderservice.GetAverage(_startDate, _endDate);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn cinemaColumn = new DataGridViewTextBoxColumn();
            cinemaColumn.DataPropertyName = "CinemaName";
            cinemaColumn.HeaderText = "Cinema";
            dataGridView1.Columns.Add(cinemaColumn);
            DataGridViewTextBoxColumn averageColumn = new DataGridViewTextBoxColumn();
            averageColumn.DataPropertyName = "Average";
            averageColumn.HeaderText = "Average of viewers";
            dataGridView1.Columns.Add(averageColumn);
            dataGridView1.DataSource = ordersDto;
            //--------------------------------------------------------------------
            if (balanceDataElement == null)
            {
                balanceDataElement = xmlDoc.CreateElement("BalanceData");
                xmlDoc.AppendChild(balanceDataElement);
            }
            XmlElement averageViewersElement = xmlDoc.CreateElement("AverageViewers");
            balanceDataElement.AppendChild(averageViewersElement);

            
            foreach (var orderDto in ordersDto)
            {
                // Créer l'élément <CinemaName> avec la valeur du nom du cinéma
                XmlElement cinemaNameElement = xmlDoc.CreateElement("CinemaName");
                cinemaNameElement.InnerText = orderDto.CinemaName;
                averageViewersElement.AppendChild(cinemaNameElement);

                // Créer l'élément <Average> avec la valeur de la moyenne des spectateurs
                XmlElement averageElement = xmlDoc.CreateElement("Average");
                averageElement.InnerText = orderDto.Average.ToString();
                averageViewersElement.AppendChild(averageElement);
            }

            // Enregistrer le document XML dans un fichier
            string fileName = "XMLReport.xml";
            xmlDoc.Save(fileName);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void btnShowPopularFilm_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn FilmColumn = new DataGridViewTextBoxColumn();
            FilmColumn.DataPropertyName = "FilmName";
            FilmColumn.HeaderText = "Films";
            dataGridView1.Columns.Add(FilmColumn);
            DataGridViewTextBoxColumn RatingColumn = new DataGridViewTextBoxColumn();
            RatingColumn.DataPropertyName = "Rating";
            RatingColumn.HeaderText = "Rating of Box Office";
            dataGridView1.Columns.Add(RatingColumn);
            dataGridView1.DataSource = _orderservice.GetPopularFilms();
            //--------------------------------------------------------------------
            if (balanceDataElement == null)
            {
                balanceDataElement = xmlDoc.CreateElement("BalanceData");
                xmlDoc.AppendChild(balanceDataElement);
            }
            var popularFilms = _orderservice.GetPopularFilms();
            // Créer l'élément <PopularFilms>
            XmlElement popularFilmsElement = xmlDoc.CreateElement("PopularFilms");
            balanceDataElement.AppendChild(popularFilmsElement);

            // Parcourir les films populaires et les ajouter à l'élément <PopularFilms>
            foreach (var film in popularFilms)
            {
             
                XmlElement filmElement = xmlDoc.CreateElement("Film");
                popularFilmsElement.AppendChild(filmElement);

              
                XmlElement nameElement = xmlDoc.CreateElement("Name");
                nameElement.InnerText = film.FilmName;
                filmElement.AppendChild(nameElement);

                
                XmlElement ratingElement = xmlDoc.CreateElement("Rating");
                ratingElement.InnerText = film.Rating.ToString();
                filmElement.AppendChild(ratingElement);
            }

            // Enregistrer le document XML dans un fichier
            string fileName = "XMLReport.xml";
            xmlDoc.Save(fileName);

        }

        private void btnShowCashier_Click(object sender, EventArgs e)
        {

            InitializeDates(); // Met à jour les dates avant d'afficher les résultats
            ordersDto = _orderservice.GetCashier(_startDate, _endDate);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn CashierColumn = new DataGridViewTextBoxColumn();
            CashierColumn.DataPropertyName = "Cashier";
            CashierColumn.HeaderText = "Cashier";
            dataGridView1.Columns.Add(CashierColumn);
            DataGridViewTextBoxColumn CinemaColumn = new DataGridViewTextBoxColumn();
            CinemaColumn.DataPropertyName = "CinemaName";
            CinemaColumn.HeaderText = "Cinema";
            dataGridView1.Columns.Add(CinemaColumn);
            DataGridViewTextBoxColumn TotalAmountColumn = new DataGridViewTextBoxColumn();
            TotalAmountColumn.DataPropertyName = "Amount";
            TotalAmountColumn.HeaderText = "Amount";
            dataGridView1.Columns.Add(TotalAmountColumn);
            dataGridView1.DataSource = ordersDto;

            // Parcourir les données des caissiers et les ajouter à l'élément racine <BalanceData>
            if (balanceDataElement == null)
            {
                balanceDataElement = xmlDoc.CreateElement("BalanceData");
                xmlDoc.AppendChild(balanceDataElement);
            }
            foreach (var orderDto in ordersDto)
            {
                // Créer l'élément <Cashier>
                XmlElement cashierElement = xmlDoc.CreateElement("Cashier");
                balanceDataElement.AppendChild(cashierElement);

                
                XmlElement cashierNameElement = xmlDoc.CreateElement("CashierName");
                cashierNameElement.InnerText = orderDto.Cashier;
                cashierElement.AppendChild(cashierNameElement);

                
                XmlElement cinemaNameElement = xmlDoc.CreateElement("CinemaName");
                cinemaNameElement.InnerText = orderDto.CinemaName;
                cashierElement.AppendChild(cinemaNameElement);

                
                XmlElement amountElement = xmlDoc.CreateElement("Amount");
                amountElement.InnerText = orderDto.Amount.ToString();
                cashierElement.AppendChild(amountElement);
            }

            // Enregistrer le document XML dans un fichier
            string fileName = "XMLReport.xml";
            xmlDoc.Save(fileName);
        }
        

    }

}

