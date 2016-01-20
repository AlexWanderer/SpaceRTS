using UnityEngine;
using System.Collections;

public class Populate : MonoBehaviour {

    public GameObject sun;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(sun, new Vector3(2 * i, 0, 0), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
