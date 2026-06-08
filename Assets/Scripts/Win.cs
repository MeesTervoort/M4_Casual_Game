using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
