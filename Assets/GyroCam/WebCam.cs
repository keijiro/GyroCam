using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour
{
    WebCamTexture webCam;
    Renderer renderComponent;

    IEnumerator Start()
    {
        renderComponent = GetComponent<Renderer>();
        webCam = new WebCamTexture(Screen.width, Screen.height);

        webCam.Play();

        while (!webCam.didUpdateThisFrame) yield return null;

        renderComponent.material.mainTexture = webCam;

        transform.localRotation = Quaternion.AngleAxis(webCam.videoRotationAngle, -Vector3.forward);

        Debug.Log("WebCamTexture: " + webCam.width + ", " + webCam.height);

        var sy = 2.0f * Screen.width / Screen.height;
        var sx = sy * webCam.width / webCam.height;
        transform.localScale = new Vector3(sx, sy, 1);
    }
}
