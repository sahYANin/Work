string[] Fork = { "World", "Sam", "BibaAndBoba", "777","{}","Bs" };
Console.WriteLine("[" + string.Join(",", Fork) + "]");
int m =0;
for(int i=0, n=0;i<Fork.Length;i++){
    n = Fork[i].Length;
    if(n<4){
        Fork[m]=Fork[i];
        m++;
    }
}
for(int i=0; i<m;i++) 
    Console.Write(" "+Fork[i]);
// string For = "World";
// int n;
// n = For.Length;

