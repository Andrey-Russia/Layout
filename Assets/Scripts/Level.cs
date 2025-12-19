using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public TMP_Text Nomber;
    public List<Image> Stars;
    public GameObject Lock;

    public void Init(int numbers, int stars, bool isLocked)
    {
        Nomber.text = numbers.ToString();
        if (isLocked)
        {
            Lock.SetActive(true);
            return;
        }

        for (int i = 0; i < stars; i++)
        {
            Stars[i].gameObject.SetActive(true);

        }
    }
}
