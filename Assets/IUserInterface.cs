using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;


namespace SceneManager
{
	public class IUserInterface : SceneManager
	{

		private State previous;

		private void Start()
		{
			OnStateChanged += ChangeState;
		}

		private void ChangeState(State state)
		{
			if (previous == state) { return; }
			switch (state)
			{
				case State.Login:
					ShowLoginView();
					break;
				case State.DataView:
					ShowDataView();
					break;
			}
			previous = state;
		}

		[SerializeField]
		private void ShowDataView()
		{
			Debug.Log("Interface - Data");
		}

		private void ShowLoginView()
		{
			if (Application.isPlaying)
			{

			}
			Debug.Log("Interface - Login");
		}

		private void OnDestroy()
		{
			OnStateChanged -= ChangeState;
		}

	}
}
