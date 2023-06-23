using UnityEngine;

public class OrientationManager : MonoBehaviour
{
    // Задайте желаемую ориентацию для сцены
    public ScreenOrientation desiredOrientation;

    void Start()
    {
        // Установите желаемую ориентацию для сцены
        Screen.orientation = desiredOrientation;
    }
}
