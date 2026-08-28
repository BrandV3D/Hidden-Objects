using UnityEngine;
using System.Collections;
//using GoogleMobileAds.Api;

public class AdsController {

    public static AdsController instance;

    public GameController.Action onEnd;

    //private InterstitialAd interstitial;

    private void RequestInterstitial () {
       
        Debug.Log ("RequestInterstitial");
        
        #if UNITY_ANDROID
            string adUnitId = Settings.adsIdAndroid;
        #elif UNITY_IPHONE
            string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        /*interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);

        
        interstitial.OnAdFailedToLoad += (a, b) => {

            Debug.Log (a + "__AD_FAIL__" + b);
        };

        interstitial.OnAdLoaded += (a, b) => {

            Debug.Log (a + "__AD_COOL__" + b);
        };
        
        interstitial.OnAdClosed += (a, b) => {

            //onEnd ();
        };*/
    }

    public void Show (GameController.Action _onEnd) {
        
       /* onEnd = _onEnd;
        
        Debug.Log ("TryShowAd");
        
        if (interstitial.IsLoaded()) {

            Debug.Log ("Show");
            interstitial.Show();
            RequestInterstitial ();
            onEnd ();
        } else {
        */
            onEnd ();
        //}
        
    }

	public AdsController () {

        instance = this;
        RequestInterstitial ();
    }
}
