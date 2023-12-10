using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImageCommand : ICommand
{
    private ImageScreen ui;
    private Sprite sprite;

    public ShowImageCommand(ImageScreen ui, Sprite sprite)
    {
        this.ui = ui;
        this.sprite = sprite;   
    }
    public void Execute()
    {
        ui.Show(sprite);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
