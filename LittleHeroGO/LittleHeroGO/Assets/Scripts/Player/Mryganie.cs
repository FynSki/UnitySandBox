using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Mryganie : MonoBehaviour {

// ---------------------------------------------------
// ----------------- ZMIENNE -------------------------
// ---------------------------------------------------
	//mryganie
    public Renderer rysujbohatera;
    public int CzasMrygania;
    public float predkoscMrygania;
	//********* game object
	public string tagName;
	public Text countText;
	//*******Mryganie
	public int count;
// ----------------------------------------------------

// ----------------------------------------------------
// -------------- ON TRIGGER ENTER --------------------
// ----------------------------------------------------
void OnTriggerEnter2D(Collider2D other)
    {
		 if (other.gameObject.CompareTag(tagName))
        {
            StartCoroutine(Mrygaj());
            //count = count - 5;
            //SetCountText();
           
        }

	}
// ----------------------------------------------------

// --------------------------------------------------------
// --------------- SET COUNT TEXT FUNKCJA -----------------
// --------------------------------------------------------
 void SetCountText ()
    {
        countText.text = "Likes: " + count.ToString();
    }
// --------------------------------------------------------

// ----------------------------------------------------------------------
// -------------------------- MRUGAJ IENUMERATOR ------------------------
// ----------------------------------------------------------------------
IEnumerator Mrygaj()
    {
        for (int i = 0; i < CzasMrygania; i++)
        {
            rysujbohatera.enabled = false;
            yield return new WaitForSeconds(predkoscMrygania / 2);
            rysujbohatera.enabled = true;
            yield return new WaitForSeconds(predkoscMrygania / 2);
        }
    }
// ------------------------------------------------------------------------
}
