using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LegendaryCounter : MonoBehaviour {

	public static float LegendaryCount = 0;
	
	Text text;
	
	void OnDestroy(){
		PlayerPrefs.SetFloat ("LegendaryCount", LegendaryCount);
		PlayerPrefs.Save ();
		
	}
	
	void Start (){
		LegendaryCount = PlayerPrefs.GetFloat ("LegendaryCount", 0);
		
	}
	void Awake (){
		
		text = GetComponent <Text> ();
		LegendaryCount = 0;
	}
	void Update (){
		text.text = "" + LegendaryCount;
	}
	public void OnDeleteButtonClicked(){
		LegendaryCount = 0;
	}
}
