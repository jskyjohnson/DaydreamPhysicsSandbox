using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fps_text : MonoBehaviour {

    private const string DISPLAY_TEXT_FORMAT = "{0} msf\n({1} FPS)";
    private const string MSF_FORMAT = "#.#";
    private const float MS_PER_SEC = 1000f;

    private Text textField;
    private float fps = 60;

    public Camera cam;
    private GameObject controller;

    void Awake()
    {
        textField = GetComponent<Text>();
    }

    void Start()
    {

        controller = GameObject.FindGameObjectWithTag("GameController");

    }

    void LateUpdate()
    {
        float deltaTime = Time.unscaledDeltaTime;
        float interp = deltaTime / (0.5f + deltaTime);
        float currentFPS = 1.0f / deltaTime;
        fps = Mathf.Lerp(fps, currentFPS, interp);
        float msf = MS_PER_SEC / fps;
        string k = string.Format(DISPLAY_TEXT_FORMAT,
            msf.ToString(MSF_FORMAT), Mathf.RoundToInt(fps));
        textField.text = controller.gameObject.GetComponent<controller>().getValue() + "\n" + k;

    }
}
