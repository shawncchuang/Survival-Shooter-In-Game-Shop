using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.ComponentModel;

namespace CompleteProject
{
	public class WeaponButton : MonoBehaviour
	{

		public PlayerShooting playerShooting;
		public int weaponNumber;

		public Text name;
		public Text cost;
		public Text desription;

		private AudioSource source;

		// Use this for initialization
		void Start ()
		{
			//source.GetComponent<AudioSource> ();
			SetButton ();
		}

		void SetButton ()
		{
			string costString = playerShooting.weapons [weaponNumber].cost.ToString ();
			name.text = playerShooting.weapons [weaponNumber].weaponName;
			cost.text = "$" + playerShooting.weapons [weaponNumber].cost;
			desription.text = playerShooting.weapons [weaponNumber].description;
		}

		public void onClick ()
		{
			if (ScoreManager.score >= playerShooting.weapons [weaponNumber].cost) {
				ScoreManager.score -= playerShooting.weapons [weaponNumber].cost;
				playerShooting.currentWeapon = weaponNumber;
			} else {

//				source.Play ();

			}
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	}

}



