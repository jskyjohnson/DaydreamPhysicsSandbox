using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Velocity_Button : MonoBehaviour {
    private Text textField;
    private GameObject Controller;

    // Use this for initialization
    void Awake()
    {
        textField = GetComponent<Text>();
    }
    void Start () {
        Controller = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        textField.text = "Mass: " + Controller.GetComponent<controller>().getMass();
	}

    public void MassPlus()
    {
        Controller.GetComponent<controller>().Mass += 1000;
    }
    public void MassMinus()
    {
        Controller.GetComponent<controller>().Mass -= 1000;
    }
}
