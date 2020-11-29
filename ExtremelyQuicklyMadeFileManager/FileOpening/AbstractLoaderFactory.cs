using System;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    public abstract class AbstractLoaderFactory
    {
        public abstract Loader CreateLoader();
    }
}