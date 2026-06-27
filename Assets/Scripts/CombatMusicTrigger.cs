using UnityEngine;

public class CombatMusicTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        MusicManager.Instance.SetCombat();
        AmbienceManager.Instance.StartArena();

        gameObject.SetActive(false);
    }
}