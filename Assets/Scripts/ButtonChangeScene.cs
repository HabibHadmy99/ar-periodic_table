using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class ButtonChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progressBar;
    private float _target;

    void Start() {
        //_target = 0;
       // _progressBar.fillAmount = 0;
    }
    public void btn_change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public async void loadingScene(string loadSceneName)
    {
        _target = 0;
        _progressBar.fillAmount = 0;
        var scene = SceneManager.LoadSceneAsync(loadSceneName);
        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do{
            await Task.Delay(2000);
            _target = scene.progress;

        } while (scene.progress < 0.9f);

        scene.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);
    }

    void Update() {
        _progressBar.fillAmount = Mathf.MoveTowards(_progressBar.fillAmount,_target, 10 * Time.deltaTime);
    }

    
}
