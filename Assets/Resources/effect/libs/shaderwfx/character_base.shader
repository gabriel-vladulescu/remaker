Shader "Custom/Character_Base" {
	Properties {
		_MainTexture ("MainTexture", 2D) = "white" {}
		_EmissivePower ("EmissivePower", Float) = 0.2
		_HitColor ("HitColor", Vector) = (1,1,1,1)
		_HitPower ("HitPower", Float) = 0
		_DiffusePower ("DiffusePower", Float) = 2
		[MaterialToggle] _HasEmissiveTexture ("HasEmissiveTexture?", Float) = 0
		_EmissiveTexture ("EmissiveTexture", 2D) = "white" {}
		_EmissiveTextureValue ("EmissiveTextureValue", Float) = 0.5
		_Noise ("Noise", 2D) = "white" {}
		_U_Speed ("U_Speed", Float) = 0.1
		_V_Speed ("V_Speed", Float) = 0.15
		[MaterialToggle] _HasNoise ("HasNoise?", Float) = 0
		_Color ("Color", Vector) = (1,1,1,1)
		_SpecValue ("SpecValue", Float) = 0
		[MaterialToggle] _HasSpecMap ("HasSpecMap?", Float) = 0
		_SpecularMap ("SpecularMap", 2D) = "black" {}
		_SpecMapPower ("SpecMapPower", Float) = 3
		_Gloss ("Gloss", Float) = 1
		_OutlineWidth ("OutlineWidth", Float) = 0.01
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
	Fallback "Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}