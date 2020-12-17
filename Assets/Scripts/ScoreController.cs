using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public static ScoreController instance;
    private long _score = 0;
    private int _points;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }

    public void ChangeScore(ref TextMeshProUGUI scoreText)
    {
        scoreText.text = RevertToString();
    }

    private void AddRandomPoint()
    {
        _points = Random.Range(1000000, 100000000);
        _score += _points;        
    }

    private string RevertToString()
    {
        AddRandomPoint();
        var baseString = _score.ToString();
        var ans = "";


        for (int i = 0; i < 3; i++)
        {
            ans += baseString[i];
        }

        ans = PlaceDot(ans, baseString.Length);
        ans += AddLetter(baseString);
        
        return ans;
    }

    private string AddLetter(string inp)
    {
        var length = inp.Length;

        if (length > 12)
        {
            return "T";
        }
        else if (length > 9)
        {
            return "B";
        }
        else if (length > 6)
        {
            return "M";
        }
        else if (length > 3)
        {
            return "K";
        }
        else return null;
    }

    private string PlaceDot(string target, int inp)
    {

        var devided = inp % 3;
        var dot = ".";

        if (devided != 0)
        {
             return target.Insert(devided, dot);
        }
        else
        {
            return target;
        }

    }
}
