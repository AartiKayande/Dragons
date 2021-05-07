
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5.74)
            SceneManager.LoadScene(0);

        if (transform.position.y < -5.42)
            SceneManager.LoadScene(0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}
