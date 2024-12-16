using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Truco : MonoBehaviour
{
    // The sequence of keys to press
    private readonly KeyCode[] keySequence = { KeyCode.X, KeyCode.I, KeyCode.I };

    // Keeps track of the current position in the sequence
    private int currentIndex = 0;

    void Update()
    {
        // Check if the current key in the sequence is pressed
        if (Input.GetKeyDown(keySequence[currentIndex]))
        {
            currentIndex++;

            // Check if the entire sequence is complete
            if (currentIndex >= keySequence.Length)
            {
                Debug.Log("Sequence 'XII' completed!");
                OnSequenceCompleted();
                ResetSequence();
            }
        }
        else if (Input.anyKeyDown) // If a wrong key is pressed
        {
            ResetSequence();
        }
    }

    // Handles what happens when the sequence is completed
    private void OnSequenceCompleted()
    {
        // Add your logic here for what happens when the sequence is detected
        SceneManager.LoadScene(6);
    }

    // Resets the sequence to start over
    private void ResetSequence()
    {
        currentIndex = 0;
        Debug.Log("Sequence reset.");
    }
}
