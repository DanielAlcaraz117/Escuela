using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
 public void DiaMuertos()
    {
        SceneManager.LoadScene("Demo");
    }
    public void Indepe()
    {
        SceneManager.LoadScene("Independencia");
    }
    public void Salir()
    {
        SceneManager.LoadScene("Salir");
    }
}
