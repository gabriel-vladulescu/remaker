Shader "Sh_Lush_Master_Particles" {
	Properties {
		_MainTexture ("Main Texture", 2D) = "white" {}
		[Toggle] _MainTextureRGBA ("Main Texture RGBA", Float) = 0
		[HDR] _MainTextureTint ("Main Texture Tint", Vector) = (1,1,1,0)
		[Toggle] _MainTextureTintBackFaces ("Main Texture Tint Back Faces", Float) = 0
		[HDR] _MainTextureBackTint ("Main Texture Back Tint", Vector) = (0.5,0.5,0.5,0)
		[Header(Opacity Mask)] [Space(13)] _OpacityMask ("Opacity Mask", 2D) = "white" {}
		[Header(Alpha Erosion)] [Space(13)] _AlphaErosionTexture ("Alpha Erosion Texture", 2D) = "white" {}
		_AlphaErosionSmoothstepMax ("Alpha Erosion Smoothstep Max", Float) = 0.1
		[Toggle(_ALPHAEROSIONSMOOTHSTEPFLATNESS_ON)] _AlphaErosionSmoothstepFlatness ("Alpha Erosion Smoothstep Flatness", Float) = 0
		_AlphaErosionSmoothstepFlatnessValue ("Alpha Erosion Smoothstep Flatness Value", Float) = 0.1
		[Header(Soft Particles)] [Space(13)] _SoftParticles ("Soft Particles", Float) = 0
		[Header(AR)] [Space(13)] _CullMode ("Cull Mode", Float) = 2
		_BlendSrc ("Blend Src", Float) = 5
		_BlendDst ("Blend Dst", Float) = 10
		_ZWrite ("ZWrite", Float) = 2
		_ZTest ("ZTest", Float) = 2
		[HideInInspector] _tex4coord2 ("", 2D) = "white" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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
	//CustomEditor "ASEMaterialInspector"
}