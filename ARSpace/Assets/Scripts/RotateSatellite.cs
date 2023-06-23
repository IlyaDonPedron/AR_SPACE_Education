using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSatellite : MonoBehaviour
{

    public GameObject satellite;
    public void OnMouseDown()
    {
        satellite.transform.Rotate(0, -15, 0);
    }

}
