using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceSaveLoad : MonoBehaviour {


    public void Save()
    {
        StaticPersonaje.instance.Guardar();
    }

    public void Load()
    {
        StaticPersonaje.instance.Cargar();
        Time.timeScale = 1;
        SceneManager.LoadScene("Juego");
        
    }
}
