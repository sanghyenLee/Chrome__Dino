using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurdle : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverUI;
    // Start is called before the first frame update
    private void Awake()
    {
        GameOverUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject.CompareTag("Hurdle"))
        {
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
        }
    }

    public static void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
