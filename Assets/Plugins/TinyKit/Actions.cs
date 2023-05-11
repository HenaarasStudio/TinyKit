using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
[AddComponentMenu("TinyKit/Actions")]
public class Actions : MonoBehaviour
{
    private string GameDataFilePath;
    void Awake()
    {
        GameDataFilePath = Application.persistentDataPath + "/gamedata.json";
    }
    //void Start() { }
    //void Update() { }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void AudioPlay(GameObject audioGameObject = null)  // Null == This Game Object
    {
        (audioGameObject != null ? audioGameObject : gameObject).GetComponent<AudioSource>().Play();
    }

    public void AudioStop(GameObject audioGameObject = null)  // Null == This Game Object
    {
        (audioGameObject != null ? audioGameObject : gameObject).GetComponent<AudioSource>().Stop();
    }

    public Dictionary<int, object> DataLoad()  // Null == File Not Found
    {
        return File.Exists(GameDataFilePath) ? JsonUtility.FromJson<Dictionary<int, object>>(File.ReadAllText(GameDataFilePath)) : null;
    }

    public bool DataStore(Dictionary<int, object> gameData)  // False == Store Failed
    {
        try
        {
            File.WriteAllText(GameDataFilePath, JsonUtility.ToJson(gameData));
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public void ChapterLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ChapterRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public GameObject SpownGameObject(GameObject prefab, Vector3 position, Quaternion? rotation = null)  // Null == Quaternion.identity
    {
        return Instantiate(prefab, position, rotation != null ? rotation.Value : Quaternion.identity);
    }
    
    public void DestroyGameObject(GameObject gameObject)
    {
        Destroy(gameObject);
    }
    
    public void ActivateGameObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void DeactivateGameObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void MoneyIncrease(GameObject gameManagerObject, string gameManagerScriptName, int difference)
    {
        Component component = gameManagerObject.GetComponent(gameManagerScriptName);
        PropertyInfo moneyProperty = component.GetType().GetProperty("Money", typeof(int));
        moneyProperty.SetValue(component, (int)moneyProperty.GetValue(component) + difference);
    }

    public void Moneydecrease(GameObject gameManagerObject, string gameManagerScriptName, int difference)
    {
        Component component = gameManagerObject.GetComponent(gameManagerScriptName);
        PropertyInfo moneyProperty = component.GetType().GetProperty("Money", typeof(int));
        moneyProperty.SetValue(component, (int)moneyProperty.GetValue(component) - difference);
    }

    public void LifeIncrease(GameObject gameManagerObject, string gameManagerScriptName, int difference)
    {
        Component component = gameManagerObject.GetComponent(gameManagerScriptName);
        PropertyInfo moneyProperty = component.GetType().GetProperty("Life", typeof(int));
        moneyProperty.SetValue(component, (int)moneyProperty.GetValue(component) + difference);
    }

    public void Lifedecrease(GameObject gameManagerObject, string gameManagerScriptName, int difference)
    {
        Component component = gameManagerObject.GetComponent(gameManagerScriptName);
        PropertyInfo moneyProperty = component.GetType().GetProperty("Life", typeof(int));
        moneyProperty.SetValue(component, (int)moneyProperty.GetValue(component) - difference);
    }
}
