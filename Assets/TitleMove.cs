using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    public RectTransform TitleRogo;
    public float moveY;
    float counttime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("aaa");
        counttime += Time.deltaTime;
        TitleRogo.anchoredPosition = new Vector2(0, Mathf.Sin(moveY * counttime));
    }
}
