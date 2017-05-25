using System;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        //Assume these methods do something
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>( () => {
            Console.WriteLine("Creating AllTracks object");
            return new AllTracks();
        });

        public AllTracks GetAllTracks()
        {
            return allSongs.Value; 
        }
    }
}