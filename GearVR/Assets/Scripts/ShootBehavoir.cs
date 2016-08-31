using UnityEngine;
using System.Collections;

public class ShootBehavoir : MonoBehaviour {

    public GameObject _bulletPrefab;
    public GameObject _spawner;
	
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            // Fire -- Spawn bullet 
            Instantiate(_bulletPrefab, _spawner.transform.position, _spawner.transform.rotation);
        }
	}
}
