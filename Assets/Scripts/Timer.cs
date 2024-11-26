using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText; 

    enum TimerType {Countdown, Stopwatch}
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timerToDisplay = 60.0f;

    private bool _isRunning;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    public void OnEnable()
    {

        EventManager.TimerStart += EventManagerOnTimerStart;
        EventManager.TimerStop += EventManagerOnTimerStop;
        EventManager.TimerUpdate += EventManagerOnTimerUpdate;
    }

    public void OnDisable()
    {

        EventManager.TimerStart -= EventManagerOnTimerStart;
        EventManager.TimerStop -= EventManagerOnTimerStop;
        EventManager.TimerUpdate -= EventManagerOnTimerUpdate;
    }

    private void EventManagerOnTimerStart() => _isRunning = true;

    private void EventManagerOnTimerStop() => _isRunning = false;


    private void EventManagerOnTimerUpdate(float value) => timerToDisplay += value;

    private void Update()
    {
        if (!_isRunning) return;
        if (timerType == TimerType.Countdown && timerToDisplay <0.0f) {
            
            EventManager.OnTimerStop();
            return;
        }
        timerToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timerToDisplay);
        _timerText.text = timeSpan.ToString(format:@"mm\:ss");
    }



  
}
