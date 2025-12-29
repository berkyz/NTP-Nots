namespace ucgen;

class Program
{
    static void Main(string[] args)
    {
        int sy;
        Console.Write("Satır sayısını girin (1-20): ");
        sy = Convert.ToInt32(Console.ReadLine());
        string yildizlar = "";
        for(int i=1; i<=sy; i++){
            for(int j=1; j<sy-1; j++){
                yildizlar = yildizlar + " ";
                }
            for(int k=0; k<sy;k++){
                yildizlar =yildizlar + "*"; 
            }
            if(i!=sy){
                yildizlar = yildizlar+"\n";
            }
        }
        Console.WriteLine(yildizlar);
    }
}
