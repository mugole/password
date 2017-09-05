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

namespace PeopleHealthPharmacy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            create_Grid();
        }

        public void create_Grid()
        {
            // Create the Grid
            Grid myGrid = new Grid();
            //myGrid.Width = RootWindow.Width; don't think I need this anymore
            //myGrid.Height = RootWindow.Height; don't think I need this anymore
            myGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            myGrid.VerticalAlignment = VerticalAlignment.Stretch;
            myGrid.ShowGridLines = true;
            myGrid.Background = new SolidColorBrush(Colors.LightBlue);

            // Create Columns
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();
            myGrid.ColumnDefinitions.Add(gridCol1);
            myGrid.ColumnDefinitions.Add(gridCol2);
            myGrid.ColumnDefinitions.Add(gridCol3);

            // Create Rows
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(60);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(60);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(60);
            myGrid.RowDefinitions.Add(gridRow1);
            myGrid.RowDefinitions.Add(gridRow2);
            myGrid.RowDefinitions.Add(gridRow3);

            // Add first column header
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Heading 1";
            txtBlock1.FontSize = 20;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.Black);
            txtBlock1.VerticalAlignment = VerticalAlignment.Center;
            txtBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 0);

            // Add second column header
            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Heading 2";
            txtBlock2.FontSize = 20;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.Foreground = new SolidColorBrush(Colors.Black);
            txtBlock2.VerticalAlignment = VerticalAlignment.Center;
            txtBlock2.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock2, 0);
            Grid.SetColumn(txtBlock2, 1);

            // Add third column header
            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Heading 3";
            txtBlock3.FontSize = 20;
            txtBlock3.FontWeight = FontWeights.Bold;
            txtBlock3.Foreground = new SolidColorBrush(Colors.Black);
            txtBlock3.VerticalAlignment = VerticalAlignment.Center;
            txtBlock3.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock3, 0);
            Grid.SetColumn(txtBlock3, 2);

            //// Add column headers to the Grid
            myGrid.Children.Add(txtBlock1);
            myGrid.Children.Add(txtBlock2);
            myGrid.Children.Add(txtBlock3);

            // Create first Row
            TextBlock heading1Text = new TextBlock();
            heading1Text.Text = "Row 1 Colum 1";
            heading1Text.FontSize = 14;
            Grid.SetRow(heading1Text, 1);
            Grid.SetColumn(heading1Text, 0);

            TextBlock heading2Text = new TextBlock();
            heading2Text.Text = "Row 1 Colum 2";
            heading2Text.FontSize = 14;
            Grid.SetRow(heading2Text, 1);
            Grid.SetColumn(heading2Text, 1);

            TextBlock heading3Text = new TextBlock();
            heading3Text.Text = "Row 1 Colum 3";
            heading3Text.FontSize = 14;
            Grid.SetRow(heading3Text, 1);
            Grid.SetColumn(heading3Text, 2);
            // Add first row to Grid
            myGrid.Children.Add(heading1Text);
            myGrid.Children.Add(heading2Text);
            myGrid.Children.Add(heading3Text);

            // Create second row
            heading1Text = new TextBlock();
            heading1Text.Text = "Row 2 Colum 1";
            heading1Text.FontSize = 14;
            Grid.SetRow(heading1Text, 2);
            Grid.SetColumn(heading1Text, 0);

            heading2Text = new TextBlock();
            heading2Text.Text = "Row 2 Colum 2";
            heading2Text.FontSize = 14;
            Grid.SetRow(heading2Text, 2);
            Grid.SetColumn(heading2Text, 1);

            heading3Text = new TextBlock();
            heading3Text.Text = "Row 2 Colum 3";
            heading3Text.FontSize = 14;
            Grid.SetRow(heading3Text, 2);
            Grid.SetColumn(heading3Text, 2);

            // Add second row to Grid
            myGrid.Children.Add(heading1Text);
            myGrid.Children.Add(heading2Text);
            myGrid.Children.Add(heading3Text);

            // Display grid into a Window
            
            RootWindow.Content = myGrid;
        }
    }
}
