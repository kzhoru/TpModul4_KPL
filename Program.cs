
public class KodePos
{
    private string[] kelurahan =
    {
          "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijagra",
         "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"

     };
    private int[] kodePos =
    {
         40266, 40287, 40267, 40256, 40287,
         40286, 40286, 40286, 40272, 40274, 40273
     };

    public int? GetKodePos(String kelurahan)
    {
        for (int i = 0; i < this.kelurahan.Length; i++)
        {
            if (this.kelurahan[i] == kelurahan)
            {
                return this.kodePos[i];
            }
        }
        return null;
    }
}

public class DoorMachine
{
    private enum State { TERKUNCI, TERBUKA };
    private State currentState;

    public DoorMachine()
    {
        this.currentState = State.TERKUNCI;
    }

    public void BukaPintu()
    {
        if (currentState == State.TERKUNCI)
        {
            this.currentState = State.TERBUKA;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.TERBUKA)
        {
            this.currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine(kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine(kodePos.GetKodePos("Mengger"));

        DoorMachine door = new DoorMachine();

        door.BukaPintu();
        door.BukaPintu();
        door.KunciPintu();
        door.KunciPintu();


    }
}

