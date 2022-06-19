// Stutas .cs
//======================================================================
// 開発履歴
//
// 2022/06/03 制作開始
//
//======================================================================
using UnityEngine;
using UnityEngine.UI;

public class Stutas : MonoBehaviour
{
    public enum CharacterType
    {
        PLAYER = 0,
        ENEMY = 1,

        MAX,
    }
    public CharacterType eType;

    [SerializeField] protected CharacterData Data;
    [SerializeField] protected StutasWindow ShowWindow;
    protected SoundManager sound;
    protected Transform TargetObj; // 攻撃する対象
    protected Rigidbody2D Rb2D;
    protected Animator Anim;
    [SerializeField] protected Image LifeGauge;
    [SerializeField] protected Image ExpGauge;

    [Header("ステータス")]
    [SerializeField]protected int nLV = 1;
    [SerializeField] protected float fHP = 1;
    [SerializeField] protected float fATK = 1;
    [SerializeField] protected float fDEF = 1;
    [SerializeField] protected float fSPD = 1;
    protected float fMaxHp = 1;
    protected float fMaxExp = 1;
    [SerializeField] protected float fExp = 0;

    protected float fJumpPower = 0;
    protected float fWeight = 0;
    protected float fBulletSpeed = 1;
    protected float fUpstatus = 0.2f;
    protected float fAtkInterbal = 0;
    protected float fExpPoint = 1;

    protected bool Death = false;

    

    protected void InitStatus()
    {
        eType = (CharacterType)Data.eSetType;

        fHP += Data.fHP;
        fATK += Data.fATK;
        fDEF += Data.fDEF;
        fSPD += Data.fSPD;

        fMaxHp = fHP;
        fJumpPower += Data.fJumpPower;
        fBulletSpeed += fSPD * 0.5f;
        fWeight += Data.fWeight;
        fAtkInterbal += Data.Atk_Interbal;
        fExpPoint += Data.nExpPoint;
        fMaxExp += Data.fMaxEXP;

        Rb2D = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        sound = GetComponent<SoundManager>();

        if(eType == 0) ShowWindow.ShowStutas(nLV, fMaxHp, fATK, fDEF, fSPD);
    }

    protected virtual void UpdataStatus()
    {
        nLV++;

        fMaxHp += Data.fHP * (nLV * fUpstatus);
        fHP = fMaxHp;
        fATK += Data.fATK * (nLV * fUpstatus);
        fDEF += Data.fDEF * (nLV * fUpstatus);
        fSPD += Data.fSPD * (nLV * fUpstatus);

        ShowWindow.ShowStutas(nLV, fMaxHp, fATK, fDEF, fSPD);

        fMaxExp += Data.fMaxEXP * (nLV * fUpstatus);
        fExpPoint += Data.nExpPoint * (nLV * fUpstatus);


        fExp = 0;
    }
}
