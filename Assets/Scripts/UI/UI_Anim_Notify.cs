using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class UI_Anim_Notify : MonoBehaviour
{
    public void PlayUiHover()
    {
        AkSoundEngine.PostEvent("Play_UI_Parameter_Hover", this.gameObject);
    }
    public void PlayUiAccept()
    {
        AkSoundEngine.PostEvent("Play_UI_Parameter_Accept", this.gameObject);
    }
    public void PlayUiDecline()
    {
        AkSoundEngine.PostEvent("Play_UI_Parameter_Decline", this.gameObject);
    }

    public void PlayUiOff()
    {
        AkSoundEngine.PostEvent("Play_UI_Parameter_Resume", this.gameObject);
    }

    public void PlayUiOn()
    {
        AkSoundEngine.PostEvent("Play_UI_Parameter_Appear", this.gameObject);
    }
}
