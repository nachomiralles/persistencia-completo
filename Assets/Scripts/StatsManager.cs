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
        fuerzaText.text = playerController.strength.ToString();
        velocidadText.text = playerController.velocity.ToString();
    }
}
