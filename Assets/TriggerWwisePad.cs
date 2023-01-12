using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D.GameCommands
{
    public class TriggerWwisePad : MonoBehaviour
{
        public void PlaySound()
        {
            AkSoundEngine.PostEvent("Play_Grenade_Cast", this.gameObject);
        }
        public LayerMask layers;

        void OnTriggerEnter(Collider other)
        {
            if (0 != (layers.value & 1 << other.gameObject.layer))
            {
                PlaySound();
            }
        }
    }
}

