using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater :MonoBehaviour
{
    GameObject Enemy;
    Vector3 GeneratePos;
    public float PosRange;
    public int maxEnemy;
    int i = 30;

   
    public void Geneate()
    {

        GeneratePos = new Vector3((int)Random.Range(-10, PosRange), 10, 0);
        Instantiate(Enemy, GeneratePos, Quaternion.identity);
    }

    public EnemyGenerater(GameObject _enemy, float _posrange)
    {
        Enemy = _enemy;
        PosRange = _posrange;                                    
    }
}
