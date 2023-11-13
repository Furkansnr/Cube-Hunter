using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class admanager : MonoBehaviour
{
    private BannerView bannerView;
    //private InterstitialAd Interstitial;
    void Start()
    {
       MobileAds.Initialize(initStatus =>{ } ); 
       this.RequestBanner();
    }
    
    void RequestBanner()
    {
        string reklamID = "ca-app-pub-3940256099942544/6300978111";

        this.bannerView = new BannerView(reklamID, AdSize.Banner, AdPosition.Top);

        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }
}
