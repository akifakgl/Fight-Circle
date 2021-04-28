using GoogleMobileAds.Api;
using UnityEngine;

public class AdManager : MonoBehaviour
{

    public static AdManager instance;

    //TODO: Buradaki appId'ye kendi appIdinizi yapıştırın.
    private string _appId = "Buraya kendi Uygulama kimliğinizi girmelsiniz.";
    // Tam ekran reklam göstermek için gereken test id si
    private string _fullScreenAdId = "ca-app-pub-3940256099942544/1033173712";

    private InterstitialAd _fullscreenAd;

    // FULLSCREENAD - START
    void requestFullScreenAd()
    {
        _fullscreenAd = new InterstitialAd(_fullScreenAdId);

        AdRequest adRequest = new AdRequest.Builder().Build();

        _fullscreenAd.LoadAd(adRequest);
    }

    void showFullScreenAd()
    {
        requestFullScreenAd();
        if (_fullscreenAd.IsLoaded())
        {
            _fullscreenAd.Show();
        }
        else
        {
            Debug.Log("FullScreenAd daha yüklenmedi!!");
        }
    }
    // FULLSCREENAD - END


    private void Update()
    {
        // FullScreen reklamamızı test etmek için F tuşuna basacağız.
        if (Input.GetKeyDown(KeyCode.F))
        {
            showFullScreenAd();
        }


    }
}