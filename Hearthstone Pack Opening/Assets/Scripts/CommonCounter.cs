using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CommonCounter : MonoBehaviour {

	public static float CommonCount = 0;
	
	Text text;
	
	void OnDestroy(){
		PlayerPrefs.SetFloat ("CommonCount", CommonCount);
		PlayerPrefs.Save ();
		
	}
	
	void Start (){
		CommonCount = PlayerPrefs.GetFloat ("CommonCount", 0);
		
	}
	void Awake (){
		
		text = GetComponent <Text> ();
		CommonCount = 0;
	}
	void Update (){
		text.text = "" + CommonCount;
	}
	public void OnDeleteButtonClicked(){
		CommonCount = 0;
	}
}
