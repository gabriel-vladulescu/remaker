Shader "kokichi/Mobile/Rim/MatCap/Textured Additive 2Passes Emission-Noise" {
	Properties {
		_basetexture ("Base (RGB)", 2D) = "white" {}
		_color ("Main Color", Vector) = (1,1,1,1)
		_emissionTexture ("Emission (RGB)", 2D) = "black" {}
		_emissionColor ("Emission Color", Vector) = (1,1,1,1)
		_emissionScale ("Emission Scale", Float) = 1
		_noiseTexture ("Noise (RGB)", 2D) = "black" {}
		_uvSpeed ("UV Scrolling Speed", Vector) = (0,0,0,0)
		_matcap ("MatCap (RGB)", 2D) = "white" {}
		_rimTex ("Rim Tex (RGB)", 2D) = "black" {}
		_ambientscale ("Ambient Scale", Float) = 1
		_diffusescale ("Diffuse Scale", Float) = 1
		_mulscale ("Multiple Scale", Float) = 0.8
		_addscale ("Add Scale", Float) = 0.8
		_rimlightcolor ("Rim Light Color", Vector) = (1,1,1,1)
		_rimlightscale ("Rim Light Scale", Float) = 1
		_alpha ("Alpha Scale", Float) = 1
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