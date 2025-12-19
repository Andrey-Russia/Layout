using Unity.VisualScripting;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public Button button;
    public Button button1;
    public GameObject panel;

    void Start()
    {
        button.onClick.AddListener(HideButtonAndShowPanel);
        button1.onClick.AddListener(HidePanel);
        panel.SetActive(false);
    }

    void HideButtonAndShowPanel()
    {
        button.gameObject.SetActive(false); 
        panel.SetActive(true); 
    }

    void HidePanel()
    {
        panel.SetActive(false);
        button.gameObject.SetActive(true);
    }
}
