using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamere : MonoBehaviour
{
    private new Transform camera;
    public Vector2 sensibility;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Camera");
   
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");   

        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor);
        }
        if (ver != 0)
        {

            //camera.Rotate(Vector3.left * ver);
            float angle = (camera.localEulerAngles.x - ver);

            camera.localEulerAngles = Vector3.right * angle;

        }
    }
}
