Shader "Custom/DarkMatterShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (0, 0, 0, 1) // Color de la materia oscura
        _SpecularColor ("Specular Color", Color) = (1, 1, 1, 1) // Color especular
        _SpecularPower ("Specular Power", Range(0.1, 100)) = 10.0 // Intensidad especular
        _GlowColor ("Glow Color", Color) = (0, 0, 0, 1) // Color del brillo
        _GlowPower ("Glow Power", Range(0.1, 10)) = 1.0 // Intensidad del brillo
    }
 
    SubShader
    {
        Tags { "RenderType"="Opaque" }
 
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite On
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
                float3 viewDir : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            float4 _Color;
            float4 _SpecularColor;
            float _SpecularPower;
            float4 _GlowColor;
            float _GlowPower;
 
            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.viewDir = normalize(UnityWorldSpaceViewDir(v.vertex));
                return o;
            }
 
            half4 frag(v2f i) : SV_Target
            {
                half4 baseColor = _Color * tex2D(_MainTex, i.uv);
                half specular = pow(saturate(dot(i.viewDir, half3(0, 0, 1))), _SpecularPower);
                half4 specularColor = _SpecularColor * specular;
                half4 glow = _GlowColor * _GlowPower;
                return baseColor + specularColor + glow;
            }
            ENDCG
        }
    }
}
