using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace UrlImageViewHelper
{
    //class SoftReference : WeakReference { public SoftReference(object target) : base(target) { NonWebCache[Guid.NewGuid().ToString()] = target; } }

    // Switched to trusting the GC for mono, so using WeakReference instead
    public class SoftReference<T> : WeakReference /* where T : Object */ { 
        public SoftReference(T target) : base(target)
        {
        }

        public T Get()
        {
            if (!base.IsAlive)
            {
				return default(T);
                //throw new Exception("Lost SoftReference");
            }
            return (T)base.Target;
        }
    }
}