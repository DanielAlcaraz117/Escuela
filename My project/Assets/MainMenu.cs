using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void EcenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
    public void Independencia(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }


}
