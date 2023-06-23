using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_in_Game : MonoBehaviour
{
    public void BackGame()
    {
        SceneManager.LoadScene(1);
    }
}
