using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;


namespace SceneManager
{
	public class IUserInterface : SceneManager
	{

		private GameObject loginScreen;

		private void Start()
		{
			OnStateChanged += ChangeState;
			loginScreen = Resources.Load<GameObject>("UI/Login");
		}

		private void ChangeState(State state)
		{
			switch (state)
			{
				case State.Login:
					ShowLoginView();
					break;
				case State.DataView:
					ShowDataView();
					break;
			}
		}

		[SerializeField]
		private void ShowDataView()
		{
			Debug.Log("Interface - Data");
		}


		[SerializeField]
		private void ShowLoginView()
		{
			if (loginScreen == null) { return; }
			Instantiate(loginScreen).SetActive(true);
			Debug.Log("Interface - Login");
		}

		private void OnDestroy()
		{
			OnStateChanged -= ChangeState;
		}

	}
}
