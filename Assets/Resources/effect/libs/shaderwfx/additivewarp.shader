Shader "PM_Assets/AdditiveWarp" {
	Properties {
		_ColorOverlay ("Color Overlay", Vector) = (1,1,1,1)
		_GlowAmount ("Glow Amount", Float) = 1
		_MainTexture ("Main Texture", 2D) = "white" {}
		_USpeed ("U Speed", Float) = 0
		_VSpeed ("V Speed", Float) = 0
		_TextureContrast ("Texture Contrast", Float) = 1
		_Noise ("Noise", 2D) = "white" {}
		_NoisePower ("Noise Power", Float) = 1
		_NoiseContrast ("Noise Contrast", Float) = 1
		_USpeedNoise ("U Speed Noise", Float) = 0
		_VSpeed_Noise ("V Speed_Noise", Float) = 0
		_NoiseMulti ("Noise Multi", Float) = 1
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