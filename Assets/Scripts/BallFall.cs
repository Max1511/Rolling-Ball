using UnityEngine;
using UnityEngine.SceneManagement;

public class BallFall : MonoBehaviour
{
    [SerializeField] private float _lowHeight = -6;

    void Update()
    {
        if (transform.position.y <= _lowHeight)
        {
            // restart game
            SceneManager.LoadScene("Level1");
        }
    }
}
