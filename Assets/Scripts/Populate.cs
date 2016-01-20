using UnityEngine;
using System.Collections.Generic;

public class Populate : MonoBehaviour {

    public GameObject star;
    List<GameObject> stars = new List<GameObject>();
    List<GameObject> planets = new List<GameObject>();

    // Use this for initialization
    void Start() {
        stars.Add(Factory.CreateStar(star, "sun", new Vector3(0, 0, 0), Quaternion.identity));
        stars.Add(Factory.CreateStar(star, "quiche", new Vector3(2, 0, 0), Quaternion.identity));
        planets.Add(Factory.CreatePlanet(star, "earth", PlanetType.EARTH, stars[0].GetComponent<Star>(), 0, new Vector3(5, 0, 0), Quaternion.identity));
    }

    // Update is called once per frame
    void Update () {
	
	}
}
