using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class AnimNotifyPlayer : MonoBehaviour
{
    [SerializeField]
    private string BossFootstep;
    [SerializeField]
    private string BossFoley;

    private void PlayBossFootstep()
    {
        AkSoundEngine.PostEvent(BossFootstep, this.gameObject);
    }
    private void PlayBossFoley()
    {
        AkSoundEngine.PostEvent(BossFoley, this.gameObject);
    }
}
