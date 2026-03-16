(int, int) ConvertNbMinToHM(int nbMin){
	return (nbMin/60, nbMin%60);
}

int nbMin;
Console.WriteLine("Saisir le nombre de minutes : ");
nbMin = Convert.ToInt32(Console.ReadLine());
(int H, int M) = ConvertNbMinToHM(nbMin);
Console.WriteLine($"{H}:{M}");
