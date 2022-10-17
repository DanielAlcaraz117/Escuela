using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figuras : MonoBehaviour
{
    
    void Start()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(5, 5.5F, 0);
        cube.GetComponent<Renderer>().material.color = Color.red;
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5F, 0);
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(2, 1, 0);
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(-2, 1, 0);
        GameObject Quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        Quad.transform.position = new Vector3(-5, 2, 0);

    }


}
