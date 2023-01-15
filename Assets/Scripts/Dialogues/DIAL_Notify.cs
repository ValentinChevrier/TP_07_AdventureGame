using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIAL_Notify : MonoBehaviour
{
    public void PlayDial01()
    {
        AkSoundEngine.PostEvent("Play_VOX_Dialog01", this.gameObject);
    }

    public void PlayDial02()
    {
        AkSoundEngine.PostEvent("Play_VOX_DialogJump", this.gameObject);
    }

    public void PlayDial03()
    {
        AkSoundEngine.PostEvent("Play_VOX_Dialog03", this.gameObject);
    }

    public void PlayDial04()
    {
        AkSoundEngine.PostEvent("Play_VOX_Dialog04", this.gameObject);
    }

    public void PlayDial05()
    {
        AkSoundEngine.PostEvent("Play_VOX_Dialog05", this.gameObject);
    }
}
