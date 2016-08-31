using UnityEngine;
using System.Collections;

public class TestMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float leftright = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            // move Left
            this.transform.Translate(Vector3.left * Time.deltaTime * 3f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * 4f);
        }
	}
}
