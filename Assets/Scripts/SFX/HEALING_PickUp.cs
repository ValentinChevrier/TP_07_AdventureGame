using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEALING_PickUp : MonoBehaviour
{
   public void PlayHealingPickUp()
    {
        AkSoundEngine.PostEvent("Play_SFX_Heal_OS", this.gameObject);
    }

    public void StopHealingPickUp()
    {
        AkSoundEngine.PostEvent("Stop_SFX_Heal_LP", this.gameObject);
    }
}
