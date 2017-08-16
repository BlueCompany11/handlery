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
            ValueChanged.BeginInvoke(null, null, null, null);
        }
        public static void FunStat()
        {
            ValueChangedStatic.BeginInvoke(null, null, null, null);
        }
        public static string SomeText;
        public static string someText
        {
            get
            {
                return SomeText;
            }
            set
            {

                SomeText = value;
                OnValueChangedStatic(null);
            }
        }
        public static event EventHandler ValueChangedStatic;
        public static void OnValueChangedStatic(EventArgs e)
        {
            if (ValueChangedStatic != null)
                ValueChangedStatic(null, e);
        }
    }
}
