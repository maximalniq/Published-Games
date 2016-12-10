using System;
using System.Collections;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour {
	private BannerView bannerView;
	private InterstitialAd interstitial;
	private static string outputMessage = "";
	public static bool BannerIsShown = false;
	public static string OutputMessage
	{
		set { outputMessage = value; }
	}
	
	void Start (){
		RequestInterstitial ();
		if (BannerIsShown == false) {
			RequestBanner ();
		}
	}

	public void DestroyBanner (){
		bannerView.Destroy ();
	}
	
	private void RequestBanner()
	{
		#if UNITY_EDITOR
		string adUnitId = "ca-app-pub-2880444457578799/9414114663";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-2880444457578799/9414114663";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-2880444457578799/4704713461";
		#else
		string adUnitId = "unexpected_platform";
		#endif
		
		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
		// Register for ad events.
		bannerView.AdLoaded += HandleAdLoaded;
		bannerView.AdFailedToLoad += HandleAdFailedToLoad;
		bannerView.AdOpened += HandleAdOpened;
		bannerView.AdClosing += HandleAdClosing;
		bannerView.AdClosed += HandleAdClosed;
		bannerView.AdLeftApplication += HandleAdLeftApplication;
		// Load a banner ad.
		bannerView.LoadAd(createAdRequest());
		BannerIsShown = true;
	}
	
	private void RequestInterstitial()
	{
		#if UNITY_EDITOR
		string adUnitId = "ca-app-pub-2880444457578799/1890847867";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-2880444457578799/1890847867";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-2880444457578799/6181446668";
		#else
		string adUnitId = "unexpected_platform";
		#endif
		
		// Create an interstitial.
		interstitial = new InterstitialAd(adUnitId);
		// Register for ad events.
		interstitial.AdLoaded += HandleInterstitialLoaded;
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad;
		interstitial.AdOpened += HandleInterstitialOpened;
		interstitial.AdClosing += HandleInterstitialClosing;
		interstitial.AdClosed += HandleInterstitialClosed;
		interstitial.AdLeftApplication += HandleInterstitialLeftApplication;
		// Load an interstitial ad.
		interstitial.LoadAd(createAdRequest());
	}
	
	// Returns an ad request with custom ad targeting.
	private AdRequest createAdRequest()
	{
		return new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)
				.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
				.AddKeyword("game")
				.SetGender(Gender.Male)
				.SetBirthday(new DateTime(1985, 1, 1))
				.TagForChildDirectedTreatment(false)
				.AddExtra("color_bg", "9B30FF")
				.Build();
		
	}
	
	public void ShowInterstitial()
	{
		if (interstitial.IsLoaded())
		{
			interstitial.Show();
			Debug.Log("pokajiad");
		}
		else
		{
			print("Interstitial is not ready yet.");
		}
	}
	
	#region Banner callback handlers
	
	public void HandleAdLoaded(object sender, EventArgs args)
	{
		print("HandleAdLoaded event received.");
	}
	
	public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		print("HandleFailedToReceiveAd event received with message: " + args.Message);
	}
	
	public void HandleAdOpened(object sender, EventArgs args)
	{
		print("HandleAdOpened event received");
	}
	
	void HandleAdClosing(object sender, EventArgs args)
	{
		print("HandleAdClosing event received");
	}
	
	public void HandleAdClosed(object sender, EventArgs args)
	{
		print("HandleAdClosed event received");
	}
	
	public void HandleAdLeftApplication(object sender, EventArgs args)
	{
		print("HandleAdLeftApplication event received");
	}
	
	#endregion
	
	#region Interstitial callback handlers
	
	public void HandleInterstitialLoaded(object sender, EventArgs args)
	{
		print("HandleInterstitialLoaded event received.");
	}
	
	public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		print("HandleInterstitialFailedToLoad event received with message: " + args.Message);
	}
	
	public void HandleInterstitialOpened(object sender, EventArgs args)
	{
		print("HandleInterstitialOpened event received");
	}
	
	void HandleInterstitialClosing(object sender, EventArgs args)
	{
		print("HandleInterstitialClosing event received");
	}
	
	public void HandleInterstitialClosed(object sender, EventArgs args)
	{
		print("HandleInterstitialClosed event received");
	}
	
	public void HandleInterstitialLeftApplication(object sender, EventArgs args)
	{
		print("HandleInterstitialLeftApplication event received");
	}
	
	#endregion
}