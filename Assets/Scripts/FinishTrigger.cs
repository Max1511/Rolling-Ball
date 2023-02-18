using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private Canvas _canvasLevelComplete;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Falling Ball"))
        {
            _canvasLevelComplete.gameObject.SetActive(true);
        }
        Debug.Log("Finish");
    }
}
