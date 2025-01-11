namespace EjemploClases{

    public interface IMedia{
    void play();
}

public class Song : IMedia{
    private long seconds;

    public long Seconds{
        get{ return seconds; }
        set { seconds = value; }
    }

    private string title;

    public string Title{
        get { return title; }
        set { title = value; }
    }

    public void play(){
        Console.WriteLine($"Playing {Title}");
    }


}

class Program{
    static void Main(string[] args){
        Song song = new Song();
        song.Title = "Dark side of soon";
        song.Seconds = 500;
        song.play();
    }
}
}
