using UnityEngine;

public class OrientationManager : MonoBehaviour
{
    // ������� �������� ���������� ��� �����
    public ScreenOrientation desiredOrientation;

    void Start()
    {
        // ���������� �������� ���������� ��� �����
        Screen.orientation = desiredOrientation;
    }
}
