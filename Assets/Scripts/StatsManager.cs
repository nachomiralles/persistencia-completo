using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {
    public Text fuerzaText;
    public Text velocidadText;

    public Controller playerController;

	
	
	// Update is called once per frame
	void Update () {
        fuerzaText.text = StaticPersonaje.instance.fuerza.ToString();
        velocidadText.text = StaticPersonaje.instance.velocidad.ToString();
        SubirBajarFuerza();
        SubirBajarVelocidad();

    }

    void SubirBajarFuerza()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StaticPersonaje.instance.fuerza++;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            StaticPersonaje.instance.fuerza--;
        }
    }
    void SubirBajarVelocidad()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            StaticPersonaje.instance.velocidad++;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            StaticPersonaje.instance.velocidad--;
        }
    }
}
