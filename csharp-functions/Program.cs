
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//1 void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina


//int[] myArray = { 1, 2, 3 };
//void StampaArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine($"[elemento {array[i]}]");
//    }
//}

//StampaArray(myArray);





//2 int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.


//int Quadrato(int numero)
//{
//    int quadrato = numero * numero;

//    return quadrato; 
//}

//int square = Quadrato(4);
//Console.WriteLine(square);





//3 int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

//Convert.ToInt32(Console.ReadLine())

//int[] myArray = { 1, 2, 3 };

//Console.WriteLine($"Normal array:");

//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.WriteLine(myArray[i]);
//}

////function
//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] squareArray = new int[array.Length]; 

//    for (int i = 0; i < array.Length; i++)
//    {
//        int quadrato = array[i] * array[i];

//        squareArray[i] = quadrato;
//    }

//    return squareArray;
//}

//int[] newArray = ElevaArrayAlQuadrato(myArray);

//Console.WriteLine($"Square array:");

//for (int i = 0; i < newArray.Length; i++)
//{
//    Console.WriteLine(newArray[i]);
//}





//4 int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i]; 
    }

    return sum;
}

int[] myArray = { 1, 2, 3 }; 
Console.WriteLine(sommaElementiArray(myArray));










//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati