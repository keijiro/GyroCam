using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ShadowCaster : MonoBehaviour
{
    public Shader shader;

    void Awake()
    {
        GetComponent<Camera>().SetReplacementShader(shader, null);
    }
}
