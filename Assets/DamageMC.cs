using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMC : MonoBehaviour

{    public void PlayMCHit()
    {
        AkSoundEngine.PostEvent("Play_MC_Hit_Light", this.gameObject);
    }
}
