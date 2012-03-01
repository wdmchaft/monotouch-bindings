// 
//  Copyright 2012  abhatia
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

using AppCircle = FlurryAppCircle.FlurryAppCircle;
using Analytics = FlurryAnalytics.FlurryAnalytics;

namespace FlurryAppCircleSample
{
	public class BannerViewController : DialogViewController
	{
		UIView _bannerView;
		public BannerViewController()
			: base(new RootElement("Banner API"), true)
		{
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			_bannerView = AppCircle.GetHook(AppCircleHooks.GLOBAL_APP_BANNER, 0, 0, this.View);
			AppCircleDelegate.CheckDataAvailability();
		}
		
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
		
		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews();
			
		}
	}
}

