public sealed class FinalBoss :Boss
{
    public int Pancir {get; private set;} = 0;

    public int PocetUtoku {get; private set;} = 0;

    public bool BojovyRezim{get; private set;} = false;

    public FinalBoss(string jmeno, int id, int zivoty, int pancir): base(jmeno, id, zivoty)
    {
        Pancir = pancir;
    }

    /// <summary>
    /// Provede útok podle aktuální fáze bosse.
    /// </summary>
    /// <remarks>
    /// Fáze 1: Boss útočí mečem.
    /// Fáze 2: Boss používá ohnivý útok.
    /// Fáze 3: Boss používá smrtící kouzlo.
    /// </remarks>
    public override void Utoc()
    {
        PocetUtoku++;

        switch (Faze)
        {

            case 1:
                Console.WriteLine("Útočí mechanickou pěstí");
            break;

            case 2:
                Console.WriteLine("Útočí plazmovou puškou.");
            break;
            case 3:
                Console.WriteLine("Aktivuje smrtící laser...");
            break;

            default:
                base.Utoc();
            break;
        }
    }

    public void PrepniBojovyRezim()
    {
        BojovyRezim = !BojovyRezim;

        Console.WriteLine(BojovyRezim ? "Bojový režim aktivován." : "Bojový režim deaktivován.");
    }

    public int VypocitejPOskozeni(int zakladniPoskozeni)
    {
        if (zakladniPoskozeni <0)
            throw new ArgumentOutOfRangeException(nameof(zakladniPoskozeni));

            int poskozeni = zakladniPoskozeni * Faze;   

            if (BojovyRezim)
        {
                poskozeni *= 2;
        }

        return poskozeni;

    }

    public int VypocitejObranu(int poskozeni)
    {
        if (poskozeni < 0)
            throw new ArgumentOutOfRangeException(nameof(poskozeni));

        return poskozeni * (100 - Pancir) / 100;
    }

    public void VypisInformace()
    {
        Console.WriteLine($"Jméno: {Jmeno}");
        Console.WriteLine($"Životy: {Zivoty}");
        Console.WriteLine($"Fáze: {Faze}");
        Console.WriteLine($"Pancíř: {Pancir}");
        Console.WriteLine($"Počet útoků: {PocetUtoku}");
        Console.WriteLine($"Bojový režim: {BojovyRezim}");
    }
}