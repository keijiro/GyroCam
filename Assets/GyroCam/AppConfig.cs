using UnityEngine;
using System.Collections;

public class AppConfig : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60;
        Input.gyro.enabled = true;
    }
}
