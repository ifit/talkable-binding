using System;
using Foundation;
using ObjCRuntime;
using Social;
using UIKit;
using WebKit;

namespace TalkableApi
{

	// @interface Talkable : NSObject
	[BaseType(typeof(NSObject))]
	
	interface TalkableWrapperApi
	{
		[Export ("setApiKey:andSiteSlug:")]
		void SetApiKey(string apiKey, string siteSlug);

		[Export("handleOpenURL:")]
		bool HandleOpenURL(string url);
	}
}
