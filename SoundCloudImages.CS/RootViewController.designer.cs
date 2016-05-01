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
    [Register ("RootViewController")]
    partial class RootViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView ImageCollection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField KeywordTextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NumberOfImagesLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView ProgressIndicator { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton QueryButton { get; set; }

        [Action ("QueryButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void QueryButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ImageCollection != null) {
                ImageCollection.Dispose ();
                ImageCollection = null;
            }

            if (KeywordTextBox != null) {
                KeywordTextBox.Dispose ();
                KeywordTextBox = null;
            }

            if (NumberOfImagesLabel != null) {
                NumberOfImagesLabel.Dispose ();
                NumberOfImagesLabel = null;
            }

            if (ProgressIndicator != null) {
                ProgressIndicator.Dispose ();
                ProgressIndicator = null;
            }

            if (QueryButton != null) {
                QueryButton.Dispose ();
                QueryButton = null;
            }
        }
    }
}