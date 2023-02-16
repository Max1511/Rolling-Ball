using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = 7;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = 0;
    }
}
