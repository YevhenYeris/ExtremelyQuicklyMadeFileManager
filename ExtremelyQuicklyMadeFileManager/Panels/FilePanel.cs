using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager.Panels
{
    class FilePanel : SemiPanel
    {
        public FilePanel(ListView view, ComboBox box)
        {
            _view = view;
            _comboBox = box;
        }

        public override void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
