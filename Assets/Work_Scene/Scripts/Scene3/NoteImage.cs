using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteImage : MonoBehaviour {

    public GameObject Note;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Note.transform.position.x, Note.transform.position.y, Note.transform.position.z - Note.transform.localScale.y);

        SpriteRenderer spr = GetComponent<SpriteRenderer>();

        Color color = spr.color;
        color.a -= 0.02f;
        spr.color = color;

        if (spr.color.a <= 0)
        {
            color.a = 1;
            spr.color = color;
            ObjectPool.Instance.PushToPool(gameObject.name, gameObject);
        }
    }
}
