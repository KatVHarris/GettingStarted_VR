using UnityEngine;
using System.Collections;

public class ObjectSelectBehavior : MonoBehaviour {
    Color originalColor;
    public Material originalMaterial;
    public Material selectMaterial;
    public GameObject explodePrefab; 
    Color selectColor;

    int _currunetHitCount = 0;
    int _maxHitCount = 5; 

    void Start()
    {
        originalMaterial = this.gameObject.transform.GetComponent<Renderer>().material;

    }
    public void ChangeColor()
    {
        if(this.transform.GetComponent<Renderer>().material.color != Color.green)
        {
            originalColor = this.transform.GetComponent<Renderer>().material.color;
            this.transform.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void RevertColor()
    {
        if(this.transform.GetComponent<Renderer>().material.color != originalColor)
            this.transform.GetComponent<Renderer>().material.color = originalColor;
    }

    public void ChangeMaterial()
    {
//        originalMaterial = transform.GetComponent<Material>();//.GetComponent<Renderer>().material;
        this.transform.GetComponent<Renderer>().material = selectMaterial;
    }

    public void RevertMaterial()
    {
        this.transform.GetComponent<Renderer>().material = originalMaterial; 
    }

    public void TakeDamage()
    {
        _currunetHitCount++; 
        if(_currunetHitCount == _maxHitCount)
        {
            Explode();
        }
    }
    public void Explode()
    {
        // Instantiate Explode Behavoir 
        Instantiate(explodePrefab, this.transform.position, this.transform.rotation);
        // Destory Original Asteriod
        Destroy(this.gameObject);
        
    }
}
