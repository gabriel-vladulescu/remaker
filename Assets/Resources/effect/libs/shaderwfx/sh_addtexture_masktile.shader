Shader "Unlit/BraumR_Area" {
	Properties {
		_MainTexture ("MainTexture", 2D) = "white" {}
		_Glow ("Glow", Float) = 1.5
		_Depth ("Depth", Float) = 0.25
		_ColorMain ("ColorMain", Vector) = (1,1,1,1)
		_Mask ("Mask", 2D) = "white" {}
		_U_Offset ("U_Offset", Float) = 0
		_V_Offset ("V_Offset", Float) = 0
		_Mask2 ("Mask2", 2D) = "white" {}
		_U_Speed ("U_Speed", Float) = 0.25
		_V_Speed ("V_Speed", Float) = 1.5
		_Color_Mask ("Color_Mask", Vector) = (0.9058823,0.5735294,1,1)
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