void CreateNewlyFormedArray (string [] array)
{
     string[] ThreeCharactersArray = new string[array.Length];
     for (int i = 0; i < array.Length; i++)
     {      
        if (array[i].Length <= 3)
        {
            ThreeCharactersArray[i] = array[i];
            Console.WriteLine (ThreeCharactersArray[i]); 
        }
     }
        Console.WriteLine (); 
}
string [] array = {"hello", "2", "world", ":-)"};
CreateNewlyFormedArray (array);