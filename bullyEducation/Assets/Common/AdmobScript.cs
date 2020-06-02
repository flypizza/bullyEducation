using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdmobScript : MonoBehaviour
{
    string App_ID = "ca-app-pub-7616984011467829~3560791396";
    string Banner_AD_ID = "ca-app-pub-7616984011467829/4682301379";
    // ca-app-pub-7616984011467829~3560791396 앱
    // ca-app-pub-7616984011467829/4682301379 배너

    private BannerView bannerView;
    private InterstitialAd insterstitial;
    private RewardBasedVideoAd rewardBasedVideoAd;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        MobileAds.Initialize(initStatus => { });
        //MobileAds.Initialize(App_ID);

        RequestBanner();
    }

    private void RequestBanner()
    {
        this.bannerView = new BannerView(Banner_AD_ID, AdSize.SmartBanner, AdPosition.Bottom);

        this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        this.bannerView.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        this.bannerView.OnAdClosed += this.HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.bannerView.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;
    }

    public void ShowBannerAd()
    {
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
    }
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        ShowBannerAd();
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

}
