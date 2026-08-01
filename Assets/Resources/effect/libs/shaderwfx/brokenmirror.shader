Shader "Custom/BrokenMirror" {
	Properties {
		_ParallaxTexture ("ParallaxTexture", 2D) = "white" {}
		_MaskTexture ("MaskTexture", 2D) = "white" {}
		_U_Speed ("U_Speed", Float) = 0.4
		_V_Speed ("V_Speed", Float) = -0.4
		_Glow ("Glow", Float) = 1
		_Depth ("Depth", Float) = 0
		_DissolvePower ("DissolvePower", Float) = 2
		_FinalOpacity ("FinalOpacity", Float) = 1
		_Noise ("Noise", 2D) = "white" {}
		_SecondaryParallaxTexture ("SecondaryParallaxTexture", 2D) = "white" {}
		_U_Speed_2 ("U_Speed_2", Float) = -0.6
		_V_Speed_2 ("V_Speed_2", Float) = 0.2
		_SecondaryTextureIntensity ("SecondaryTextureIntensity", Float) = 0.2
		_VertexOffset_Strength ("VertexOffset_Strength", Float) = 0.002
		_GlobalSpeed ("GlobalSpeed", Float) = 1
		_Distortion_Strength ("Distortion_Strength", Float) = 0.2
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
	Fallback "Particles/Additive"
	//CustomEditor "ShaderForgeMaterialInspector"
}