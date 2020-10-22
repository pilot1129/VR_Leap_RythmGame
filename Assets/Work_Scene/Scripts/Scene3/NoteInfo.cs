using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInfo {
    public float x, y, note_length;
    public float timing;

    public NoteInfo Clone()
    {
        NoteInfo temp = new NoteInfo();

        temp.x = this.x;
        temp.y = this.y;
        temp.note_length = this.note_length;
        temp.timing = this.timing;

        return temp;
    }
}
