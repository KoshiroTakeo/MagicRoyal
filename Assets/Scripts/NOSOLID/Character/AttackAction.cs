//============================================================
// AttackAction.cs
//======================================================================
// äJî≠óöó
//
// 2022/06/04 êßçÏäJén
//
//======================================================================
using UnityEngine;

public abstract class AttackAction 
{
    public void Attack(GameObject _bulletobj)
    {

    }

    public void Hit(GameObject _obj, float _damage)
    {
        _obj.GetComponent<Character>().AddDamage(_damage);
    }

    
}

public class BulletAttack : AttackAction
{
    public void Bullet(GameObject _mazzle, Vector2 _bulletscall, Transform _chara, int _nID, float _atk, float _shotpower, Animator _anim)
    {
        GameObject bullet = new GameObject("Bullet");
        Texture2D texture2D = new Texture2D(128,128);

        Sprite bulletsprite = Sprite.Create(texture2D, new Rect(0,0,texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

        bullet.transform.localScale = _bulletscall;
        bullet.transform.rotation = _mazzle.transform.rotation;
        bullet.transform.position = _mazzle.transform.position;

        bullet.AddComponent<SpriteRenderer>();
        bullet.GetComponent<SpriteRenderer>().sprite = bulletsprite;
        bullet.AddComponent<CircleCollider2D>();
        bullet.AddComponent<Rigidbody2D>();
        bullet.AddComponent<Bullet>();
        bullet.GetComponent<Bullet>().SetBullet(_chara, _nID, bullet, _atk, _shotpower);

        _anim.SetTrigger("AttackTrriger");
    }
}