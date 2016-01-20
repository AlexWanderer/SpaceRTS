using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

    public static GameObject CreateStar(GameObject obj, string name, Vector3 pos, Quaternion quat)
    {
        obj = (GameObject)Instantiate(obj, pos, quat);

        obj.AddComponent<Star>();
        obj.GetComponent<Star>().nickname = name;

        return obj;
    }

    public static GameObject CreatePlanet(GameObject obj, string name, PlanetType type, Star host, int orbit, Vector3 pos, Quaternion quat)
    {
        obj = (GameObject)Instantiate(obj, pos, quat);
        host.AssignPlanet(obj.GetComponent<Planet>(), orbit);

        obj.AddComponent<Planet>();
        obj.GetComponent<Planet>().nickname = name;
        obj.GetComponent<Planet>().type = type;

        return obj;
    }


}
