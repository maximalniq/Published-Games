using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	private GameObject[] Cards;
	private int i;
	public TGTDrag _TGTDrag;
	public ButtSound _ButtonSound;
	

	void OnMouseDown (){
		Cards = GameObject.FindGameObjectsWithTag ("ClassicCardClone");
		DestroyCards ();
		gameObject.SetActive (false);
		_TGTDrag.PackRemoved ();
		_ButtonSound.PlayButtonSound ();
	

	}
	public void ShowButton(){
		gameObject.SetActive (true);
	}
	void DestroyCards(){
		for (i=0;i<Cards.Length;i++)
			Destroy(Cards[i]);
	}
}
