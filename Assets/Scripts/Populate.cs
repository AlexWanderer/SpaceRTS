using UnityEngine;
using System.Collections.Generic;

public class Populate : MonoBehaviour {

    public GameObject star;
    List<GameObject> stars = new List<GameObject>();

    // Use this for initialization
    void Start() {
        stars.Add(Star.CreateStar(star, "sun", new Vector3(0, 0, 0), Quaternion.identity));
        stars.Add(Star.CreateStar(star, "quiche", new Vector3(2, 0, 0), Quaternion.identity));

    }


    // Update is called once per frame
    void Update () {
	
	}
}
