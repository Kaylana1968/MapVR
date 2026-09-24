using UnityEngine;

public class Scanner : MonoBehaviour
{
    [SerializeField]
    Transform RayOrigin;
    [SerializeField]
    float RayMaxDistance;

    public void Scan()
    {
        if (!Physics.Raycast(RayOrigin.position, transform.forward, out RaycastHit hit, RayMaxDistance))
        {
            return;

        }

        if (hit.transform.TryGetComponent(out ScanableObject obj))
        {
            obj.OnScan();
        }
    }
}
