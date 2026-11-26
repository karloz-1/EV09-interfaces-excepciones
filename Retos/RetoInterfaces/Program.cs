using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== RETO INTERFACES: IMediaPlayer ===");

        MusicPlayer musicPlayer = new MusicPlayer();

        // La variable IMediaPlayer solo conoce los metodos del contrato.
        IMediaPlayer reproductor = musicPlayer;

        musicPlayer.LoadTrack("Pista 1 - Aprender C#");
        reproductor.Play();
        reproductor.Pause();
        Console.WriteLine($"Pista actual: {reproductor.GetCurrentTrack()}");
        reproductor.Stop();

        musicPlayer.LoadTrack("Pista 2 - Interfaces en C#");
        reproductor.Play();
        reproductor.Pause();
        Console.WriteLine($"Pista actual: {reproductor.GetCurrentTrack()}");
        reproductor.Stop();

        Console.WriteLine("Fin del programa.");
    }
}
