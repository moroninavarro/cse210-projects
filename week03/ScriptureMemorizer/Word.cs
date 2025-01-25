using System;
using System.Security.Cryptography.X509Certificates;


public class Word
{
    public string _text;
    public bool _isHidden;


      public Word(string text)
    {
       _text = text;
       _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
        string textSpace = _text.Trim(',', ' ');
        _text = new string('_', textSpace.Length);
     }

    public void Show(){
            _isHidden= false;   
     }

    public bool IsHidden(){
        return _isHidden;
     }

     public string GetDisplayText(){
        return _text;
     }
}