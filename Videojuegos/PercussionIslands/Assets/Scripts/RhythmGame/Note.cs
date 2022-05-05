using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //Instantiate the note and also destroys the note.
    double timeInstantiated;
    public float assignedTime;
    // Start is called before the first frame update
    void Start()
    {
        timeInstantiated = SongManager.GetAudioSourceTime();
    }

    // Update is called once per frame
    void Update()
    {
        double timeSinceInstantiated = SongManager.GetAudioSourceTime() - timeInstantiated;
        float t = (float)(timeSinceInstantiated / (SongManager.Instance.noteTime * 2));

        if (t > 1)
        {
            Destroy(gameObject);
        }
        else{
            transform.localPosition = Vector3.Lerp(Vector3.up * SongManager.Instance.noteSpawnX, Vector3.up * SongManager.Instance.noteDespawnX, t); 
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
