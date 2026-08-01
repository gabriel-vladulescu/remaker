Shader "Shader Forge/fx_wing_a" {
	Properties {
		_wing ("wing", 2D) = "white" {}
		_wing_color ("wing_color", Vector) = (1,1,1,1)
		_wing_uv ("wing_uv", Float) = 1
		_wing_intensity ("wing_intensity", Float) = 1
		_wing_speed ("wing_speed", Float) = 1
		_dust ("dust", 2D) = "white" {}
		_dust_color ("dust_color", Vector) = (1,0.25,0.25,1)
		_dust_UV ("dust_UV", Float) = 2
		_dust_intensity ("dust_intensity", Float) = 5
		_dust_speed ("dust_speed", Float) = 1
		_mask ("mask", 2D) = "white" {}
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