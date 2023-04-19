class Boxeador
{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    
    public Boxeador(string nom, string pais, int peso, int pG, int vP)
    {
        Nombre=nom;
        Pais=pais;
        Peso=peso;
        PotenciaGolpes=pG;
        VelocidadPiernas=vP;
    }
    public double ObtenerSkill(int pG,int vP,int random)
    {
        double skill= 0.6*vP + 0.8*pG + random;
        return skill;
    }
}