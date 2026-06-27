using UnityEngine;

public class ShrineAmbienceTrigger : MonoBehaviour
{
    private bool _triggered;

    private void OnTriggerEnter(Collider other)
    {
        if (_triggered)
            return;

        if (!other.CompareTag("Player"))
            return;

        AmbienceManager.Instance.StartShrine();

        _triggered = true;
    }
}