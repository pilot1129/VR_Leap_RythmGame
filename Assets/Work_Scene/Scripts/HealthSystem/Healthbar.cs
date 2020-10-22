using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

    public Image currentHealthbar;
    private float hitpoint = 100;
    private float maxhitpoint = 100;


    public void Start()
    {
        UpdateHealthbar();
    }

    public void UpdateHealthbar()
    {
        float ratio = hitpoint / maxhitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1); // 크기조정
    }

    public void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if(hitpoint<0)
        {
            hitpoint = 0;
            //게임종료 출력
        }
        UpdateHealthbar();
    }

    public void HealDamage(float heal)
    {
        hitpoint += heal;
        if(hitpoint>100)
        {
            hitpoint = maxhitpoint;
        }
        UpdateHealthbar();
    }
}
