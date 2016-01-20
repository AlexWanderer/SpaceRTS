using UnityEngine;
using UnityEditor;
using System.Collections;

public enum PlanetType {EARTH, ROCKY, OCEAN, GAS, LAVA, ICE};

public class Planet : MonoBehaviour
{
    // Texture of different types of planets
    public Texture tex_earth;

    public string nickname;
    public PlanetType type; 
    Star host;

    int orbit;
    int speed;
    int level;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.mainTexture = tex_earth;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
