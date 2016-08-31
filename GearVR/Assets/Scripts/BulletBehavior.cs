using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
    float _speed = 100f;
    // Use this for initialization
    public ParticleSystem _bulletSparks; 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
        if (other.gameObject.tag == "Selectable")
        {
            // Explode Asteroid -- kill bullet
            other.GetComponent<ObjectSelectBehavior>().TakeDamage();
            // Play Spark Particle Effect
            Instantiate(_bulletSparks, this.transform.position, Quaternion.identity);
            
            //_bulletSparks.Play();
            Destroy(this.gameObject);

        }


    }
}
