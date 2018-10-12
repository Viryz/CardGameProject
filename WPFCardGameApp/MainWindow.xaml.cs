using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCardGameApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Panel parent;
        Panel way;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataObject data = new DataObject();
            Image img = sender as Image;
            parent = img.Parent as Panel;
            data.SetData("Object", img);
            DragDrop.DoDragDrop(sender as Image, data, DragDropEffects.Move);
        }

        private void stackPanelDeck1_Drop(object sender, DragEventArgs e)
        {
            button.Content = "stackPanelDeck1_Drop";
            UIElement img = (UIElement)e.Data.GetData("Object");

            parent.Children.Remove(img);
            way.Children.Add(img);
        }

        private void stackPanelDeck1_DragEnter(object sender, DragEventArgs e)
        {
            way = sender as Panel;
            button.Content = way.ToString();
        }
    }
}
