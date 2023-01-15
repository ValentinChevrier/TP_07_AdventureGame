using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STAFF_PickUp : MonoBehaviour
{
    public void PickUpStaff()
    {
        AkSoundEngine.PostEvent("Play_SFX_Staff_PickUp", this.gameObject);
    }
}
