using System.Collections.Generic;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	public class Pool : MonoBehaviour
	{
		public GameObject thing;

		private List<GameObject> things;

		public GameObject nextThing
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
