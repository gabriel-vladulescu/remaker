using System;
using UnityEngine;

namespace MaterialMotion
{
	[Serializable]
	public class MotionLayer
	{
		public int mMaterialID;

		public string mShaderProperty;

		public MotionPropertyType mMotionProperty;

		public AnimationCurve mAnimCurveX;

		public AnimationCurve mAnimCurveY;

		public TextureMotionType mTextureMotionType;

		public float mSpeed;

		public int mRows;

		public int mCollumns;

		public int mStartFrame;

		public int mEndFrame;

		public Gradient mGradient;

		public Vector2 EvaluateVector2(float pTime)
		{
			return default(Vector2);
		}

		public Color EvaluateColor(float pTime)
		{
			return default(Color);
		}

		public float EvaluateFloat(float pTime)
		{
			return 0f;
		}
	}
}
