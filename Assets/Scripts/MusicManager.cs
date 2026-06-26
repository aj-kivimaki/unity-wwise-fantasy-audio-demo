using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    private bool _musicStarted;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        StartExplorationMusic();
    }

    public void StartExplorationMusic()
    {
        if (_musicStarted)
            return;

        SetExploration();

        AkSoundEngine.PostEvent("Play_Music", gameObject);

        _musicStarted = true;
    }

    public void SetExploration()
    {
        AkSoundEngine.SetState("Music", "Exploration");
    }

    public void SetCombat()
    {
        AkSoundEngine.SetState("Music", "Combat");
    }

    public void StopMusic()
    {
        AkSoundEngine.PostEvent("Stop_Music", gameObject);

        _musicStarted = false;
    }
}