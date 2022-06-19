//============================================================
// Bullet.cs
//======================================================================
// �J������
//
// 2022/06/05 ����J�n
//
//======================================================================
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float fDamage;
    int nID;

    public void SetBullet(Transform _chara, int _charaid, GameObject _bullet, float _atk, float _shotpower)
    {
        // 2D���Z��
        Vector3 Force;
        Force = _chara.right * _shotpower; 
        _bullet.GetComponent<Rigidbody2D>().velocity = Force;
        

        nID = _charaid;
        fDamage = _atk;

        Destroy(this.gameObject, 3.0f);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(nID)
        {
            case 0: // �e���L�҂�"Player"
                if (collision.gameObject.CompareTag("Enemy"))
                {
                    collision.gameObject.GetComponent<Character>().AddDamage(fDamage);
                }
                break;
            case 1: // �e���L�҂�"Enemy"
                if (collision.gameObject.CompareTag("Player"))
                {
                    collision.gameObject.GetComponent<Character>().AddDamage(fDamage);
                }
                break;

        }
        Destroy(this.gameObject);

    }
}
