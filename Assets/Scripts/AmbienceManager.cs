using UnityEngine;

public class AmbienceManager : MonoBehaviour
{
    public static AmbienceManager Instance { get; private set; }

    [Header("Ambience Objects")]
    [SerializeField] private GameObject arenaAmbience;
    [SerializeField] private GameObject shrineAmbience;

    private bool _arenaPlaying;
    private bool _shrinePlaying;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void StartArena()
    {
        if (_arenaPlaying)
            return;

        AkSoundEngine.PostEvent("Play_Arena_Ambience", arenaAmbience);
        _arenaPlaying = true;
    }

    public void StopArena()
    {
        if (!_arenaPlaying)
            return;

        AkSoundEngine.PostEvent("Stop_Arena_Ambience", arenaAmbience);
        _arenaPlaying = false;
    }

    public void StartShrine()
    {
        if (_shrinePlaying)
            return;

        AkSoundEngine.PostEvent("Play_Shrine_Ambience", shrineAmbience);
        _shrinePlaying = true;
    }

    public void StopShrine()
    {
        if (!_shrinePlaying)
            return;

        AkSoundEngine.PostEvent("Stop_Shrine_Ambience", shrineAmbience);
        _shrinePlaying = false;
    }
}