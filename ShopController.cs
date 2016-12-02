using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour
{

	public Canvas shopCanvas;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			OpenShop ();
		}
	}

	void OpenShop ()
	{
		shopCanvas.enabled = true;
		Time.timeScale = 0;

	}

	public void CloseShop ()
	{
		shopCanvas.enabled = false;
		Time.timeScale = 1;

	}
	 
}
