using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

// ----------------------------------
// ---------- ZMIENNE ---------------
// ----------------------------------
	public string linkDir;
// ----------------------------------

// -----------------------------------
// ----- LINEaCTIVATOR FUNCTION ------
// -----------------------------------
public void Linkactivator()
{
	Application.OpenURL(linkDir);
}
// -----------------------------------
}
