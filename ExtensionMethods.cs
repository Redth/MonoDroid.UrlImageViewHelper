
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
	public static class ExtensionMethods
	{
		public static void SetUrlDrawable(this ImageView imageView, string url, int defaultResource)
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultResource);
		}

		public static void SetUrlDrawable(this ImageView imageView, string url)
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url);
		}

		public static void SetUrlDrawable(this ImageView imageView, string url, Drawable defaultDrawable)
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultDrawable);
		}

		public static void SetUrlDrawable(this ImageView imageView, string url, int defaultResource, long cacheDurationMs)
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultResource, cacheDurationMs);
		}

		public static void SetUrlDrawable(this ImageView imageView, string url, Drawable defaultDrawable, long cacheDurationMs)
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultDrawable, cacheDurationMs);
		}

		public static void SetUrlDrawable(this ImageView imageView, string url, IUrlImageViewCallback callback) 
		{
        	UrlImageViewHelper.SetUrlDrawable(imageView, url, callback);
	    }

	    public static void SetUrlDrawable(this ImageView imageView, string url, Drawable defaultDrawable, IUrlImageViewCallback callback) 
		{
	        UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultDrawable, callback);
	    }

	    public static void SetUrlDrawable(this ImageView imageView, string url, int defaultResource, long cacheDurationMs, IUrlImageViewCallback callback) 
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultResource, cacheDurationMs, callback);
	    }

	    public static void SetUrlDrawable(this ImageView imageView, string url, Drawable defaultDrawable, long cacheDurationMs, IUrlImageViewCallback callback) 
		{
			UrlImageViewHelper.SetUrlDrawable(imageView, url, defaultDrawable, cacheDurationMs, callback);
	    }
	}
}

