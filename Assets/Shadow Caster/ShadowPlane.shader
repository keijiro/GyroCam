Shader "Custom/Shadow Plane"
{
    Properties
    {
        _MainTex("Base", 2D) = "white" {}
        _ShadowColor("Shadow Color", Color) = (0, 0, 0, 1)
    }

CGINCLUDE

#include "UnityCG.cginc"

sampler2D _MainTex;
half4 _MainTex_ST;
fixed4 _ShadowColor;

struct v2f
{
    float4 pos : SV_POSITION;
    half2 uv : TEXCOORD0;
};

v2f vert(appdata_base v)
{
    v2f o;
    o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
    o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
    return o;
}

fixed4 frag(v2f i) : COLOR
{
    fixed4 c = _ShadowColor;
    c.a *= tex2D(_MainTex, i.uv).a;
    return c;
}

ENDCG

    SubShader
    {
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            ENDCG
        }
    }
}
