using UnityEngine;
using UnityEditor;
using System.Collections;

public class PlanetBehaviour : MonoBehaviour {

    public Texture tex_sun;
    public Texture tex_earth;

    enum Type {SUN, EARTH};
    Type type;

    // Use this for initialization
    void Start () {

        switch (type)
        {
            case Type.SUN:
                gameObject.GetComponent<Renderer>().material.mainTexture = tex_sun;
                break;
            case Type.EARTH:
                gameObject.GetComponent<Renderer>().material.mainTexture = tex_earth;
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
