// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SoundCloundImages.CS
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TweetButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TweetDetail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView TweetImage { get; set; }

        [Action ("TweetButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TweetButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (TweetButton != null) {
                TweetButton.Dispose ();
                TweetButton = null;
            }

            if (TweetDetail != null) {
                TweetDetail.Dispose ();
                TweetDetail = null;
            }

            if (TweetImage != null) {
                TweetImage.Dispose ();
                TweetImage = null;
            }
        }
    }
}