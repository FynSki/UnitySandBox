using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivTimeUI : MonoBehaviour {
// =======================================
// ========= VARIABLES ===================
// =======================================
	public GameObject pointTxt;
	public float timeToActive;

	public string tagName;

	public Text textToActivate;
	public string bonusText;
// =======================================

// =======================================
// ========= START =======================
// =======================================
	void Start () {
		textToActivate.text = bonusText;
	}
// =======================================	



// ===================================
// ========== VARIABLE ===============
// ===================================
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag(tagName))
				{
					StartCoroutine(UiActivator());
				}
	}
// ===================================


// =======================================
// ========= IE NUMERATOR ================
// =======================================
	IEnumerator UiActivator()
    {
           	pointTxt.SetActive(true);
            yield return new WaitForSeconds(timeToActive);
            pointTxt.SetActive(false);
    }
// ======================================

// ==== END SCRIPT
}
