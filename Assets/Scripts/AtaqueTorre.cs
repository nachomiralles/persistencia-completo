using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueTorre : MonoBehaviour {

    // Use this for initialization
    private Transform jugador;
    public Transform arma;
    private float cadenceTime = 0.5f;
    private float lastShootTime = 0;


	void Start () {
        jugador = GameObject.Find("Personaje").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Atack();
	}

    void Atack()
    {
        if (Vector2.Distance(transform.position, jugador.position)<6  && Time.time-lastShootTime>cadenceTime)
        {
            Transform fuego = (Transform)Instantiate(arma, transform.position, Quaternion.identity);
            fuego.GetComponent<Rigidbody2D>().AddForce( (jugador.position - transform.position) * 300);
            Destroy(fuego.gameObject, 2);
            lastShootTime = Time.time;
        }

    }
}
