using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RareCounter : MonoBehaviour {

	public static float RareCount = 0;
	
	Text text;
	
	void OnDestroy(){
		PlayerPrefs.SetFloat ("RareCount", RareCount);
		PlayerPrefs.Save ();
		
	}
	
	void Start (){
		RareCount = PlayerPrefs.GetFloat ("RareCount", 0);
		
	}
	void Awake (){
		
		text = GetComponent <Text> ();
		RareCount = 0;
	}
	void Update (){
		text.text = "" + RareCount;
	}
	public void OnDeleteButtonClicked(){
		RareCount = 0;
	}
}
