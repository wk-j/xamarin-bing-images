using Foundation;
using System;
using UIKit;

namespace SoundCloundImages.CS
{
    public partial class DetailViewController : UIViewController
    {
		public UIImage TheImage { set; get; }
		public string Detail { set; get; }

		public DetailViewController (IntPtr handle) : base (handle)
        {
        }

		partial void TweetButton_TouchUpInside (UIButton sender)
		{
			var tweet = new Twitter.TWTweetComposeViewController ();
			tweet.AddImage (TheImage);
			PresentViewControllerAsync (tweet, true);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			TweetImage.Image = TheImage;
			TweetDetail.Text = Detail;
		}
    }
}