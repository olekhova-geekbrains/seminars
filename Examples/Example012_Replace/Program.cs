// Дан текст. Заменить пробелы черточками.

string text = "Что нужно сделать первым делом? князь";

string Replace(string txt, char oldValue, char newValue)
{
  int length = txt.Length;
  string newTxt = String.Empty;
  for (int i = 0; i <= length - 1; i++)
  {
    // if (txt[i] == oldValue) newTxt = $"{newTxt}{newValue}";
    // newTxt = $"{newTxt}{txt[i]}";
    if (txt[i] == oldValue) newTxt = newTxt + $"{newValue}";
    else newTxt = newTxt + $"{txt[i]}";
  }
  return newTxt;
}

string newText = Replace(text,'к','К');
Console.WriteLine(newText);
