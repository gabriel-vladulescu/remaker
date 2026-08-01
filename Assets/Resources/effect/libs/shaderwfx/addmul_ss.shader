Shader "Custom/AddMul_SS" {
	Properties {
		_MainTexture ("MainTexture", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		_EmissiveIntensity ("EmissiveIntensity", Float) = 4
		_OpacityIntensity ("OpacityIntensity", Float) = 4
		[MaterialToggle] _HasNoiseEmissive ("HasNoiseEmissive?", Float) = 0
		_Noise ("Noise", 2D) = "white" {}
		_U_Speed ("U_Speed", Float) = 0.1
		_V_Speed ("V_Speed", Float) = 0.15
		_NoisePower ("NoisePower", Float) = 3
		[MaterialToggle] _HasNoiseOpacity ("HasNoiseOpacity?", Float) = 0
		_Depth ("Depth", Float) = 0.2
		[MaterialToggle] _HasOpacityDepth ("HasOpacityDepth?", Float) = 0
		[MaterialToggle] _HasEmissiveDepth ("HasEmissiveDepth?", Float) = 0
		_FresnelExp ("FresnelExp", Float) = 0.5
		[MaterialToggle] _HasOpacityFresnel ("HasOpacityFresnel?", Float) = 0
		[MaterialToggle] _HasEmissiveFresnel ("HasEmissiveFresnel?", Float) = 0
		_FresnelPower ("FresnelPower", Float) = 1.2
		_FinalOpacity ("FinalOpacity", Float) = 1
		[MaterialToggle] _Is_ScreenSpace ("Is_ScreenSpace?", Float) = 0
		[MaterialToggle] _HasColorGradient ("HasColorGradient?", Float) = 0
		_ColorGradient ("ColorGradient", 2D) = "white" {}
		[MaterialToggle] _HasColorGradientMask ("HasColorGradientMask?", Float) = 0
		_ColorGradientMask ("ColorGradientMask", 2D) = "white" {}
		_ColorMaskIntensity ("ColorMaskIntensity", Float) = 1
		[MaterialToggle] _IsFirstPanUV1 ("IsFirstPanUV1", Float) = 0
		_U_Speed_2 ("U_Speed_2", Float) = 0.1
		_V_Speed_2 ("V_Speed_2", Float) = 0.15
		_SecondaryNoise ("SecondaryNoise", 2D) = "white" {}
		[MaterialToggle] _HasSecondaryNoise ("HasSecondaryNoise", Float) = 0
		_SecondaryNoisePower ("SecondaryNoisePower", Float) = 1
		_IntersectionDepth ("IntersectionDepth", Float) = 0.25
		[MaterialToggle] _HasIntersectionDepth ("HasIntersectionDepth", Float) = 0
		_IntersectionColor ("IntersectionColor", Vector) = (1,1,1,1)
		_IntersectionStrength ("IntersectionStrength", Float) = 1
		_IntersectionTexture ("IntersectionTexture", 2D) = "white" {}
		[MaterialToggle] _HasDistortion ("HasDistortion?", Float) = 0
		[MaterialToggle] _SameDistortionAsOpacity ("SameDistortionAsOpacity?", Float) = 0
		_DistortionTexture ("DistortionTexture", 2D) = "white" {}
		_DistortionStrength ("DistortionStrength", Float) = 0.1
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
	Fallback "Particles/Additive"
	//CustomEditor "ShaderForgeMaterialInspector"
}