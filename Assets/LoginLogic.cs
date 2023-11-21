using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginLogic : MonoBehaviour
{
	[SerializeField, HideInInspector]
	private string username;
	[SerializeField, HideInInspector]
	private string password;

	private void Start()
	{
		//username = GameObject.Find("Username/TextArea/Placeholder");
	}

	// Update is called once per frame
	public void CheckLogin()
	{
		Debug.Log("LoginLogic - CheckLogin");
		IsCorrectLogin();
	}

	private bool IsCorrectLogin()
	{
		if (username.Equals(true) && password.Equals(true))
		{
			return true;
		}
		return false;
	}
}
