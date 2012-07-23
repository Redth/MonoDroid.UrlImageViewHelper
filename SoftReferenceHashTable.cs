
using System;
using System.Collections;
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
	public class SoftReferenceHashTable<TKey, TValue>
	{

		Dictionary<TKey, SoftReference<TValue>> table = new Dictionary<TKey, SoftReference<TValue>>();

		public TValue Put(TKey key, TValue value)
		{
			var newVal = new SoftReference<TValue>(value);

			if (table.ContainsKey(key))
				table[key] = newVal;
			else
				table.Add(key, newVal);

			return newVal.Get();
		}

		public TValue Get(TKey key)
		{
			if (!table.ContainsKey(key))
				return default(TValue);

			var val = table[key];

			if (val == null || val.Get() == null)
			{
				table.Remove(key);
				return default(TValue);
			}

			return val.Get();
		}
//		
//		 Hashtable<K, SoftReference<V>> mTable = new Hashtable<K, SoftReference<V>>();
//    
//    public V put(K key, V value) {
//        SoftReference<V> old = mTable.put(key, new SoftReference<V>(value));
//        if (old == null)
//            return null;
//        return old.get();
//    }
//    
//    public V get(K key) {
//        SoftReference<V> val = mTable.get(key);
//        if (val == null)
//            return null;
//        V ret = val.get();
//        if (ret == null)
//            mTable.remove(key);
//        return ret;
//    }
	}
}

