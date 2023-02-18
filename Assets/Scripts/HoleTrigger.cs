using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Ball"))
            return;
        other.gameObject.layer = LayerMask.NameToLayer("Falling Ball");
        Debug.Log("Falling Ball");
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = LayerMask.NameToLayer("Ball");
        Debug.Log("Default");
    }
}
