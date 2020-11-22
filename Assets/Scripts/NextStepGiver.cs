using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextStepGiver : MonoBehaviour
{
    public ExperimentSteps steps;

    public Player player;

    public GameObject stepWindow;
    public Text titleText;
    public Text descriptionText;
    public Text expText;
    public Text goldText;

    public void OpenStepWindow()
    {
        stepWindow.SetActive(true);
        titleText.text = steps.title;
        descriptionText.text = steps.description;
        expText.text = steps.expReward.ToString();
        goldText.text = steps.goldReward.ToString();
    }
}

