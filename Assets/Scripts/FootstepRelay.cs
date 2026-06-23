using UnityEngine;

public class FootstepRelay : MonoBehaviour
{
    public void Footstep()
    {
        AkSoundEngine.PostEvent("Play_RC_Footsteps_Stone", gameObject);
    }
}
