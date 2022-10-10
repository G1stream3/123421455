using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeSettingPanel : MonoBehaviour
{
    private Item currItem;
    public static KeyCodeSettingPanel Instance;
    private void Awake()
    {
        Instance = this;
        SetActive(false);
    }

    public void ShowItem(Item item) 
    {
        if (currItem!=null)
        {
            currItem.IsShowMe = false;
        }
       
        currItem = item;
        item.IsShowMe = true;

    }

    /// <summary>
    /// Setting the display status
    /// </summary>
    public void SetActive(bool show)
    {
        gameObject.SetActive(show);
        if (currItem!=null)
        {
            currItem.IsShowMe = false;
            currItem = null;
        }
        
    }

    private void OnGUI()
    {
        if (currItem != null&&Input.anyKeyDown)
        {
            Event e = Event.current;
            // There are events, events are keystrokes, and keystrokes are not Non
            if (e != null && e.isKey && e.keyCode != KeyCode.None)
            {
                KeyCode currentKey = e.keyCode;
                currItem.UpdateKeyCodeText(currentKey.ToString());
                switch (currItem.KeyName)
                {
                    case "Forward":
                        Player.Instance.ForwardKeyCode = currentKey;
                        break;
                    case "Backward":
                        Player.Instance.BackKeyCode = currentKey;
                        break;
                    case "Left":
                        Player.Instance.LeftKeyCode = currentKey;
                        break;
                    case "Right":
                        Player.Instance.RightKeyCode = currentKey;
                        break;
                    case "Setting":
                        Player.Instance.PanelKeyCode = currentKey;
                        break;
                }

            }
        }
    }

    
}
