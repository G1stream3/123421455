using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour,IPointerClickHandler
{

    private Image image;
    private Text nameText;
    private Text keyCodeText;

    // Key Name
    public string KeyName;
    private bool isShowMe;

    public bool IsShowMe { get => isShowMe;
        set {
            isShowMe = value;
            if (isShowMe)
            {
                image.color = Color.yellow;
            }
            else
            {
                image.color = Color.blue;
            }
        }
    
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        KeyCodeSettingPanel.Instance.ShowItem(this);
    }

    void Start()
    {
        image = GetComponent<Image>();
        nameText = transform.Find("Name").GetComponent<Text>();
        KeyName = nameText.text;
        keyCodeText = transform.Find("KeyCode").GetComponent<Text>();
    }

    /// <summary>
    /// Update keystroke script
    /// </summary>
    public void UpdateKeyCodeText(string text)
    {
        keyCodeText.text = text;
    }
}
