using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimNotifyPlayer : MonoBehaviour
{
    // BOSS
    [Header("Boss Wwise Events")]
    [Space]
    //
    [SerializeField]
    private string FootstepWalk;
    [SerializeField]
    private string FootstepAnim;
    [SerializeField]
    private string Foley;
    //
    [SerializeField]
    private string Turn45;
    [SerializeField]
    private string Turn90;
    [SerializeField]
    private string Turn135;
    [SerializeField]
    private string Turn180;
    //
    [Space]
    //
    [SerializeField]
    private string Hit;
    [SerializeField]
    private string Death;
    //
    [Space]
    //
    [SerializeField]
    private string BasicAttackCharge;
    [SerializeField]
    private string BasicAttackCast;
    //
    [Space]
    //
    [SerializeField]
    private string Shockwave;
    [SerializeField]
    private string Shield;
    //
    [Space]
    //
    [SerializeField]
    private string GrenadeCast;
    [SerializeField]
    private string GrenadeBounce;
    [SerializeField]
    private string GrenadeExplosion;
    //
    private void PlayBossFootstepWalk()
    {
        AkSoundEngine.PostEvent(FootstepWalk, this.gameObject);
    }
    private void PlayBossFootstepAnim()
    {
        AkSoundEngine.PostEvent(FootstepAnim, this.gameObject);
    }
    private void PlayBossFoleyWalk()
    {
        AkSoundEngine.PostEvent(Foley, this.gameObject);
    }
    private void PlayBossFoleyTurn45()
    {
        AkSoundEngine.PostEvent(Turn45, this.gameObject);
    }
    private void PlayBossFoleyTurn90()
    {
        AkSoundEngine.PostEvent(Turn90, this.gameObject);
    }
    private void PlayBossFoleyTurn135()
    {
        AkSoundEngine.PostEvent(Turn135, this.gameObject);
    }
    private void PlayBossFoleyTurn180()
    {
        AkSoundEngine.PostEvent(Turn180, this.gameObject);
    }
    private void PlayBossGetHit()
    {
        AkSoundEngine.PostEvent(Hit, this.gameObject);
    }
    private void PlayBossDeath()
    {
        AkSoundEngine.PostEvent(Death, this.gameObject);
    }
    private void PlayBossBasicAttackCharge()
    {
        AkSoundEngine.PostEvent(BasicAttackCharge, this.gameObject);
    }
    private void PlayBossBasicAttackCast()
    {
        AkSoundEngine.PostEvent(BasicAttackCast, this.gameObject);
    }
    private void PlayBossShockwave()
    {
        AkSoundEngine.PostEvent(Shockwave, this.gameObject);
    }
    private void PlayBossShield()
    {
        AkSoundEngine.PostEvent(Shield, this.gameObject);
    }
    private void PlayBossGrenadeCast()
    {
        AkSoundEngine.PostEvent(GrenadeCast, this.gameObject);
    }
    private void PlayBossGrenadeBounce()
    {
        AkSoundEngine.PostEvent(GrenadeBounce, this.gameObject);
    }
    private void PlayBossGrenadeExplosion()
    {
        AkSoundEngine.PostEvent(GrenadeExplosion, this.gameObject);
    } 
}
