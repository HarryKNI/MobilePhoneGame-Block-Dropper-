using UnityEngine;
using UnityEngine.Advertisements;


public class UnityAdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string _androidGameId;
    [SerializeField] private string _iosGameId;
    [SerializeField] bool _testMode = true;
    private string _gameId;

    void Awake()
    {
        InitializeAds();
    }

    // Update is called once per frame
    void InitializeAds()
    {
        #if UNITY_IOS
            _gameId = _iosGameId;
        #elif UNITY_ANDROID
            _gameId = _androidGameId;
        #elif UNITY_EDITOR
            _gameId = _androidGameId;
        #endif

        if (!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(_gameId, _testMode, this);
        }
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity ads initialization Failed: {error.ToString()} - {message}");
    }
}
