Shader "MADFINGER/Transparent/Blinking GodRays" {
	Properties {
		_MainTex ("Base texture", 2D) = "white" {}
		_FadeOutDistNear ("Near fadeout dist", Float) = 10
		_FadeOutDistFar ("Far fadeout dist", Float) = 10000
		_Multiplier ("Color multiplier", Float) = 1
		_Bias ("Bias", Float) = 0
		_TimeOnDuration ("ON duration", Float) = 0.5
		_TimeOffDuration ("OFF duration", Float) = 0.5
		_BlinkingTimeOffsScale ("Blinking time offset scale (seconds)", Float) = 5
		_SizeGrowStartDist ("Size grow start dist", Float) = 5
		_SizeGrowEndDist ("Size grow end dist", Float) = 50
		_MaxGrowSize ("Max grow size", Float) = 2.5
		_NoiseAmount ("Noise amount (when zero, pulse wave is used)", Range(0, 0.5)) = 0
		_Color ("Color", Vector) = (1,1,1,1)
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
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}