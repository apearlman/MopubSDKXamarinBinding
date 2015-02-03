using System;
using ObjCRuntime;


[assembly: LinkWith ("libMoPubSDK-armv7.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "AdSupport CoreGraphics CoreTelephony EventKit EventKitUI Foundation MediaPlayer QuartzCore StoreKit SystemConfiguration UIKit AudioToolbox AVFoundation iAd MessageUI MobileCoreServices PassKit Social")]
