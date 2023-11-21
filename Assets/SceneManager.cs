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

		[SerializeField]
		State state = State.Login;

		public delegate void StateChange(State target);
		public static event StateChange OnStateChanged;

		private void Start()
		{
			OnStateChanged.Invoke(state);
			//LocalizationSettings.SelectedLocale = UserLocale; //API CALL
		}

	}
}
