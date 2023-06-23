using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void PlanetComparsion()
    {
        SceneManager.LoadScene(16);
    }

}
