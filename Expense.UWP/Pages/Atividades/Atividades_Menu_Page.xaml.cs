using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Expense.UWP.Pages.Atividades
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Atividades_Menu_Page : Page
    {
        public Atividades_Menu_Page()
        {
            this.InitializeComponent();

            
            pivot_principal.SelectionChanged += Pivot_principal_SelectionChanged;

        }

        private void Pivot_principal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pivot = sender as Pivot;
            var pivotItemSelected = pivot.SelectedItem as PivotItem;

            if (pivotItemSelected.Header.ToString() == "Atividades Real.")
            {
                abb_addAtividade.Flyout = (Flyout)Resources["flyout_novaAtividadeReal"];
            }
            else
            {
                abb_addAtividade.Flyout = null;
            }

        }
    }
}
