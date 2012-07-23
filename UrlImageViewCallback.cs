
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace UrlImageViewHelper
{
	public interface IUrlImageViewCallback
	{
		void OnLoaded(ImageView imageView, Drawable loadedDrawable, string url, bool loadedFromCache);
	}
}

