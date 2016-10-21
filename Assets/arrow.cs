using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class arrow : MonoBehaviour {

	public Image option1;
	public Image option2;
	public Image option3;
	public Sprite Arrow;
	public enum States {NoChoice, Option1, Option2, Option3, Option1B, Option2B, Option1C, Option2C};
	public int optionSelection = 1;
	public Text stuff;
	private States myState;



	// Use this for initialization
	void Start () {
		myState = States.NoChoice;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			optionSelection--;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			optionSelection++;
		}
			

		print (myState);
		if (myState == States.NoChoice) {
			state_NoChoice ();
		} else if (myState == States.Option1) {
			state_Option1 ();
		} else if (myState == States.Option2) {
			state_Option2 ();
		} else if (myState == States.Option3) {
			state_Option3 ();
		} else if (myState == States.Option1B) {
			state_Option1B ();
		} else if (myState == States.Option2B) {
			state_Option2B ();
		} else if (myState == States.Option1C) {
			state_Option1C ();
		} else if (myState == States.Option2C) {
			state_Option2C ();
		}



}
	void state_NoChoice () {
		stuff.text = "Pick an option.\n\n" + "Option 1\n\n" + "Option 2\n\n" + "Option 3"; 

		if (optionSelection > 3) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 3;
		}

		if (optionSelection == 1){
			option1.sprite = Arrow;
			option2.sprite = null;
			option3.sprite = null;
		}

		if (optionSelection == 2){
			option1.sprite = null;
			option2.sprite = Arrow;
			option3.sprite = null;
		}

		if (optionSelection == 3){
			option1.sprite = null;
			option2.sprite = null;
			option3.sprite = Arrow;
		}

		if (myState == States.NoChoice && optionSelection == 1 && Input.GetKey (KeyCode.Space)) {
			myState = States.Option1;
		}

		else if (myState == States.NoChoice && optionSelection == 2 && Input.GetKey (KeyCode.Space)) {
			myState = States.Option2;
		}

		else if (optionSelection == 3 && Input.GetKey (KeyCode.Space)) {
			myState = States.Option3;
		}
	}

	void state_Option1 () {
		stuff.text = "You picked option 1. Pick another option.\n\n" + "Option 1B\n\n" + "Option 2B";

		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1) {
			option1.sprite = Arrow;
			option2.sprite = null;
		}

		if (optionSelection == 2) {
			option1.sprite = null;
			option2.sprite = Arrow;
		}

		if (myState == States.Option1 && optionSelection == 1 && Input.GetKey (KeyCode.LeftArrow)) {
			myState = States.Option1B;
		}

		else if (myState == States.Option1 && optionSelection == 2 && Input.GetKey (KeyCode.Space)) {
			myState = States.Option2B;
		}
	}

	void state_Option2 () {
		stuff.text = "You picked option 2. Pick another option.\n\n" + "Option 1C\n\n" + "Option 2C";
	}

	void state_Option3 () {
		stuff.text = "You picked option 3.";
	}

	void state_Option1B () {
		stuff.text = "You picked Option 1B.";
	}

	void state_Option2B () {
		stuff.text = "You picked Option 2B.";
	}

	void state_Option1C () {
		stuff.text = "You picked Option 1C.";
	}

	void state_Option2C () {
		stuff.text = "You picked Option 2C.";
	}
}
