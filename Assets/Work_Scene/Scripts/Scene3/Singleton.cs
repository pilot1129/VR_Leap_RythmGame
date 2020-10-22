using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<Template> : MonoBehaviour where Template : MonoBehaviour {
    private static Template _instance;

    public static Template Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(Template)) as Template;

                if (_instance == null)
                    Debug.LogError("There's no active" + typeof(Template) + " in this scene");
            }
            return _instance;
        }
    }
}
