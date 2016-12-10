using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EpicCounter : MonoBehaviour {

	public static float EpicCount = 0;
	
	Text text;
	
	void OnDestroy(){
		PlayerPrefs.SetFloat ("EpicCount", EpicCount);
		PlayerPrefs.Save ();
		
	}
	
	void Start (){
		EpicCount = PlayerPrefs.GetFloat ("EpicCount", 0);
		
	}
	void Awake (){
		
		text = GetComponent <Text> ();
		EpicCount = 0;
	}
	void Update (){
		text.text = "" + EpicCount;
	}
	public void OnDeleteButtonClicked(){
		EpicCount = 0;
	}
}
