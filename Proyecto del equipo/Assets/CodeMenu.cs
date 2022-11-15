using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeMenu : MonoBehaviour
{
    public void DiaMuertos()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Indepe()
    {
        SceneManager.LoadScene("Independencia");
    }
    public void Salir()
    {
        Application.Quit();
    }

}
