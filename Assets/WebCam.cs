using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour
{
    WebCamTexture webCam;

    IEnumerator Start()
    {
        webCam = new WebCamTexture(Screen.width, Screen.height);

        webCam.Play();

        while (!webCam.didUpdateThisFrame) yield return null;

        renderer.material.mainTexture = webCam;

        transform.localRotation = Quaternion.AngleAxis(webCam.videoRotationAngle, -Vector3.forward);

        Debug.Log("WebCamTexture Size: " + webCam.width + ", " + webCam.height);
    }
}
