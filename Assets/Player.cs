using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    // Backpack display status
    private bool panelIsShow = false;

    // Front and back left and right buttons
    public KeyCode ForwardKeyCode = KeyCode.W;
    public KeyCode BackKeyCode = KeyCode.S;
    public KeyCode LeftKeyCode = KeyCode.A;
    public KeyCode RightKeyCode = KeyCode.D;
    // Setting panel buttons
    public KeyCode PanelKeyCode = KeyCode.Escape;
    //setting remote buttons
    public KeyCode Stopkey = KeyCode.T;
    public KeyCode Key1 = KeyCode.Y;
    public KeyCode Key2 = KeyCode.U;
    public KeyCode Key3 = KeyCode.I;
    public KeyCode Key4 = KeyCode.O;
    public KeyCode Key5 = KeyCode.H;
    public KeyCode Key6 = KeyCode.J;
    public KeyCode Key7 = KeyCode.K;
    public KeyCode Key8 = KeyCode.L;
    public KeyCode Key9 = KeyCode.B;
    public KeyCode Key10 = KeyCode.N;
    public KeyCode Key11 = KeyCode.M;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TogglePanel();
        // Set to disable movement when the panel is open
        if (!panelIsShow)
        {
            Move();
        }
        
    }

    /// <summary>
    ///Switch setting panel
    /// </summary>
    private void TogglePanel()
    {
        if (Input.GetKeyDown(PanelKeyCode))
        {
            panelIsShow = !panelIsShow;

            KeyCodeSettingPanel.Instance.SetActive(panelIsShow);
            
        }
        
    }

    /// <summary>
    /// move
    /// </summary>
    private void Move()
    {
        // Move forward
        if (Input.GetKey(ForwardKeyCode))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 15);
        }
        // Move backward
        else if (Input.GetKey(BackKeyCode))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 15);

        }
        // Move to the left
        else if (Input.GetKey(LeftKeyCode))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 15);

        }
        // Move to the right
        else if (Input.GetKey(RightKeyCode))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 15);

        }
        else if (Input.GetKey(Stopkey))
        {
            

        }
        else if (Input.GetKey(Key1))
        {


        }

    }
}
