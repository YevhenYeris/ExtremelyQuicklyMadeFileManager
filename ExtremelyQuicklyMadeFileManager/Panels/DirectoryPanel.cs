using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ExtremelyQuicklyMadeFileManager
{
    class DirectoryPanel : SemiPanel
    {
        public DirectoryPanel(TreeView view, ComboBox box)
        {
            _view = view;
            _comboBox = box;
        }

        public override void UpdateView()
        {
            var view = (TreeView)_view;   
            throw new NotImplementedException();
        }
    }
}
