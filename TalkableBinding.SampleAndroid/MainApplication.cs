using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Talkable.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalkableBinding.SampleAndroid
{
	[Application]
	public class MainApplication : Application
	{
		protected MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();
			Talkable.Initialize(this);
		}
	}
}