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

namespace _5_24
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TodoItem_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            TodoItem item = new TodoItem();
            TodoItemList.Children.Add(item);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string data = "";

            foreach (TodoItem item in TodoItemList.Children)
            {
                data += "|"+item.ItemName + "\r\n";
            }

            // 存檔
            System.IO.File.WriteAllText(@"C:\temp\data.txt", data);
        }
    }
}
