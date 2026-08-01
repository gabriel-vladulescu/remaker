Shader "Particles/Fire" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Noise ("Noise Texture", 2D) = "white" {}
		_Distort ("Second Noise Texture", 2D) = "white" {}
		_Scale ("Noise Scale", Range(0, 2)) = 0.5
		_DistortScale ("Distort Scale", Range(0, 2)) = 0.5
		_Tint ("Tint", Vector) = (1,1,0,0)
		_EdgeColor ("Edge", Vector) = (1,0.5,0,0)
		_Cutoff ("Cutoff Smoothness", Range(0, 1)) = 0.2
		_Speed ("Speed", Range(-10, 10)) = 2
		_Brightness ("Brightness", Range(0, 2)) = 0.6
		_Stretch ("Stretch", Range(0, 2)) = 1
		_EdgeWidth ("EdgeWidth", Range(-2, 2)) = 0.4
		_Particle ("Density", Range(-2, 2)) = 0
		[Toggle(MULTIPLY)] _MULTIPLY ("Multiply Noise?", Float) = 1
		[Enum(UnityEngine.Rendering.BlendOp)] _BlendOp ("Blend Op", Float) = 0
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

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}