using UnityEngine;
using UnityEngine.SceneManagement;

public class BallFall : MonoBehaviour
{
    [SerializeField] private float _lowHeight;

    private void Update()
    {
        if (transform.position.y <= _lowHeight)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
