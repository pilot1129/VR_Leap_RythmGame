using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Judge : MonoBehaviour {
    void Update()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();

        Color color = spr.color;
        color.a -= 0.03f;
        spr.color = color;

        transform.localScale += new Vector3(0.00015f, 0.00015f, 0.00015f);

        if (spr.color.a <= 0)
        {
            color.a = 1;
            spr.color = color;
            ObjectPool.Instance.PushToPool(gameObject.name, gameObject);
        }
    }
}