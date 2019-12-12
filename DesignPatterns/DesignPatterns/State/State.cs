using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public abstract class State
    {

        protected Context context;

        public void SetContext(Context context)
        {
            this.context = context;
        }

        public abstract void Available();

        public abstract void Sold();

    }
}
