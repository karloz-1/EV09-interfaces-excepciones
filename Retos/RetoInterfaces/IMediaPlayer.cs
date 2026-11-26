using System;

// Este es el contrato: cualquier reproductor debe tener estos metodos.
public interface IMediaPlayer
{
    void Play();
    void Pause();
    void Stop();
    string GetCurrentTrack();
}
