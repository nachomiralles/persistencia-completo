using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour {

    public void LoadGameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Juego");
    }

    public void LoadStartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Inicio");
    }

}
