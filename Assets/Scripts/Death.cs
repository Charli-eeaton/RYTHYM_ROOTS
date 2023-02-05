using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Death : MonoBehaviour
{
    static int hitNote;
    static int missedNote;
    private int selection = 0;
    private bool playerDeathState = false;
    // Start is called before the first frame update
    void Start()
    {
        hitNote = 0;
        missedNote = 0;
    }

    // Update is called once per frame
    void Update()
    {
        killPlayer();
    }

    public static void hitNoteCounter()
    {
        hitNote++;
        UnityEngine.Debug.Log("HitNote");
    }

    public static void missedNoteCounter()
    {
        missedNote++;
        UnityEngine.Debug.Log("MissedNote");
    }

    public void killPlayer()
    {
        switch (selection)
        {
            case 0:
                if (missedNote > 9)
                {
                    //FindObjectOfType<SongManager>().StopSong("Spring_Layer_1");
                    playerDeathState = true;
                    FindObjectOfType<SongManager>().ChangePlayerDeath(playerDeathState);
                    //Destroy(gameObject);
                }
                break;
        }
    }
}
