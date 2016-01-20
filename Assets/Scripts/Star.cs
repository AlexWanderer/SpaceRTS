using UnityEngine;

public class Star : MonoBehaviour
{

    Planet[] planets = new Planet[10];
    GameObject obj;

    public string nickname;
    int level;

    public static GameObject CreateStar(GameObject obj, string name, Vector3 pos, Quaternion quat)
    {
        obj = (GameObject)Instantiate(obj, pos, quat);

        obj.AddComponent<Star>();
        obj.GetComponent<Star>().nickname = name;

        return obj;
    }

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
