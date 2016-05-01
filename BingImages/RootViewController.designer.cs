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

namespace BingImages
{
    [Register ("RootViewController")]
    partial class RootViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonQuery { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView ImageCollection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelResults { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView ProgressBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldSearch { get; set; }


        [Action ("ButtonQuery_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonQuery_TouchUpInside (UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ButtonQuery != null) {
                ButtonQuery.Dispose ();
                ButtonQuery = null;
            }

            if (ImageCollection != null) {
                ImageCollection.Dispose ();
                ImageCollection = null;
            }

            if (LabelResults != null) {
                LabelResults.Dispose ();
                LabelResults = null;
            }

            if (ProgressBar != null) {
                ProgressBar.Dispose ();
                ProgressBar = null;
            }

            if (TextFieldSearch != null) {
                TextFieldSearch.Dispose ();
                TextFieldSearch = null;
            }
        }
    }
}