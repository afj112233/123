using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using MenuItem = System.Web.UI.WebControls.MenuItem;
using TreeView = System.Web.UI.WebControls.TreeView;

namespace SampleTest.Model
{
    class Person
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool isChecked { get; set; }

        public static List<Person> Persons = new List<Person>()
        {
            new Person() { Number = 1, Name = "AAA", Gender = "Male", isChecked = true },
            new Person() { Number = 2, Name = "BBB", Gender = "Female", isChecked = false },
            new Person() { Number = 3, Name = "CCC", Gender = "Female", isChecked = false },
            new Person() { Number = 4, Name = "DDD", Gender = "Female", isChecked = true },
            new Person() { Number = 5, Name = "EEE", Gender = "Male", isChecked = true },
            new Person() { Number = 6, Name = "FFF", Gender = "Male", isChecked = false },
        };
    }

    class Name
    {
        public static List<TreeViewItem> Tree = new List<TreeViewItem>()
        {
            new TreeViewItem()
            {
                Header = "AAA",
                Items = { "AAA1","AAA2" }
            },
            new TreeViewItem()
            {
                Header = "BBB",
            },
            new TreeViewItem()
            {
                Header = "CCC",
                Items = { "CCC1" }
            },
            new TreeViewItem()
            {
                Header = "DDD"
            },
            new TreeViewItem()
            {
                Header = "EEE",
            },
            new TreeViewItem()
            {
                Header = "FFF",
            },
        };
    }
}
