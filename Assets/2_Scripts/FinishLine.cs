using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�����߽��ϴ�!");
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
