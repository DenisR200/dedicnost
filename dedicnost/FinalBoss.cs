public sealed class FinalBoss :Boss
{
    public int Pancir {get; private set;} = 0;

    public int PocetUtoku {get; private set;} = 0;

    public bool BojovyRezim{get; private set;} = false;

    public FinalBoss(string jmeno, int id, int zivoty, int pancir): base(jmeno, id, zivoty)
    {
        Pancir = pancir;
    }

    
}