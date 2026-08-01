Shader "1UP/Magic Outline/Unlit" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGBA)", 2D) = "white" {}
		_MulColor ("Intensity", Range(0, 5)) = 1
		_Ramp ("Toon Ramp (RGB)", 2D) = "gray" {}
		[Header(Outline Properties)] [Space(10)] _Color2 ("Outline Color", Vector) = (1,0.56,0,1)
		_ColorR ("Extra Outline Color", Vector) = (0.95,1,0,1)
		_Brightness ("Extra Outline Brightness", Range(0.5, 3)) = 2
		_Edge ("Extra Outline Edge", Range(0, 1)) = 0.1
		_RimPower ("Extra Outline Power", Range(0.01, 10)) = 3
		_Outline ("Outline width", Range(0.002, 5)) = 0.128
		_OutlineZ ("Outline Z", Range(-0.16, 1)) = 0.06
		[Header(Noise Properties)] [Space(10)] _Offset ("Noise Opacity", Range(0.01, 10)) = 10
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_Scale ("Noise Scale", Range(0, 0.2)) = 0.003
		_SpeedX ("Speed X", Range(-10, 10)) = 10
		_SpeedY ("Speed Y", Range(-10, 10)) = 10
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}