using System;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager.FileSaving
{
    abstract class CreateSaver
    {
        string file;

        public abstract FileSaver Create(string extension);
    }
}
