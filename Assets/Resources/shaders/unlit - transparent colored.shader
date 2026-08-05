Shader "Unlit/Transparent Colored" {
Properties {
	_MainTex ("Base (RGB), Alpha (A)", 2D) = "white" {}
}

SubShader {
	Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
	LOD 100

	ZWrite Off
	Blend SrcAlpha OneMinusSrcAlpha

	Pass {
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		#pragma fragmentoption ARB_precision_hint_fastest
		#include "UnityCG.cginc"

		sampler2D _MainTex;

		struct appdata_t
		{
			float4 vertex : POSITION;
			fixed4 color : COLOR;
			float2 texcoord : TEXCOORD0;
		};

		struct v2f
		{
			float4 vertex : SV_POSITION;
			fixed4 color : COLOR;
			half2 texcoord : TEXCOORD0;
		};

		v2f vert (appdata_t v)
		{
			v2f o;
			o.vertex = UnityObjectToClipPos(v.vertex);
			o.color = v.color;
			o.texcoord = v.texcoord;
			return o;
		}

		fixed4 frag (v2f i) : SV_Target
		{
			fixed4 col = tex2D(_MainTex, i.texcoord) * i.color;
			return col;
		}
		ENDCG
	}
}
}
