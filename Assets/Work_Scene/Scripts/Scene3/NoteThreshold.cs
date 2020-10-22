using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteThreshold : MonoBehaviour {

    public GameObject round;

	// Use this for initialization
	void Start () {
        Instantiate(round, transform.position, transform.rotation);
	}
}
