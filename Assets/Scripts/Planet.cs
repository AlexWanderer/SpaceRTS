using UnityEngine;
using UnityEditor;
using System.Collections;

public enum PlanetType {EARTH, ROCKY, OCEAN, GAS, LAVA, ICE};

public class Planet
{


    // Texture of different types of planets
    public Texture tex_earth;

    string name;
    PlanetType type; 
    Star host;

    int orbit;
    int speed;
    int level;

    public Planet(PlanetType type, Star host, int orbit)
    {
        this.type = type;
        this.host = host;
        this.orbit = orbit; 
    }

    public Planet(string name, PlanetType type, Star host, int orbit)
    {
        this.name = name;
        this.type = type;
        this.host = host;
        this.orbit = orbit;
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
