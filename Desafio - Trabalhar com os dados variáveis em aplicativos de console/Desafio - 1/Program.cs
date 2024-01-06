string pangram = "The quick brown fox jumps over the lazy dog";

// Divide a string em palavras
string[] palavras = pangram.Split(' ');

// Inverte a ordem das palavras
Array.Reverse(palavras);

// Junta as palavras invertidas de volta em uma string
string fraseInvertida = String.Join(' ', palavras);

// Converte a string resultante em um array de caracteres
char[] caracteresInvertidos = fraseInvertida.ToCharArray();

// Inverte a ordem dos caracteres na string final
Array.Reverse(caracteresInvertidos);

Console.WriteLine(caracteresInvertidos); // Saida - ehT kciuq nworb xof spmuj revo eht yzal god