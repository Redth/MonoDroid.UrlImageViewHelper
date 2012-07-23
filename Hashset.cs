
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
	public class HashTable<TKey, TValue>
	{
		object lockObj = new object();
		Dictionary<TKey, TValue> hashset = new Dictionary<TKey, TValue>();

		public void Put(TKey key, TValue value)
		{
			lock(lockObj)
			{
				if (hashset.ContainsKey(key))
					hashset[key] = value;
				else
					hashset.Add(key, value);
			}
		}

		public TValue Get(TKey key)
		{
			TValue result = default(TValue);

			lock (lockObj)
			{
				if (hashset.ContainsKey(key))
					result = hashset[key];
			}

			return result;
		}

		public void Remove(TKey key)
		{
			lock(lockObj)
			{
				hashset.Remove(key);
			}
		}

	}
}

