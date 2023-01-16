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
    [Space]
    [Header("Basic Monsters")]
    [Space]
    //
    [SerializeField]
    private string BasicMonsterWalk;
    [SerializeField]
    private string BasicMonsterRunTexture;
    [SerializeField]
    private string BasicMonsterRunBack;
    [SerializeField]
    private string BasicMonsterRunFront;
    //
    [SerializeField]
    private string BasicMonsterHit;
    [SerializeField]
    private string BasicMonsterDeath;
    [SerializeField]
    private string BasicMonsterSpotted;
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
    // Main Character
    //
    [Space]
    [Header("Main Character")]
    [Space]
    //
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
    //
    [SerializeField]
    private string MCAttackWooshComboLight;
    [SerializeField]
    private string MCAttackWooshComboMedium;
    [SerializeField]
    private string MCAttackWooshComboHeavy;
    [SerializeField]
    private string MCAttackMagicComboLight;
    [SerializeField]       
    private string MCAttackMagicComboMedium;
    [SerializeField]       
    private string MCAttackMagicComboHeavy;

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
    private void PlayBasicMonsterWalk()
    {
        AkSoundEngine.PostEvent(BasicMonsterWalk, this.gameObject);
    }
    private void PlayBasicMonsterRunTexture()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunTexture, this.gameObject);
    }
    private void PlayBasicMonsterRunFrontFoot()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunFront, this.gameObject);
    }
    private void PlayBasicMonsterRunBackFoot()
    {
        AkSoundEngine.PostEvent(BasicMonsterRunBack, this.gameObject);
    }
    private void PlayBasicMonsterHit()
    {
        AkSoundEngine.PostEvent(BasicMonsterHit, this.gameObject);
    }
    private void PlayBasicMonsterDeath()
    {
        AkSoundEngine.PostEvent(BasicMonsterDeath, this.gameObject);
    }
    private void PlayBasicMonsterSpotted()
    {
        AkSoundEngine.PostEvent(BasicMonsterSpotted, this.gameObject);
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
    // Main Character
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
    private void PlayMCFoleyQuickTurn()
    {
        AkSoundEngine.PostEvent(MCFoleyQuickTurn, this.gameObject);
    }
    private void PlayMCFoleyRoll()
    {
        AkSoundEngine.PostEvent(MCFoleyRoll, this.gameObject);
    }
    private void PlayMCHitLight()
    {
        AkSoundEngine.PostEvent(MCHitLight, this.gameObject);
    }
    private void PlayMCHitHeavy()
    {
        AkSoundEngine.PostEvent(MCHitHeavy, this.gameObject);
    }
    private void PlayMCWooshCombo12()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboLight, this.gameObject);
    }
    private void PlayMCWooshCombo3()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboMedium, this.gameObject);
    }
    private void PlayMCWooshCombo4()
    {
        AkSoundEngine.PostEvent(MCAttackWooshComboHeavy, this.gameObject);
    }
    private void PlayMCMagicCombo12()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboLight, this.gameObject);
    }
    private void PlayMCMagicCombo3()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboMedium, this.gameObject);
    }
    private void PlayMCMagicCombo4()
    {
        AkSoundEngine.PostEvent(MCAttackMagicComboHeavy, this.gameObject);
    }
}

