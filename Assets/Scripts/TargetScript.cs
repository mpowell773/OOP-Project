using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private MainManager mainManagerScript;
    [SerializeField] ParticleSystem explosionParticle;

    [SerializeField] int scorePoint = 1;

    private void Start()
    {
        mainManagerScript = GameObject.Find("MainManager").GetComponent<MainManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            explosionParticle.Play();
            mainManagerScript.score += scorePoint;
            Destroy(gameObject);
        }
    }
}
