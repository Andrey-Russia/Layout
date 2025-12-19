using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private TMP_Text _nomber;
    [SerializeField] private List<Image> _stars;
    [SerializeField] private GameObject _lock;

    public void Init(int numbers, int stars, bool isLocked)
    {
        _nomber.text = numbers.ToString();
        if (isLocked)
        {
            _lock.SetActive(true);
            return;
        }

        for (int i = 0; i < stars; i++)
        {
            _stars[i].gameObject.SetActive(true);

        }
    }
}
