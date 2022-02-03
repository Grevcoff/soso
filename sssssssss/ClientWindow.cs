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
using System.Windows.Shapes;

namespace sssssssss
{
    internal class ClientWindow : Window
    {
        doka2Entities context;
        public ClientWindow()
        {
            context = new doka2Entities();
            ShowTable();
        }

        private void ShowTable()
        {
            
        }
    }
}
   