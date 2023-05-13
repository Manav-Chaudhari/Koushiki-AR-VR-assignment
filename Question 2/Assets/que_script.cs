using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class que_script : MonoBehaviour
{

    public TMP_Text que_text;
    public int que_num;
    public string[] ques = { "red pillow?", "blue handkerchief?", "green ball?"};
    // Start is called before the first frame update
    void Start()
    {
        que_num = 0;
        que_text.text = "What is the shape of the " + ques[que_num];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQue(int option)
    {         
       if (option == que_num)
        {
            if (que_num == 2)
            {
                que_text.text = "All questions done.";
            }
            else
            {
                que_text.text = "What is the shape of the " + ques[++que_num];
            }
        }
    }
}
