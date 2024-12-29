using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    
    public Texture2D cursorDefault;
    public Texture2D cursorHover;
    
    // Start is called before the first frame update
    void Start()
    {
        //Change cursor icon to default at Start
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseEnter()
    {
        //Cursor icon changed when hovering over button
        Cursor.SetCursor(cursorHover, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseExit()
    {
        //Cursor back to default after exiting button hitbox
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.ForceSoftware);
    }
}
