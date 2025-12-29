namespace ntp2e
{
    class Varlik
    {
    }

    class Hayvan : Varlik
    {

    }

    class UcanHayvan : Hayvan
    {
    }

    class Surungen : Hayvan
    {
    }

    class YuzenHayvan : Hayvan
    {
    }

    class MemeliHayvan : Hayvan
    {
    }

    // class Balina : MemeliHayvan, YuzenHayvan { }
    sealed class Balina : MemeliHayvan 
    { 
    }

    //class KatilBalina : Balina
    //{

    //}

    class Esya : Varlik
    {
    }

    class Masa : Esya
    {

    }
}
