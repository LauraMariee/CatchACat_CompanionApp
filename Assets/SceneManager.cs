using System.Collections;
using UnityEngine;


namespace SceneManager
{
	public class SceneManager : MonoBehaviour
	{
		public enum State
		{
			Login,
			DataView
		};

		public static State state;

		public delegate void StateChange(State target);
		public static event StateChange OnStateChanged;

		private void Start()
		{
			OnStateChanged.Invoke(State.Login);
			//LocalizationSettings.SelectedLocale = UserLocale; //API CALL
		}

		public void UpdateState()
		{
			OnStateChanged.Invoke(state);
		}

	}
}
