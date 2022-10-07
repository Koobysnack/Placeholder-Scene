using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    [SerializeField] private int nextLevel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
