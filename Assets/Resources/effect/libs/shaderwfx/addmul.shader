Shader "Custom/AddMul" {
	Properties {
		_MainTexture ("MainTexture", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		_EmissiveIntensity ("EmissiveIntensity", Float) = 4
		_OpacityIntensity ("OpacityIntensity", Float) = 4
		[MaterialToggle] _HasNoiseEmissive ("HasNoiseEmissive?", Float) = 0
		_Noise ("Noise", 2D) = "white" {}
		_U_Speed ("U_Speed", Float) = 0.1
		_V_Speed ("V_Speed", Float) = 0.15
		_NoisePower ("NoisePower", Float) = 3
		[MaterialToggle] _HasNoiseOpacity ("HasNoiseOpacity?", Float) = 0
		_Depth ("Depth", Float) = 0.2
		[MaterialToggle] _HasOpacityDepth ("HasOpacityDepth?", Float) = 0
		[MaterialToggle] _HasEmissiveDepth ("HasEmissiveDepth?", Float) = 0
		_FinalOpacity ("FinalOpacity", Float) = 1
		_FinalEmissive ("FinalEmissive", Float) = 1
		_FinalMix ("FinalMix", Float) = 1
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Particles/Additive"
}