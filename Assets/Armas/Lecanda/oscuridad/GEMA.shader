Shader "Custom/PurpleGemShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (0.5, 0, 0.5, 1) // Color base de la gema
        _Shininess ("Shininess", Range(0.1, 1)) = 0.5 // Brillo de la gema
        _GlowColor ("Glow Color", Color) = (1, 0, 1, 1) // Color del brillo
        _GlowPower ("Glow Power", Range(0.1, 10)) = 1.0 // Intensidad del brillo
    }
 
    SubShader
    {
        Tags
        {
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
 
        Pass
        {
            Blend SrcAlpha One
            ZWrite Off
            Cull Off
            Fog { Mode Off }
 
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            float4 _Color;
            float _Shininess;
            float4 _GlowColor;
            float _GlowPower;
 
            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            half4 frag(v2f i) : SV_Target
            {
                half4 baseColor = _Color * tex2D(_MainTex, i.uv);
                half4 glow = _GlowColor * _GlowPower;
                half specular = pow(saturate(dot(normalize(_WorldSpaceCameraPos - i.vertex), normalize(i.vertex))), _Shininess);
                return baseColor + glow + specular;
            }
            ENDCG
        }
    }
}
