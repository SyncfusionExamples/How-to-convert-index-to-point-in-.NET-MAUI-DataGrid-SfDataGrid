using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Diagnostics;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Datagrid_CellTapped(object? sender, DataGridCellTappedEventArgs e)
        {
            Point point = datagrid.RowColumnIndexToPoint(e.RowColumnIndex);
            Debug.WriteLine(point.X + " " + point.Y);
        }       
    }
}
