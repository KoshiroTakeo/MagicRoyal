//============================================================
// Character.cs
//======================================================================
// �J������
//
// 2022/06/04 ����J�n
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

    // �_���[�W���� =============================
    public void AddDamage(float _damage)
    {
        if (bArmor == true) return;
        sound.Damage(this.gameObject);
        fHP -= _damage;

        // �v���C���[�Ȃ�
        if(eType == 0) StartCoroutine(ArmorTime());
    }

    IEnumerator ArmorTime()
    {
        bArmor = true;
        yield return new WaitForSeconds(nArmorTime);
        bArmor = false;
    }
    //===========================================

    // ���S���� =================================
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
    
    // �o���l�擾 ===============================
    public void AddExp(int _exp)
    {
        fExp += _exp;
        sound.GetExp(this.gameObject);
    }
    //===========================================

    // ���x���A�b�v���� =========================
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

    // �����i�Ĕz�u�j�ʒu =======================
    protected void SetPosition()
    {
        SetPos = this.transform.position;
    }
    //===========================================

    // ���C�t�Q�[�W =============================
    protected void ViewLife()
    {
        float value = fHP / fMaxHp;
        LifeGauge.fillAmount = value;
    }
    //===========================================

    // EXP�Q�[�W ================================
    protected void ViewEXP()
    {
        float value = fExp / fMaxExp;
        ExpGauge.fillAmount = value;
    }
    //===========================================

    // ���S���� =================================
    IEnumerator DeathProcess()
    {
        if ((int)eType == 1) TargetObj.GetComponent<PlayerManager>().AddExp((int)fExpPoint);
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
    //===========================================
}

