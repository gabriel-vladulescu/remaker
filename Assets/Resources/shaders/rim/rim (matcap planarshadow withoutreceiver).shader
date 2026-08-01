Shader "kokichi/Mobile/Rim/MatCap/Textured PlanarShadow WithoutReceiver" {
	Properties {
		_basetexture ("Base (RGB) Cutoff(A)", 2D) = "white" {}
		_color ("Main Color", Vector) = (1,1,1,1)
		_matcap ("MatCap (RGB)", 2D) = "white" {}
		_rimTex ("Rim Tex (RGB)", 2D) = "black" {}
		_ambientscale ("Ambient Scale", Float) = 1
		_diffusescale ("Diffuse Scale", Float) = 1
		_mulscale ("Multiple Scale", Float) = 0.8
		_addscale ("Add Scale", Float) = 0.8
		_rimlightcolor ("Rim Light Color", Vector) = (1,1,1,1)
		_rimlightscale ("Rim Light Scale", Float) = 1
		_flashColor ("Flash Color", Vector) = (1,1,1,1)
		_flashValue ("Flash value", Range(0, 1)) = 0
		_Shininess ("Shininess", Range(0.03, 1)) = 0.15
		_Shininess ("Shininess", Float) = 0.15
		_LuminateVector ("Luminate (XYZ) Bias (W)", Vector) = (0.3,0.58,0.12,0.35)
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
}