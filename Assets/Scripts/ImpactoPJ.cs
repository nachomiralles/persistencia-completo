using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoPJ : MonoBehaviour {


    void OnCollisionEnter(Collision collision)
    {
        print("Algo toca: " + collision);

    }
}
