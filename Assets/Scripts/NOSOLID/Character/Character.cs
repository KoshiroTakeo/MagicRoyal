//============================================================
// Character.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;
using System.Collections;
using Players;

public class Character : Stutas, IDamageble<float>, IExpable<int>
{
    

    bool bArmor = false;
    float nArmorTime = 0.5f;

    protected Vector3 SetPos;

    // ダメージ判定 =============================
    public void AddDamage(float _damage)
    {
        if (bArmor == true) return;
        sound.Damage(this.gameObject);
        fHP -= _damage;

        // プレイヤーなら
        if(eType == 0) StartCoroutine(ArmorTime());
    }

    IEnumerator ArmorTime()
    {
        bArmor = true;
        yield return new WaitForSeconds(nArmorTime);
        bArmor = false;
    }
    //===========================================

    // 死亡判定 =================================
    protected void HPChecker()
    {
        ViewLife();

        if (fHP < 0 && Death == false)
        {
            sound.Death(this.gameObject);
            Anim.SetTrigger("Death");
            Death = true;
            StartCoroutine(DeathProcess());
        }
    }
    //===========================================
    
    // 経験値取得 ===============================
    public void AddExp(int _exp)
    {
        fExp += _exp;
        sound.GetExp(this.gameObject);
    }
    //===========================================

    // レベルアップ判定 =========================
    protected void ExpChecker()
    {
        ViewEXP();

        if (fExp >= fMaxExp)
        {
            UpdataStatus();
            sound.LvUP(this.gameObject);
            Debug.Log(nLV);
        }
    }
    //===========================================

    // 初期（再配置）位置 =======================
    protected void SetPosition()
    {
        SetPos = this.transform.position;
    }
    //===========================================

    // ライフゲージ =============================
    protected void ViewLife()
    {
        float value = fHP / fMaxHp;
        LifeGauge.fillAmount = value;
    }
    //===========================================

    // EXPゲージ ================================
    protected void ViewEXP()
    {
        float value = fExp / fMaxExp;
        ExpGauge.fillAmount = value;
    }
    //===========================================

    // 死亡処理 =================================
    IEnumerator DeathProcess()
    {
        if ((int)eType == 1) TargetObj.GetComponent<PlayerManager>().AddExp((int)fExpPoint);
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
    //===========================================
}

