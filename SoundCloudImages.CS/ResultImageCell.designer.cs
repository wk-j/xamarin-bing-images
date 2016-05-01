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
    [Register ("ResultImageCell")]
    partial class ResultImageCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SoundCloudImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SoundCloudImage != null) {
                SoundCloudImage.Dispose ();
                SoundCloudImage = null;
            }
        }
    }
}