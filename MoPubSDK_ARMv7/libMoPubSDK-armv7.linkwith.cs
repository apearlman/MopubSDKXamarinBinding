using System;
using ObjCRuntime;

using UIKit;
using CoreLocation;
using CoreVideo;
using AVFoundation;
using MediaPlayer;
using StoreKit;
using CoreMedia;
using EventKit;
using EventKitUI;
using Foundation;

[assembly: LinkWith ("libMoPubSDK-armv7.a", LinkTarget.ArmV7 | LinkTarget.Arm64, ForceLoad = true, Frameworks = "AdSupport CoreGraphics CoreTelephony EventKit EventKitUI Foundation MediaPlayer QuartzCore StoreKit SystemConfiguration UIKit AudioToolbox AVFoundation iAd MessageUI MobileCoreServices PassKit Social")]
