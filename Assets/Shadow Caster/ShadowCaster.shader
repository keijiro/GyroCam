Shader "Custom/Shadow Caster"
{
    Properties
    {
    }

CGINCLUDE

#include "UnityCG.cginc"

struct v2f
{
    float4 pos : SV_POSITION;
};

v2f vert(appdata_base v)
{
    v2f o;
    o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
    return o;
}

half4 frag (v2f i) : COLOR
{
    return fixed4(1, 1, 1, 1);
}

ENDCG

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            ENDCG
        }
    }
}
