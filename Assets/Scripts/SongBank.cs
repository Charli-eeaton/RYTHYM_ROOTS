using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongBank : MonoBehaviour
{
    public int selection = 0;
    static int hitCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SongManager>().StartSong("Spring");
        /*
        switch (selection)
        {
            case 0:
                FindObjectOfType<SongManager>().StartSong("Spring_Bass");
                FindObjectOfType<SongManager>().StartSong("Spring_Chords");
                FindObjectOfType<SongManager>().StartSong("Spring_Lead");
                FindObjectOfType<SongManager>().StartSong("Spring_Melody");
                break;
            case 1:
                FindObjectOfType<SongManager>().StartSong("Summer_Bass");
                FindObjectOfType<SongManager>().StartSong("Summer_Chords");
                FindObjectOfType<SongManager>().StartSong("Summer_Lead");
                FindObjectOfType<SongManager>().StartSong("Summer_Melody");
                break;
            case 2:
                FindObjectOfType<SongManager>().StartSong("Autumn_Bass");
                FindObjectOfType<SongManager>().StartSong("Autumn_Chords");
                FindObjectOfType<SongManager>().StartSong("Autumn_Lead");
                FindObjectOfType<SongManager>().StartSong("Autumn_Melody");
                break;
            case 3:
                FindObjectOfType<SongManager>().StartSong("Winter_Bass");
                FindObjectOfType<SongManager>().StartSong("Winter_Chords");
                FindObjectOfType<SongManager>().StartSong("Winter_Lead");
                FindObjectOfType<SongManager>().StartSong("Winter_Melody");
                break;

        }
        */

    }

    void Update()
    {
        /*
        if (hitCounter == 0)
        {

        }
        else if (hitCounter == 1)
        {
            FindObjectOfType<SongManager>().changeTrackLayer("Spring_Melody");
        }
        else if (hitCounter == 2)
        {
            FindObjectOfType<SongManager>().changeTrackLayer("Spring_Lead");
        }
        else if (hitCounter == 3)
        {
            FindObjectOfType<SongManager>().changeTrackLayer("Spring_Chords");
        }
        else if (hitCounter == 4)
        {
            FindObjectOfType<SongManager>().changeTrackLayer("Spring_Bass");
        }
        else if (hitCounter > 4)
        {
            hitCounter = 4;
        }
        */
    }
    /*
    public void changeLayer(string clipName)
    {
    
    }
    */

    public static void increaseLane()
    {
        hitCounter--;
    }

    public static void decreaseLane()
    {
        hitCounter++;
    }
}
