//=================================================================================================
//�@�o���b�g�̃I�u�W�F�N�g
//�@20220611
//
//=================================================================================================
using UnityEngine;

public class BulletObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var hit = collision.gameObject;
        //var isdamage = hit.GetComponent<IDamageble>();
        //if (isdamage != null) isdamage.AddDamage();
    }
}
