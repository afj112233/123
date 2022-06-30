using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using GalaSoft;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using SampleTest.Model;
using System.Windows.Shapes;
using MenuItem = System.Windows.Controls.MenuItem;

namespace SampleTest.ViewModel
{
    class ViewModel:ViewModelBase
    {
        public List<Person> GetPersons
        {
            get
            {
                return Model.Person.Persons;
            }
        }
        public List<TreeViewItem> GetNames
        {
            get
            {
                return Model.Name.Tree;
            }
        }

        public List<string> GetPersonsName
        {
            get
            {
                List<string> Name = new List<string>();
                foreach (var i in Model.Person.Persons)
                {
                    Name.Add(i.Name);
                }
                return Name;
            }
        }

        public string Name
        {
            get
            {
                return "a";
            }
        }
        public List<string> GetComEng
        {
            get
            {
                return Model.Combobox.ComEng;
            }
        }

        public List<string> GetComCh
        {
            get
            {
                return Model.Combobox.ComCh;
            }
        }
        public ViewModel()
        {
            MousePosition = new RelayCommand(FindMouse);
            Sync = new RelayCommand(SyncOptions);
            Tip1 = new RelayCommand(SelectTip1);
            Tip2 = new RelayCommand(SelectTip2);
            Choose1 = new RelayCommand(ExeChoose1);
            Choose2 = new RelayCommand(ExeChoose2);
        }

        public RelayCommand MousePosition { get; set; }
        public RelayCommand Sync { get; set; }
        public RelayCommand Tip1 { get; set; }
        public RelayCommand Tip2 { get; set; }
        public RelayCommand Choose1 { get; set; }
        public RelayCommand Choose2 { get; set; }

        public void FindMouse()
        {
            var mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            Point p = Mouse.GetPosition(relativeTo: mainWindow);
            mainWindow.MousePosition.Text = $"{p.X},{p.Y}";
        }
        public void SyncOptions()
        {
            var mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWindow.Data1.SelectedIndex = mainWindow.Data2.SelectedIndex;
        }

        public void SelectTip1()
        {
            MessageBox.Show("Command Binding without parameter");
        }
        public void SelectTip2()
        {
            MessageBox.Show("Command Binding without parameter:CommandParameter");
        }
        public void ExeChoose1()
        {
            var mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWindow.IsV.Visibility = Visibility.Hidden;
            mainWindow.Control.Visibility = Visibility.Visible;
            mainWindow.Control.IsChecked = false;
        }
        public void ExeChoose2()
        {
            var mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWindow.Control.Visibility = Visibility.Hidden;
            mainWindow.IsV.Visibility = Visibility.Visible;
            mainWindow.IsV.IsChecked = true;
        }
    }
}
