using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject target;

    public bool isGameRunning = false;
    public int score = 0;

    [SerializeField] int gameTimer = 5;
    private int targetCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RunTargetGame();

        // Player Input to start game
        if (Input.GetKeyDown(KeyCode.E))
        {
            isGameRunning = true;
            StartCoroutine(GameTimer());
        }
    }

    IEnumerator GameTimer()
    {
        yield return new WaitForSeconds(gameTimer);
        isGameRunning = false;
    }

    private void RunTargetGame()
    {
        targetCount = FindObjectsOfType<TargetScript>().Length;

        if (targetCount <= 0 && isGameRunning)
        {
            Instantiate(target, new Vector3(5, 5, 5), target.transform.rotation);
        }
    }
}
