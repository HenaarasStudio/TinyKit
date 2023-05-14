using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("TinyKit/Storage")]
public class Storage : MonoBehaviour
{
    public string GetString(string Key) 
    {
        return PlayerPrefs.GetString(Key);
    }
    public bool SetString(string Key, string Value)  
    {
        PlayerPrefs.SetString(Key, Value);
        PlayerPrefs.Save();
        return true;
    }

    public int GetInt(string Key)
    {
        return PlayerPrefs.GetInt(Key);
    }

    public bool SetInt(string Key, int Value)
    {
        PlayerPrefs.SetInt(Key, Value);
        PlayerPrefs.Save();
        return true;
    }

    public float GetFloat(string Key)
    {
        return PlayerPrefs.GetFloat(Key);
    }

    public bool SetFloat(string Key, float Value)
    {
        PlayerPrefs.SetFloat(Key, Value);
        PlayerPrefs.Save();
        return true;
    }
}
