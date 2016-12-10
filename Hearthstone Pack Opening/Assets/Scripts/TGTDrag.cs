using UnityEngine;
using System.Collections;

public class TGTDrag : MonoBehaviour {

	private Vector2 screenPoint;
	private Vector2 offset;
	public bool OnPackField = false;
	public GameObject TGTPackPrefab;
	public GameObject PackClone;
	public bool PackOnField = false;
	
	
	void OnMouseDown() {
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, Input.mousePosition.y));
		
	}
	
	void OnMouseDrag()
	{
		if (PackOnField == false) {
			Vector2 curScreenPoint = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint);
			transform.position = curPosition;
		}
	}
	void OnMouseUp (){
		transform.position = new Vector2 (0, -4.5f);
		if (OnPackField == true) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			PackOnField = true;
			PackClone =(GameObject) Instantiate(TGTPackPrefab,new Vector3(0,-0.35f,0),Quaternion.identity);
			PackClone.tag = "PackClone";
		}
	}
	
	public void PackRemoved(){
		PackOnField = false;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "PackField") {
			OnPackField = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "PackField") {
			OnPackField = false;
		}
	}
}
