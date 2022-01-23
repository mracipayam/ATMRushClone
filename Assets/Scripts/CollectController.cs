using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collect")){
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectController>());
            other.gameObject.AddComponent<CollectController>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;
            other.gameObject.tag = "Collected";
        }
    }
}
