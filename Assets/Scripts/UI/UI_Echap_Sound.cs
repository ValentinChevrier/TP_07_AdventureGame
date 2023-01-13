using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Echap_Sound : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            AkSoundEngine.PostEvent("Play_UI_Parameter_Appear", this.gameObject);

        }


    }
}
