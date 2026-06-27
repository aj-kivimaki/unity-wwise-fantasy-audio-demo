using UnityEngine;

public class CombatEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        MusicManager.Instance.SetPostCombat();
        AmbienceManager.Instance.StopArena();

        gameObject.SetActive(false);
    }
}