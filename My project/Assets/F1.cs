using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1 : MonoBehaviour
{
    public Material material;
    // Start is called before the first frame update
    public void Colores()
    {
    material.color = Color.cyan;
    }
    void Start()
    {
        GameObject hexagon = GameObject.CreatePrimitive(PrimitiveType.);
        hexagon.transform.position = new Vector3(-1, 1, 0);
        hexagon.GetComponent<Renderer>().material.color = Color.cyan;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
