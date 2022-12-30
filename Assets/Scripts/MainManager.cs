using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public bool isGameRunning;
    public int score = 0;

    [SerializeField] int gameTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGameRunning = true;
        RunGame();
        Debug.Log("Game started");   
    }

    private void RunGame()
    {
         if (isGameRunning)
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
