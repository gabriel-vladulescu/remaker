Shader "kokichi/Mobile/Rim/Rim Mask (Multiple Light) Outline" {
	Properties {
		_basetexture ("Diffuse (RGB) RimMask (A)", 2D) = "white" {}
		_ambientscale ("Ambient Scale", Float) = 1
		_rimlightcolor ("Rim Light Color", Vector) = (1,1,1,1)
		_rimlightscale ("Rim Light Scale", Float) = 1
		_rimlightpower ("Rim Light Power", Float) = 0.2
		_Outline ("Outline Width", Range(0, 0.05)) = 0.005
		_OutlineColor ("Outline Color", Vector) = (0.2,0.2,0.2,1)
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
}