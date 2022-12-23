using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public bool isGameRunning = true;
    public int score = 0;

    [SerializeField] int gameTimer = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RunGame();
            Debug.Log("Game started");
        }
    }

    private void RunGame()
    {
         while (isGameRunning)
        {
            Debug.Log("Game running");
            StartCoroutine(GameTimer());
        }
    }

    IEnumerator GameTimer()
    {
        yield return new WaitForSeconds(gameTimer);
        isGameRunning = false;
        Debug.Log("Game done");
    }
}
