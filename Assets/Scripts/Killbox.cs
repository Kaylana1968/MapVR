using UnityEngine;

public class Killbox : MonoBehaviour
{
    void OnTriggerExit(Collider collider)
    {
        collider.transform.position = 2f * Vector3.up;
        if (collider.attachedRigidbody != null)
        {
            collider.attachedRigidbody.linearVelocity = Vector3.zero;
        }
    }
}
