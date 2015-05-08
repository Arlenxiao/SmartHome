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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(SmartHome.Droid.CustomTabRenderer))]
namespace SmartHome.Droid
{
    public class CustomTabRenderer : TabbedRenderer
    {
        private Dictionary<Int32, Int32> icons = new Dictionary<Int32, Int32>();
        protected override void DispatchDraw(Android.Graphics.Canvas canvas)
        {
            getIcons();
            setIcons();
            base.DispatchDraw(canvas);
        }
        private void getIcons()
        {
            if (Element == null)
                return;
            int id = 0;
            foreach (var t in Element.Children)
            {
                if (icons.ContainsKey(id))
                    continue;
                if (t.Icon != "" && t.Icon != null)
                {
                    icons.Add(id, ResourceIdFromString(t.Icon));
                }
                id++;
            }
        }
        private int ResourceIdFromString(String name)
        {
            name = name.ToLower()
                .Replace(".png", "")
                .Replace(".jpg", "")
                .Replace(".jpeg", "")
                .Replace(".gif", "")
                .Replace(".ico", "");
            Type type = typeof(Resource.Drawable);
            foreach (var p in type.GetFields())
            {
                if (p.Name.ToLower() == name)
                    return (int)p.GetValue(null);
            }
            return 0;
        }

        private void setIcons()
        {
            var activity = this.Context as Activity;
            if (activity != null && activity.ActionBar != null)
            {
                for (int i = 0; i < activity.ActionBar.TabCount; i++)
                {
                    if (!icons.ContainsKey(i))
                        continue;
                    Android.App.ActionBar.Tab tab = activity.ActionBar.GetTabAt(i);
                    if (tab.Icon == null)
                    {
                        tab.SetIcon(icons[i]);
                    }
                }
            }
        }
    }
}