Shader "kokichi/Debug/MipMapLvlColorCoded" {
	Properties {
		_MainTex ("Diffuse Texture", 2D) = "white" {}
		_ShowTexture ("Show Texture", Range(0, 1)) = 1
		_MipMapLvl_00 ("MipMapLvl 00", Vector) = (1,0,0,1)
		_MipMapLvl_01 ("MipMapLvl 01", Vector) = (0,1,0,1)
		_MipMapLvl_02 ("MipMapLvl 02", Vector) = (0,0,1,1)
		_MipMapLvl_03 ("MipMapLvl 03", Vector) = (1,0,0.72,1)
		_MipMapLvl_04 ("MipMapLvl 04", Vector) = (1,1,0,1)
		_MipMapLvl_05 ("MipMapLvl 05", Vector) = (1,0.64,0,1)
		_MipMapLvl_06 ("MipMapLvl 06", Vector) = (0,0.75,1,1)
		_MipMapLvl_07 ("MipMapLvl 07", Vector) = (0.5,0.5,0.5,1)
		_MipMapLvl_08 ("MipMapLvl 08", Vector) = (0.75,0,0.75,1)
		_MipMapLvl_09 ("MipMapLvl 09", Vector) = (0.35,0.45,0.85,1)
		_MipMapLvl_10 ("MipMapLvl 10", Vector) = (0.8,0.2,1,1)
		_MipMapLvl_11 ("MipMapLvl 11", Vector) = (0,0,0,1)
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
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}