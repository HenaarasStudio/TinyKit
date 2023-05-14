using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
[AddComponentMenu("TinyKit/Actions")]
public class Actions : MonoBehaviour
{
    void Start()
    {
        this.gameObject.AddComponent<AudioSource>();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlaySound(AudioClip Audio, GameObject Object)
    {
        var component = Object.AddComponent<AudioSource>();
        component.clip = Audio;
        component.Play();
    }

    public void PlayMusic(AudioClip Audio)
    {  
        var component = this.gameObject.GetComponent<AudioSource>();
        component.clip = Audio;
        component.Play();
    }

    public void StopMusic()
    {
        this.gameObject.GetComponent<AudioSource>().Stop();
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public GameObject SpawnGameObject(GameObject Prefab, Vector3 Position)  // Null == Quaternion.identity
    {
        return Instantiate(Prefab, Position, Quaternion.identity);
    }
    
    public void DestroyGameObject(GameObject Object)
    {
        Destroy(Object);
    }
    
    public void ActivateGameObject(GameObject Object)
    {
        Object.SetActive(true);
    }

    public void DeactivateGameObject(GameObject Object)
    {
        Object.SetActive(false);
    }

}
