using UnityEngine;

public class Hra : MonoBehaviour {

	public UnityEngine.UI.Text text;
	public UnityEngine.UI.InputField inputField;
	public UnityEngine.UI.Button button;

	private int Cislo;

	// Use this for initialization
	void Start () {
		NovaHra();
	}

	public void Testuj()
	{
		var hadaneCislo = 0;

		if (!int.TryParse(inputField.text, out hadaneCislo))
		{
			text.text = "Treba zadať číslo!";
			return;
		}

		if (hadaneCislo == Cislo)
		{
			text.text = "Správne! Môžete hádať ďalšie číslo.";
			NovaHra();
		} else if (hadaneCislo < Cislo)
		{
			text.text = "Nie, to číslo je väčšie!";
		} else
		{
			text.text = "Nie, to číslo je menšie!";
		}
	}

	void NovaHra()
	{
		var randomizer = new System.Random();
		Cislo = randomizer.Next(1, 1000);
	}
}
