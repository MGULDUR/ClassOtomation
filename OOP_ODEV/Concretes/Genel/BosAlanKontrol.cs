using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.Genel
{
    public static class BosAlanKontrol
    {
        public static bool EmptyAreaControl(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == string.Empty) return true;
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1 && ((ComboBox)item).Enabled == true) return true;
                }
            }
            return false;
        }
    }
}
