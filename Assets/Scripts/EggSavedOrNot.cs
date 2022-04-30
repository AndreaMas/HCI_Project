using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EggSavedOrNot : MonoBehaviour
{
    /// <summary>
    /// Egg saved if stays in this trigger box for 1 second.
    /// Egg broken if exits from box.
    /// </summary>
    /// 
    private float timer = 0f;
    private float timerEnd = 1f;


    public AudioSource playEggSuccess;
    public AudioSource playEggCrack1;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Egg"))
        {
            timer += 1 * Time.fixedDeltaTime;
            if (timer > timerEnd)
            {
                Destroy(other.gameObject);
                timer = 0f; // permits only one egg at a time
                playEggSuccess.Play();
                IScoreManager.Instance.IncreaseScore();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Egg"))
        {
            Destroy(other.gameObject);
            timer = 0f; // permits only one egg at a time
            playEggCrack1.Play();
            ILivesManager.Instance.RemoveLife();
        }
    }

}


