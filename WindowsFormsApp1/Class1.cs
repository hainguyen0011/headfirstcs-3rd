using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class1
    {
        
        public int MyProperty { get; set; }
        public int MyProperty1 { get { return 0; } }
        public Class1()
        {
            try
            {
                MyProperty = 6 / MyProperty1;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Message");
                MessageBox.Show(ex.StackTrace, "StackTrace");
            }
        }

    }
}
