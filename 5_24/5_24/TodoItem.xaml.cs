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
    /// TodoItem.xaml 的互動邏輯
    /// </summary>
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
        }
        public bool IsChecked
        {
            set
            {
                if (value == true)
                {
                    CheckMark.Visibility = Visibility.Visible;
                }
                else
                {
                    CheckMark.Visibility = Visibility.Collapsed;
                }
            }
        }
        public string ItemName

        {
            get
            {
                return ItemNameTb.Text;
            }
        }
        private void CheckBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckMark.Visibility == Visibility)
            {
                CheckMark.Visibility = Visibility.Collapsed;
            }
            else
            {
                CheckMark.Visibility = Visibility.Visible;
            }
        }
    }
}
