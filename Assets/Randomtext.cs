using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomtext : MonoBehaviour
{
    public Text _textobject;
    public string[] _randomtext;
    
    // Start is called before the first frame update
    void Start()
    {
         
        Randomize();

        
         void Randomize()
        {
            _textobject.text = _randomtext[Random.Range(0, 10)];
        }
    }
}
