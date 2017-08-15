using UnityEngine;

public class MojText : MonoBehaviour {

	public string meno;
	public float vyska;
	public int vek;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<UnityEngine.UI.Text>().text = "Ahoj " + meno + "! Mám " + vek.ToString() + " rokov a výšku " + vyska.ToString() + " cm.";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
