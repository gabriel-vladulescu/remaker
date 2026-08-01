Shader "Custom/FX/FireStepNoiseBase" {
	Properties {
		_FireSpeed ("Fire Speed", Range(0, 2)) = 0
		_BrightnessMultiplier ("Brightness Multiplier", Float) = 1
		_noise ("noise", 2D) = "white" {}
		_Noisemultiplier ("Noise multiplier", Range(0, 20)) = 20
		_NoiseScale ("Noise Scale", Range(0, 1)) = 1
		_Mask ("Mask", 2D) = "white" {}
		_BaseSize ("Base Size", Range(0, 3)) = 1
		_InnerStep ("Inner Step", Range(0, 3)) = 0
		_OuterColourBase ("Outer Colour Base", Vector) = (1,0.7655172,0,1)
		_InnerColourBase ("Inner Colour Base", Vector) = (1,0.7655172,0,1)
		_DistoritionPower ("Distorition Power", Range(1, 10)) = 1
		_InnerVerticalFalloff ("Inner Vertical Falloff", Range(1, 5)) = 1
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
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

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}