MonoDroid.UrlImageViewHelper
============================

C# / Mono for Android Port of koush's UrlImageViewHelper

You can see Koush's original project here: https://github.com/koush/UrlImageViewHelper

Sample Usage
------------

It's really easy to use, there are a number of ExtensionMethods in the UrlImageViewHelper namespace for the ImageView class that take a couple different arguments as options.  Here's a very simple example of loading an image from a url, but initially displaying a default image while the image from a url is loading:

```csharp
var img = this.FindViewById<ImageView>(Resource.Id.SomeImageView);
img.SetUrlDrawable("http://site.com/image.png", Resource.Drawable.DefaultUrlImage);
```
