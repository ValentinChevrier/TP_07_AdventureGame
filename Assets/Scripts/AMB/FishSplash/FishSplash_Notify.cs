using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSplash_Notify : MonoBehaviour
{
    private void PlayFishSplash()
    {
        AkSoundEngine.PostEvent("Play_AMB_FishWater_Splash", this.gameObject);
    } 
}
