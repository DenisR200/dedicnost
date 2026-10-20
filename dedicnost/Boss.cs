using Dedicnost;

/// <summary>
/// Představuje silného nepřítele (Bosse) v počítačové hře.
/// Boss má jméno, počet životů a několik fází souboje.
/// Dokáže útočit, zastrašovat protivníka a měnit
/// své chování podle aktuální fáze.
/// </summary>
public class Boss : Postava
{



    /// <summary>
    /// Jméno bosse.
    /// </summary>
    public int Zivoty{get;set}
   

    /// <summary>
    /// Aktuální počet životů bosse.
    /// </summary>
    // SEM DOPLŇ VLASTNOST


    /// <summary>
    /// Aktuální fáze souboje.
    /// Výchozí hodnota je 1.
    /// </summary>
    public int Faze{get;private set;}


    /// <summary>
    /// Vytvoří nového bosse se zadaným jménem
    /// a počtem životů.
    /// </summary>
    /// <param name="jmeno">Jméno bosse.</param>
    /// <param name="id">Jednoznačný identifikátor postavy.</param>
    /// <param name="zivoty">Počáteční počet životů.</param>
    public Boss(string jmeno, int id, int zivoty): base(jmeno, id)
    {
        Zivoty = zivoty;
    }


    /// <summary>
    /// Provede útok podle aktuální fáze bosse.
    /// </summary>
    /// <remarks>
    /// Fáze 1: Boss útočí mečem.
    /// Fáze 2: Boss používá ohnivý útok.
    /// Fáze 3: Boss používá smrtící kouzlo.
    /// </remarks>
    // SEM DOPLŇ METODU


    /// <summary>
    /// Změní fázi bosse podle zbývajících životů.
    /// </summary>
    /// <remarks>
    /// Více než 50 % životů: fáze 1.
    /// 21–50 % životů: fáze 2.
    /// 20 % životů a méně: fáze 3.
    /// </remarks>
    // SEM DOPLŇ METODU


    /// <summary>
    /// Vypíše zastrašující hlášku bosse.
    /// </summary>
    // SEM DOPLŇ METODU


    /// <summary>
    /// Vypočítá poškození útoku podle aktuální fáze.
    /// </summary>
    /// <param name="zakladniPoskozeni">
    /// Základní hodnota poškození útoku.
    /// </param>
    /// <returns>
    /// Celkové poškození po zohlednění fáze bosse.
    /// </returns>
    // SEM DOPLŇ METODU
}