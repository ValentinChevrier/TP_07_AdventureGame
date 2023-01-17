using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimNotifyPlayer : MonoBehaviour
{
    // BOSS
    [Header("BOSS Wwise Events")]
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
    [Space]
    //
    // BASIC MONSTERS
    //
    [Header("BASIC MONSTERS Wwise Events")]
    [Space]
    [SerializeField]
    private string BasicMonsterWalk;
    [SerializeField]
    private string BasicMonsterRunTexture;
    [SerializeField]
    private string BasicMonsterRunFront;
    [SerializeField]
    private string BasicMonsterRunBack;
    [SerializeField]
    private string BasicMonsterSpotted;
    [SerializeField]
    private string BasicMonsterHit;
    [SerializeField]
    private string BasicMonsterDeath;
    //
    [SerializeField]
    private string ChomperAttack;
    [SerializeField]
    private string SpitterAttackCast;
    [SerializeField]
    private string SpitterAttackImpact;
    [SerializeField]
    private string SpitterAttackDissolve;
    //
    [Space]
    //
    // MAIN CHARACTER
    //
    [Header("MAIN CHARACTER Wwise Events")]
    [Space]
    [SerializeField]
    private string MCFoleyRun;
    [SerializeField]
    private string MCFoleyJump;
    [SerializeField]
    private string MCFoleyLand;
    [SerializeField]
    private string MCFoleyRoll;
    [SerializeField]
    private string MCFoleyQuickTurn;
    //
    [SerializeField]
    private string MCHitLight;
    [SerializeField]
    private string MCHitHeavy;
    [SerializeField]
    private string MCRespawn;
    //
    [SerializeField]
    private string MCAttackMagicComboLight;
    [SerializeField]
    private string MCAttackMagicComboMedium;
    [SerializeField]
    private string MCAttackMagicComboHeavy;
    [SerializeField]
    private string MCAttackWooshComboLight;
    [SerializeField]       
    private string MCAttackWooshComboMedium;
    [SerializeField]      
    private string MCAttackWooshComboHeavy;
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
    //
    // BASIC MONSTERS 
    //
    private void PlayBasicEnemyWalk()
    {
        AkSoundEngine.PostEvent(BasicMonsterWalk, this.gameObject);
    }
    private void PlayBasicEnemyRunTexture()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunTexture, this.gameObject);
    }
    private void PlayBasicEnemyRunBackFoot()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunBack, this.gameObject);
    }
    private void PlayBasicEnemyRunFrontFoot()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunFront, this.gameObject);
    }
    private void PlayBasicEnemySpotted()
    {
        AkSoundEngine.PostEvent(BasicMonsterSpotted, this.gameObject);
    }
    private void PlayBasicEnemyHit()
    {
        AkSoundEngine.PostEvent(BasicMonsterHit, this.gameObject);
    }
    private void PlayBasicEnemyDeath()
    {
        AkSoundEngine.PostEvent(BasicMonsterDeath, this.gameObject);
    }
    private void PlayChomperAttack()
    {
        AkSoundEngine.PostEvent(ChomperAttack, this.gameObject);
    }
    private void PlaySpitterAttackCast()
    {
        AkSoundEngine.PostEvent(SpitterAttackCast, this.gameObject);
    }
    private void PlaySpitterAttackImpact()
    {
        AkSoundEngine.PostEvent(SpitterAttackImpact, this.gameObject);
    }
    private void PlaySpitterAttackDissolve()
    {
        AkSoundEngine.PostEvent(SpitterAttackDissolve, this.gameObject);
    }
    //
    // MAIN CHARACTER 
    //
    private void PlayMCFoleyRun()
    {
        AkSoundEngine.PostEvent(MCFoleyRun, this.gameObject);
    }
    private void PlayMCFoleyJump()
    {
        AkSoundEngine.PostEvent(MCFoleyJump, this.gameObject);
    }
    private void PlayMCFoleyLand()
    {
        AkSoundEngine.PostEvent(MCFoleyLand, this.gameObject);
    }
    private void PlayMCFoleyRoll()
    {
        AkSoundEngine.PostEvent(MCFoleyRoll, this.gameObject);
    }
    private void PlayMCFoleyQuickTurn()
    {
        AkSoundEngine.PostEvent(MCFoleyQuickTurn, this.gameObject);
    }
    private void PlayMCHitLight()
    {
        AkSoundEngine.PostEvent(MCHitLight, this.gameObject);
    }
    private void PlayMCHitHeavy()
    {
        AkSoundEngine.PostEvent(MCHitHeavy, this.gameObject);
    }
    private void PlayMCRespawn()
    {
        AkSoundEngine.PostEvent(MCRespawn, this.gameObject);
    }
    private void PlayMCAttackMagicCombo12()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboLight, this.gameObject);
    }
    private void PlayMCAttackMagicCombo3()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboMedium, this.gameObject);
    }
    private void PlayMCAttackMagicCombo4()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboHeavy, this.gameObject);
    }
    private void PlayMCAttackWooshCombo12()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboMedium, this.gameObject);
    }
    private void PlayMCAttackWooshCombo3()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboMedium, this.gameObject);
    }
    private void PlayMCAttackWooshCombo4()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboHeavy, this.gameObject);
    }

    // ça fait beaucoup là, non ?
}
