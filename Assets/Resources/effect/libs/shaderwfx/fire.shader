Shader "Custom/Fire" {
	Properties {
		_Texture_1 ("Texture_1", 2D) = "white" {}
		_UV_Stretch_2 ("UV_Stretch_2", Float) = 0.7
		_UV_Stretch_3 ("UV_Stretch_3", Float) = 0.3
		_FireShape ("FireShape", 2D) = "white" {}
		_MultiplyCorrection ("MultiplyCorrection", Float) = 4
		_Color ("Color", Vector) = (0.6415823,0.1617647,1,1)
		_GlowValue ("GlowValue", Float) = 3
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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