using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class StaticPersonaje : MonoBehaviour {

    public static StaticPersonaje instance;

    private int velocidadBasica = 10;
    private int fuerzaBasica = 10;


    public int velocidad;
    public int fuerza;

    public float posicionX;
    public float posicionY;

    public bool recienCargado;

    void Awake()
    {
       
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }


    }


    public void Guardar()
    {
        try
        {
            string nombreFichero = "PartidGuardada";
            BinaryFormatter formateador = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/" + nombreFichero + ".dat");

            DatosJugador data = new DatosJugador();
            data.velocidad = this.velocidad;
            data.fuerza = this.fuerza;
            Transform player = GameObject.FindGameObjectWithTag("Player").transform;
            data.posicionX = player.position.x;
            data.posicionY = player.position.y;
            formateador.Serialize(file, data);
            file.Close();

        }
        catch(Exception e)
        {
            print("error: " + e);
        }
    }

    public void Cargar()
    {
        string nombreFichero = "PartidGuardada";
        if (File.Exists(Application.persistentDataPath + "/" + nombreFichero + ".dat"))
        {
            BinaryFormatter formateador = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + nombreFichero + ".dat", FileMode.Open);
            DatosJugador data = (DatosJugador)formateador.Deserialize(file);
            file.Close();
            this.velocidad = data.velocidad;
            this.fuerza = data.fuerza;
            this.posicionX = data.posicionX;
            this.posicionY = data.posicionY;
            this.recienCargado = true;
        }
        else
        {
            print("El fichero no existe");
        }
    }

    public void SetToBasics()
    {
        velocidad = velocidadBasica;
        fuerza = fuerzaBasica;
        this.posicionX = 0;
        this.posicionY = 0;
    }
}

[Serializable]
class DatosJugador
{
    public int velocidad;
    public int fuerza;
    public float posicionX;
    public float posicionY;
}