using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;
    RaycastHit whatIHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            //Debug.Log("I touched "+ whatIHit.collider.gameObject.name);
            if(Input.GetKeyDown(KeyCode.E)) //upon press E key
            {
                Debug.Log("I picked up a" + whatIHit.collider.gameObject.name);
                if (whatIHit.collider.tag == "Keycards")
                {
                    if (whatIHit.collider.gameObject.GetComponent<KeyCards>().whatKeyAmI == KeyCards.Keycards.redKey)
                    {
                        Destroy (whatIHit.collider.gameObject);
                    }
                }
            }
        }
    }
}
