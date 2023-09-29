
public class Scripture
{
    private List<Word> _words = new List<Word>();
    Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //initialize new word and add it to Word List
        string[] words = text.Split(' ');
        foreach(string scriptureWord in words)
        {
            Word word = new Word(scriptureWord);
            _words.Add(word);    
        }
    }

    public void HideRandomWords(int numToHide, int randomness)
    {
        int numHidden = 0;
        Random random = new Random();
        int randCheck = random.Next(randomness);

        while(true)
        {
            bool allHidden = true;
            bool hidEnough = false;
            //Iterate through each word and maybe hide, check for all words being hidden
            foreach(Word word in _words)
            {
                int wordRand = random.Next(randomness);

                //only hides word if it isn't already hidden
                if (word.IsVisisble() && wordRand == randCheck)
                {
                    word.Hide();
                    numHidden += 1;
                    if(numHidden >= numToHide)
                    {
                        hidEnough = true;
                        break;
                    }
                }
                if(word.IsVisisble())
                {
                    allHidden = false;
                }

            }
            if(allHidden || hidEnough)
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach(Word word in _words)
        {
           
            displayText += " ";
            displayText += word.GetDisplayText();
           
        }
        return displayText;
    }

    public bool AreAllHidden()
    {
        bool allHidden = true;
        foreach(Word word in _words)
        {
            if (word.IsVisisble())
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}