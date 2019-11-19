using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationForAccess : MonoBehaviour
{
    public int randomNumber1;
    public int randomNumber2;
    public static int expectedResult;
    public static string inputtedResult;

    public void generateRandomCalculation()
    {
        randomNumber1 = Random.Range(11, 51);
        randomNumber2 = Random.Range(0, 11);

        expectedResult = randomNumber1 + randomNumber2;
        Debug.Log(expectedResult);
    }

    public void EnteredResult(int numberPressed)
    {
        inputtedResult = inputtedResult + numberPressed.ToString();
        Debug.Log(inputtedResult);
        if (inputtedResult.Length >= 2)
        {
            Validation();
        }
    }

    public void Validation()
    {
        if (int.Parse(inputtedResult) == expectedResult)
        {
            Debug.Log("Drinnen");
        }
        else
        {
            Debug.Log("Falsche Pin");
        }
    }

}
