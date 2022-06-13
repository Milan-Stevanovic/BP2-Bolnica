using BP2Bolnica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BP2Bolnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BP2BolnicaContext context = new BP2BolnicaContext();
        private CollectionViewSource bolnicaViewSource;
        private CollectionViewSource zaposleniViewSource;
        private CollectionViewSource zdravstveniRadnikViewSource;
        private CollectionViewSource obezbedjenjeViewSource;
        private CollectionViewSource spremacicaViewSource;
        private CollectionViewSource doktorViewSource;
        private CollectionViewSource medicinskiTehnicarViewSource;
        private CollectionViewSource pacijentViewSource;
        private CollectionViewSource pregledViewSource;
        private CollectionViewSource obavljaPregledViewSource;
        private CollectionViewSource intervencijaViewSource;
        private CollectionViewSource opercionaSalaViewSource;
        private CollectionViewSource odeljenjeViewSource;

        public MainWindow()
        {
            InitializeComponent();

            bolnicaViewSource = (CollectionViewSource)FindResource(nameof(bolnicaViewSource));
            zaposleniViewSource = (CollectionViewSource)FindResource(nameof(zaposleniViewSource));
            zdravstveniRadnikViewSource = (CollectionViewSource)FindResource(nameof(zdravstveniRadnikViewSource));
            obezbedjenjeViewSource = (CollectionViewSource)FindResource(nameof(obezbedjenjeViewSource));
            spremacicaViewSource = (CollectionViewSource)FindResource(nameof(spremacicaViewSource));
            doktorViewSource = (CollectionViewSource)FindResource(nameof(doktorViewSource));
            medicinskiTehnicarViewSource = (CollectionViewSource)FindResource(nameof(medicinskiTehnicarViewSource));
            pacijentViewSource = (CollectionViewSource)FindResource(nameof(pacijentViewSource));
            pregledViewSource = (CollectionViewSource)FindResource(nameof(pregledViewSource));
            obavljaPregledViewSource = (CollectionViewSource)FindResource(nameof(obavljaPregledViewSource));
            intervencijaViewSource = (CollectionViewSource)FindResource(nameof(intervencijaViewSource));
            opercionaSalaViewSource = (CollectionViewSource)FindResource(nameof(opercionaSalaViewSource));
            odeljenjeViewSource = (CollectionViewSource)FindResource(nameof(odeljenjeViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Bolnicas.Load();
            context.Zaposlenis.Load();
            context.ZdravstveniRadniks.Load();
            context.Obezbedjenjes.Load();
            context.Spremacicas.Load();
            context.Doktors.Load();
            context.MedicinskiTehnicars.Load();
            context.Pacijents.Load();
            context.Pregleds.Load();
            context.ObavljaPregleds.Load();
            context.Intervencijas.Load();
            context.OperacionaSalas.Load();
            context.Odeljenjes.Load();

            bolnicaViewSource.Source = context.Bolnicas.Local.ToObservableCollection();
            zaposleniViewSource.Source = context.Zaposlenis.Local.ToObservableCollection();
            zdravstveniRadnikViewSource.Source = context.ZdravstveniRadniks.Local.ToObservableCollection();
            obezbedjenjeViewSource.Source = context.Obezbedjenjes.Local.ToObservableCollection();
            spremacicaViewSource.Source = context.Spremacicas.Local.ToObservableCollection();
            doktorViewSource.Source = context.Doktors.Local.ToObservableCollection();
            medicinskiTehnicarViewSource.Source = context.MedicinskiTehnicars.Local.ToObservableCollection();
            pacijentViewSource.Source = context.Pacijents.Local.ToObservableCollection();
            pregledViewSource.Source = context.Pregleds.Local.ToObservableCollection();
            obavljaPregledViewSource.Source = context.ObavljaPregleds.Local.ToObservableCollection();
            intervencijaViewSource.Source = context.Intervencijas.Local.ToObservableCollection();
            opercionaSalaViewSource.Source = context.OperacionaSalas.Local.ToObservableCollection();
            odeljenjeViewSource.Source = context.Odeljenjes.Local.ToObservableCollection();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int n = context.SaveChanges();

            BolnicaDataGrid.Items.Refresh();
            ZaposleniDataGrid.Items.Refresh();
            ZdravstveniRadnikDataGrid.Items.Refresh();
            ObezbedjenjeDataGrid.Items.Refresh();
            SpremacicaDataGrid.Items.Refresh();
            DoktorDataGrid.Items.Refresh();
            MedicinskiTehnicarDataGrid.Items.Refresh();
            PacijentDataGrid.Items.Refresh();
            PregledDataGrid.Items.Refresh();
            ObavljaPregledDataGrid.Items.Refresh();
            IntervencijaDataGrid.Items.Refresh();
            OperacionaSalaDataGrid.Items.Refresh();
            OdeljenjeDataGrid.Items.Refresh();

            MessageBox.Show("Number of affected rows: " + n, "Saving");
        }
    }
}
