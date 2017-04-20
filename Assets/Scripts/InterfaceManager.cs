using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour {

    public GameObject escapeMenu;
    public GameObject statsMenu;

    void Update()
    {
        ManageEscapeMenu();
        ManageStatsMenu();
    }

    void ManageEscapeMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!escapeMenu.activeSelf)
            {
                escapeMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                escapeMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    void ManageStatsMenu()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!statsMenu.activeSelf)
            {
                statsMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                statsMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
