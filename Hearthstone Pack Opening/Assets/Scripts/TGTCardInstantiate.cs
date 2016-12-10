using UnityEngine;
using System.Collections;

public class TGTCardInstantiate : MonoBehaviour {

	public GameObject ClassicCardPrefab;
	private GameObject ClassicCardClone1;
	private GameObject ClassicCardClone2;
	private GameObject ClassicCardClone3;
	private GameObject ClassicCardClone4;
	private GameObject ClassicCardClone5;
	public SoundPack _SoundPack;

	
	
	void OnMouseDown (){ 

		Destroy (this.gameObject);
		ClassicCardClone1 = (GameObject)Instantiate (ClassicCardPrefab, new Vector2 (0,1.1f),Quaternion.identity);
		ClassicCardClone2 = (GameObject)Instantiate (ClassicCardPrefab, new Vector2 (1.8f,0.6f),Quaternion.identity);
		ClassicCardClone3 = (GameObject)Instantiate (ClassicCardPrefab, new Vector2 (-1.8f,0.6f),Quaternion.identity);
		ClassicCardClone4 = (GameObject)Instantiate (ClassicCardPrefab, new Vector2 (-1,-1.85f),Quaternion.identity);
		ClassicCardClone5 = (GameObject)Instantiate (ClassicCardPrefab, new Vector2 (1,-1.85f),Quaternion.identity);
		ClassicCardClone1.tag = "ClassicCardClone";
		ClassicCardClone2.tag = "ClassicCardClone";
		ClassicCardClone3.tag = "ClassicCardClone";
		ClassicCardClone4.tag = "ClassicCardClone";
		ClassicCardClone5.tag = "ClassicCardClone";
		PackCounter.PackCount += 1f;
//		Debug.Log (PackCounter.PackCount);
		_SoundPack.OnClassicPackClicked ();
		
	}
}
