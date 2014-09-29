using UnityEngine;
using System.Collections;

public class CameraPivot : MonoBehaviour
{
    void Update()
    {
        Quaternion q1 = Input.gyro.attitude;
        Quaternion q2 = new Quaternion(q1.y, -q1.z, -q1.x, q1.w);
        transform.localRotation = q2;
    }
}
