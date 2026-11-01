using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private string SongName = "Wave to earth -love";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.V))
        {
            PlaySong(SongName);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Stopping song: " + SongName);
        }
    }

    void PlaySong(string songName)
    {
        SongName = songName;
        Debug.Log("Playing song: " + SongName);
    }
}
