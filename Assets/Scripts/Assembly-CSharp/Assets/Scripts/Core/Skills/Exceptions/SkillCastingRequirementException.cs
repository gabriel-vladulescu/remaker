using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Assets.Scripts.Core.Skills.Exceptions
{
	public class SkillCastingRequirementException : Exception
	{
		public SkillCastingRequirementException()
		{
		}

		public SkillCastingRequirementException(string message)
		{
		}

		public SkillCastingRequirementException(string message, Exception innerException)
		{
		}

		protected SkillCastingRequirementException([NotNull] SerializationInfo info, StreamingContext context)
		{
		}
	}
}
