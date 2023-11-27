using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace SceneManager
{
	public class LoginLogic : SceneManager
	{
		private string username;
		private string password;

		private void Start()
		{
		}

		public void CheckLogin()
		{
			if(IsCorrectLogin())
			{
				state = State.DataView;
				UpdateState();
				Debug.Log("Update data view");
			}
		}

		private bool IsCorrectLogin()
		{
			username = GameObject.Find("usernamePlaceholder").GetComponent<TextMeshProUGUI>().text;
			password = GameObject.Find("passwordPlacholder").GetComponent<TextMeshProUGUI>().text;

			if (username == "admin" && password == "password")
			{
				Debug.Log("Correct");
				return true;
				
			}
			Debug.Log("False");
			Debug.Log(username + " " + password);
			return false;
		}
}

}
