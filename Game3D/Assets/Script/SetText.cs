using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    public Text text;
    int randomNumber;

    void Start()
    {
        UpdateRandomNumberAndText(); // Initialize the randomNumber and text.text
        StartCoroutine(RandomizeEvery30Seconds()); // Start the coroutine
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Update");
            UpdateRandomNumberAndText(); // Update the randomNumber and text.text on Q key press
        }
    }

    void UpdateRandomNumberAndText()
    {
        randomNumber = Random.Range(1, 6);
        UpdateTextBasedOnRandomNumber();
        Debug.Log(randomNumber);
    }

    void UpdateTextBasedOnRandomNumber()
    {
        if (randomNumber == 1)
        {
            text.text = "QUESTION: I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. I am invisible, yet you can feel my presence. I am essential for life, but too much of me can be deadly. What am I?";
        }
        else if (randomNumber == 2)
        {
            text.text = "What is the next number in this sequence: 1, 11, 21, 1211, 111221, …?";
        }
        else if (randomNumber == 3)
        {
            text.text = "What is the smallest number that is evenly divisible by 1, 2, 3, 4, 5, 6, 7, 8, 9 and 10?";
        }
        else if (randomNumber == 4)
        {
            text.text = "A digital clock displays the time in hours and minutes. When you reverse the positions of the digits, the new time is four times less than the original time. What time is it?";
        }
        else if (randomNumber == 5)
        {
            text.text = "What letter is next in this sequence? J, F, M, A, M, J, J, A, S, O, N, ____";
        }
    }

    IEnumerator RandomizeEvery30Seconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f); // Wait for 30 seconds
            UpdateRandomNumberAndText(); // Update the randomNumber and text.text
        }
    }
}
