using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    abstract class SemiPanel
    {
        protected Control _view;
        protected ComboBox _comboBox;

        public abstract void UpdateView();
    }
}
