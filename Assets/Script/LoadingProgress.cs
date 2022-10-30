using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image image;

    private void Start()
    {
        StartCoroutine(Progress());
    }

    IEnumerator Progress()
    {
        image.fillAmount = 0;

        yield return new WaitForSeconds(1);

        var asynOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while(asynOp.isDone == false)
        {
            image.fillAmount = asynOp.progress;

            yield return null;
        }
    }
}
