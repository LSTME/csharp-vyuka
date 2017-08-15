using UnityEngine;

public class MojText : MonoBehaviour {

	public string meno;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<UnityEngine.UI.Text>().text = "Ahoj " + meno + "!";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
