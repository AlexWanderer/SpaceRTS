using UnityEngine;

public class Star : MonoBehaviour
{

    Planet[] planets = new Planet[10];
    GameObject obj;

    public string nickname;
    int level;

    public void AssignPlanet(Planet planet, int orbit)
    {
        if (orbit <= level + 3)
        {
            planets[orbit] = planet;
        }
    }

    public void levelUp()
    {
        level++;
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
