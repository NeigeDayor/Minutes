(int, int) ConvertNbMinToHM(int nbMin)
{
	return (nbMin/60, nbMin%60);
}

(int H, int M) = ConvertNbMinToHM(130);

Console.WriteLine($"{H}:{M}");