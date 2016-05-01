using Foundation;
using System;
using UIKit;
using SDWebImage;
using BingImages.Shared;

namespace SoundCloundImages.CS
{
	public partial class RootViewController : UIViewController, IUICollectionViewSource
    {
		private BingHelper _helper;

        public RootViewController (IntPtr handle) : base (handle)
        {
			_helper = new BingHelper ();
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			ImageCollection.WeakDataSource = this;
		}

		partial void QueryButton_TouchUpInside (UIButton sender)
		{
			StartQuery (KeywordTextBox.Text);
		}

		async void StartQuery (String keyword)
		{
			ProgressIndicator.StartAnimating ();
			await _helper.QuerySoundClound (keyword);
			NumberOfImagesLabel.Text = "Search Results: " + _helper.Images.Count;
			ImageCollection.ReloadData ();
			ProgressIndicator.StopAnimating ();
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);
			var vc = (DetailViewController)segue.DestinationViewController;
			var cell = (ResultImageCell)sender;
			vc.TheImage = cell.TheImage.Image;
			vc.Detail = cell.Detail;
		}


		public UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (ResultImageCell)collectionView.DequeueReusableCell ("image", indexPath);
			var result = _helper.Images [indexPath.Row];
			cell.TheImage.SetImage (
				url: new NSUrl (result.MediaUrl)
			);
			cell.Detail = result.Title;
			return cell;
		}

		public nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return (nint) _helper.Images.Count;
		}
    }
}