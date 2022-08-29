using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmAudioSource;
    //[SerializeField] private AudioSource _bgmAudioClip;
    public bool isAudioEnabled = false;
     private static AudioManager _instance;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {
        //_bgmAudioClip = Resources.Load<AudioSource>("BGM/BGM");
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        //randomBgm = Random.Range(1, 4);
        //for (int i = 0; i < randomBgm; i++)
        //{
        //    int amountBgm = i;
        //    AudioSource init = Instantiate(Resources.Load("Prefabs/BGM"+amountBgm, typeof(AudioSource)), transform) as AudioSource;
        //    _bgmAudioClip.Add(init);
            
        //}
        _bgmAudioSource = Resources.LoadAll<AudioSource>("Prefabs").ToList();
    }
    public void PlayBgm()
    {
        //_bgmAudioSource[Random.Range(0, _bgmAudioSource.Count)].Play();

        //_bgmAudioClip = Resources.Load<AudioSource>("BGM" + randomBgm) as AudioSource;
        int randomIndex = Random.Range(0, _bgmAudioSource.Count);
        //_bgmAudioSource[Random.Range(0, _bgmAudioSource.Count)].Play();
        AudioSource randomBgm = Instantiate(_bgmAudioSource[randomIndex], transform);
        randomBgm.Play();
        //_bgmAudioSource.Clear();
        Resources.UnloadUnusedAssets();

        //foreach (AudioSource item in _bgmAudioSource)
        //{
        //    Resources.UnloadAsset(item);
        //}
        

        //for (int i = 0; i < _bgmAudioClip.Count; i++)
        //{
        //    Resources.UnloadUnusedAssets();
        //}
    }
}
