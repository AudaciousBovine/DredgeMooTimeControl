using UnityEngine;
using Winch.Core;

namespace MooTimeControl
{
	public class MooTimeControl : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(MooTimeControl)} has loaded!");
		}
	}
}
