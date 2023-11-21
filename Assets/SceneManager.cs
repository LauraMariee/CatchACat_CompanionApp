using UnityEngine;
using UnityEngine.Events;


namespace SceneManager
{
	public class SceneManager : MonoBehaviour
	{
		public enum State
		{
			Login,
			DataView
		};

		readonly State state = State.DataView;

		public delegate void StateChange(State target);
		public static event StateChange OnStateChanged;

		private void Start()
		{
			OnStateChanged.Invoke(State.Login);
			//LocalizationSettings.SelectedLocale = UserLocale; //API CALL
		}

	}
}
