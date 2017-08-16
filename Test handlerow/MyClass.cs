using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_handlerow
{
    public class MyClass
    {
        public int SomeInt;
        public int someInt
        {
            get
            {
                return SomeInt;
            }
            set
            {
                if (SomeInt != value)
                {
                    SomeInt = value;
                    this.Fun();
                }
                else
                {
                    someInt = value;
                }

            }
        }
        public event EventHandler ValueChanged;
        public virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        public void Fun()
        {
            ValueChanged.BeginInvoke(null,null,null,null);
        }
    }
}
