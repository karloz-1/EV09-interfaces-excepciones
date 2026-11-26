using System;

// MusicPlayer cumple el contrato IMediaPlayer.
public class MusicPlayer : IMediaPlayer
{
    // Campo privado pedido en el reto.
    private string current_track;

    public MusicPlayer()
    {
        current_track = "";
    }

    // Metodo adicional: no esta en la interfaz.
    public void LoadTrack(string track_name)
    {
        current_track = track_name;
        Console.WriteLine($"Pista cargada: {track_name}");
    }

    public void Play()
    {
        Console.WriteLine($"Reproduciendo: {current_track}");
    }

    public void Pause()
    {
        Console.WriteLine($"Pista en pausa: {current_track}");
    }

    public void Stop()
    {
        Console.WriteLine($"Pista detenida: {current_track}");
        current_track = "";
    }

    public string GetCurrentTrack()
    {
        return current_track;
    }
}
