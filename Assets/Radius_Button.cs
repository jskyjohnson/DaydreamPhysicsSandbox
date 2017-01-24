using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Radius_Button : MonoBehaviour {

    private Text textField;
    private GameObject Controller;

    // Use this for initialization
    void Awake()
    {
        textField = GetComponent<Text>();
    }
    void Start()
    {
        Controller = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        textField.text = "Radius: " + Controller.GetComponent<controller>().getRad();
    }

    public void RadPlus()
    {
        Controller.GetComponent<controller>().radius += .5f;
    }
    public void RadMinus()
    {
        Controller.GetComponent<controller>().radius -= .5f;
    }
}
