using System.Collections;
using UnityEngine;

public class Instantiate512cubes : MonoBehaviour {

    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[128];
    public float _maxScale;
    // Use this for initialization
	void Start () {

        /*
        for(int i = 0; i< 128; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            //this.transform.eulerAngles = new Vector3(0, -0.703125f * (i), 0); // 360/512
            this.transform.eulerAngles = new Vector3(0, -2.8125f * (i), 0);
            //this.transform.localPosition = new Vector3(i, 0, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 100;
            _sampleCube[i] = _instanceSampleCube;
        }
        */
        Vector3 center = Vector3.zero;
        float radius = 10.0f;
        for (int i =0; i<128; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            float ang = i * 1.0f / 128;
            ang = ang * Mathf.PI * 2;

            float x = center.x + Mathf.Cos(ang-29.8f) * radius; // 각도
            float y = center.y + Mathf.Sin(ang-29.8f) * radius; // 각도

            Vector3 pos = center + new Vector3(0.3f*x,0.3f*y -0.5f,4); // 중앙점 위치 조정
            _instanceSampleCube.transform.position = pos;
            _instanceSampleCube.transform.rotation = Quaternion.LookRotation(Vector3.forward, pos);
            _sampleCube[i] = _instanceSampleCube;
        }
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i< 128; i++)
        {
            if (_sampleCube != null)
                _sampleCube[i].transform.localScale = new Vector3(0.5f, (AudioPeer._samples[i + 512] * _maxScale)*0.001f, 4); // 각 큐브가 커지는 스케일 조정
            // _sampleCube[i].transform.localScale = new Vector3(10, (AudioPeer._samples[i] * _maxScale)+2, 10);
        }
    }
}
