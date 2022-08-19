using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.Genel
{
    public static class Temizle
    {
        public static void Clean(Control.ControlCollection coll)
        {
            foreach (Control item in coll)
            {
                if (item is TextBox) item.Text = string.Empty;
                else if (item is MaskedTextBox) item.Text = string.Empty;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is ComboBox && item.Enabled != false) ((ComboBox)item).SelectedIndex = -1;
                else if (item is PictureBox) ((PictureBox)item).Image = null;
                else if (item is CheckBox) ((CheckBox)item).Checked = false;
                else if (item is GroupBox) Clean(((GroupBox)item).Controls);
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
            }
        }
    }
}

