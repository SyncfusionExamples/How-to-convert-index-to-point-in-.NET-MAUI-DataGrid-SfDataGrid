using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttachedTo(SfDataGrid dataGrid)
        {
            dataGrid.CellTapped += SfDataGrid_CellTapped;
            base.OnAttachedTo(dataGrid);
        }

        protected override void OnDetachingFrom(SfDataGrid dataGrid)
        {
            dataGrid.CellTapped -= SfDataGrid_CellTapped;
            base.OnDetachingFrom(dataGrid);
        }

        private void SfDataGrid_CellTapped(object? sender, DataGridCellTappedEventArgs e)
        {
            SfDataGrid grid = (SfDataGrid)sender;
            Point point = grid.RowColumnIndexToPoint(e.RowColumnIndex);
            Debug.WriteLine(point.X + " " + point.Y);
        }
    }
}
