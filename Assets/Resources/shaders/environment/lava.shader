Shader "kokichi/Environment/Lava" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB) ", 2D) = "white" {}
		offsetX ("offset X", Range(0, 1)) = 1
		offsetY ("offset Y", Range(0, 1)) = 1
		offsetVectorXY ("offset Vector XY", Vector) = (0,0,0,0)
		SineSpeed ("SineSpeed", Range(0, 1)) = 0.169
		deformSinVert ("deformSinVert", Vector) = (0,0,0,0)
		WaveSinSpeed ("WaveSinSpeed", Range(0, 2)) = 1
		LavaSinWaveFactor ("LavaSinWaveFactor", Range(0, 10)) = 1
		_Bias ("Bias", Float) = 0
		_TimeOnDuration ("ON duration", Float) = 0.5
		_BlinkingTimeOffsScale ("Blinking time offset scale (seconds)", Float) = 5
		_NoiseAmount ("Noise amount (when zero, pulse wave is used)", Range(0, 0.5)) = 0
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
	Fallback "Transparent/VertexLit"
}