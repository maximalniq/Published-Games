using UnityEngine;
using System.Collections;

public class TGTCardBehaviour : MonoBehaviour {

	
	public Animator anim;
	private Sprite[] TGTCommon;
	private Sprite[] TGTRare;
	private Sprite[] TGTEpic;
	private Sprite[] TGTLegendary;
	private Sprite spritecard;
	private int RandomNumber;
	public ButtonScript _ButtonScript;
	public static int i;
	private int j = 0;
	AudioSource normalCardAudio;
	AudioSource epicCardAudio;
	AudioSource rareCardAudio;
	AudioSource legendaryCardAudio;
	AudioSource rareOMGAudio;
	AudioSource epicOMGCardAudio;
	AudioSource legendaryOMGCardAudio;
	public AdmobManager _AdmobManager;
	public static int k = 0;

	void Start (){
		AudioSource[] audios = GetComponents<AudioSource>();
		normalCardAudio = audios [0];
		epicCardAudio = audios [1];
		rareCardAudio = audios [2];
		legendaryCardAudio = audios [3];
		rareOMGAudio = audios [4];
		epicOMGCardAudio = audios [5];
		legendaryOMGCardAudio = audios [6];
		anim = GetComponent<Animator> ();
		TGTCommon = Resources.LoadAll<Sprite> ("TGTCommon");
		TGTRare = Resources.LoadAll<Sprite> ("TGTRare");
		TGTEpic = Resources.LoadAll<Sprite> ("TGTEpic");
		TGTLegendary = Resources.LoadAll<Sprite> ("TGTLegendary");

	}
	void OnMouseDown(){
		if (j == 0) {
			if(k==25){
				k=0;
				_AdmobManager.ShowInterstitial();
			}
			if(k==1){
				_AdmobManager.UpdateInterstitial();
			}
			//Debug.Log ("bachka");
			j++;
			i++;
			k++;
			Debug.Log (k);
			if (i == 5 || i > 5) {
				_ButtonScript.ShowButton ();
				i = 0;
			}
			PlayCardBackAnim ();
			RandomNumber = Random.Range (0, 101);
			StartCoroutine ("ChangeSprite");
			if (RandomNumber < 75) {
				normalCardAudio.Play();
				CommonCounter.CommonCount += 1f;
				spritecard = TGTCommon [Random.Range (0, TGTCommon.Length)];
			}
			if (RandomNumber >=75 && RandomNumber < 95) {
				rareCardAudio.Play ();
				rareOMGAudio.Play ();
				RareCounter.RareCount += 1f;
				spritecard = TGTRare [Random.Range (0, TGTRare.Length)];
			}
			if (RandomNumber >=95 && RandomNumber < 99) {
				epicCardAudio.Play ();
				epicOMGCardAudio.Play ();
				EpicCounter.EpicCount += 1f;
				spritecard = TGTEpic [Random.Range (0, TGTEpic.Length)];
			}
			if (RandomNumber >=99 && RandomNumber <= 100) {
				legendaryCardAudio.Play ();
				legendaryOMGCardAudio.Play ();
				LegendaryCounter.LegendaryCount +=1f;
				spritecard = TGTLegendary [Random.Range (0, TGTLegendary.Length)];
			}
			//Debug.Log (RandomNumber);
		}
	}
	public void PlayCardBackAnim(){
		anim.Play ("TGTAnim");
	}


	IEnumerator ChangeSprite (){
		yield return new WaitForSeconds (0.5f);

		GetComponent<SpriteRenderer> ().sprite = spritecard;
	}


	}

