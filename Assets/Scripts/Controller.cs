using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {



    bool mirandoDerecha = true;
    bool mirandoArriba = false;
 
    Vector2 direccionMirada = Vector2.down;

    public Transform arma;
    public Transform posicionInicialProyectil;

    Animator anim;
    Rigidbody2D miRigidBody;

    void Start()
    {
        miRigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

	void FixedUpdate () {
        Movement();
        CheckFacing();
        Atack();
    }

    void Atack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform espada = (Transform)Instantiate(arma, posicionInicialProyectil.position, posicionInicialProyectil.rotation);
            espada.GetComponent<Rigidbody2D>().AddForce(direccionMirada * StaticPersonaje.instance.fuerza * 100);
            Destroy(espada.gameObject, 2);
        }
    }

    void CheckFacing()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            direccionMirada = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            direccionMirada = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direccionMirada = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direccionMirada = Vector2.right;
        }

    }

    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        miRigidBody.velocity = new Vector2(moveX * StaticPersonaje.instance.velocidad, moveY * StaticPersonaje.instance.velocidad);
        if (moveX != 0) anim.SetBool("movingRight", true);
        else anim.SetBool("movingRight", false);
        if (moveY != 0) anim.SetBool("movingDown", true);
        else anim.SetBool("movingDown", false);

        if (moveX > 0 && !mirandoDerecha) GiroVertical();
        else if (moveX < 0 && mirandoDerecha) GiroVertical();

        if (moveY > 0 && !mirandoArriba) GiroHorizontal();
        else if (moveY < 0 && mirandoArriba) GiroHorizontal();
    }

    void GiroHorizontal()
    {
        mirandoArriba = !mirandoArriba;
        Vector3 escalaLocal = transform.localScale;
        escalaLocal.y *= -1;
        transform.localScale = escalaLocal;
    }

    void GiroVertical()
    {

        mirandoDerecha = !mirandoDerecha;
        Vector3 escalaLocal = transform.localScale;
        escalaLocal.x *= -1;
        transform.localScale = escalaLocal;
    }

    public void playerKilled()
    {
        Time.timeScale = 0;

    }
}
