using UnityEngine;
using System.Collections;

public class GetLookTarget : MonoBehaviour {

    GameObject previousSeenObject;
    GameObject currSeenObject;


    void Update()
    {
        RaycastHit seen;
        Ray raydirection = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(raydirection, out seen))
        {
            if(previousSeenObject != null && seen.transform.gameObject != previousSeenObject)
            {
                previousSeenObject.gameObject.GetComponent<ObjectSelectBehavior>().RevertMaterial();
            }
            if (seen.transform.tag == "Selectable")
            {
                seen.transform.GetComponent<ObjectSelectBehavior>().ChangeMaterial();
                previousSeenObject = seen.transform.gameObject; 
            }

        }
        Debug.DrawRay(transform.position, transform.forward, Color.yellow, 1);
    }

}



