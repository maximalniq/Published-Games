using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PackCounter : MonoBehaviour {

	public static float PackCount = 0;

	Text text;

	void OnDestroy(){
		PlayerPrefs.SetFloat ("PackCount", PackCount);
		PlayerPrefs.Save ();
		
		}

	void Start (){
		PackCount = PlayerPrefs.GetFloat ("PackCount", 0);
		
	}
	void Awake (){
		
		text = GetComponent <Text> ();
		PackCount = 0;
	}
	void Update (){
		text.text = "" + PackCount;
	}
	public void OnDeleteButtonClicked(){
		PackCount = 0;
	}
}
