using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    public GameObject center;
    public GameObject Satellite;
    private float G = 6;//6.673e-11f;
    public float velocity;
    public float Mass;
    public float radius;
    // Use this for initialization
    public LineRenderer line;
	void Start () {
        line = GetComponent<LineRenderer>();
        line.SetVertexCount(2);
        line.SetPosition(0, center.transform.position);
        line.SetPosition(1, Satellite.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        velocity = Mathf.Sqrt((G * Mass) / radius);
        Satellite.transform.RotateAround(center.transform.position, Vector3.up, velocity * Time.deltaTime);
        Vector3 desired = (Satellite.transform.position - center.transform.position).normalized * radius + center.transform.position;
        Satellite.transform.position = Vector3.MoveTowards(Satellite.transform.position, desired, Time.deltaTime * velocity);

        line.SetPosition(0, center.transform.position);
        line.SetPosition(1, Satellite.transform.position);

        center.transform.localScale = Vector3.one * Mathf.Sqrt(Mass / 3000);

    }

    public string getValue(){
        string k = "v = sqrt( (G * Mc ) / r)" + "\n";
        k += "v: " + velocity+"\n";
        k += "Mc: " + Mass + "\n";
        k += "r " + radius + "\n";
        return k;
    }
    public string getMass()
    {
        return Mass.ToString();
    }
    public string getRad()
    {
        return radius.ToString();
    }
}
