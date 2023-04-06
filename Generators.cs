namespace MultiGenerators
{
    public class PWAutoGenerator : IGenerator
    {
        /* Generates a random sequence 
           (numbers, symbols, letters) */

        public string Generate(int length)
        {
            string pw = string.Empty;
            return ZRand.GetMixedRandomPassword(length);
        }
    }
    public class PWCustomGenerator : IGenerator
    {
        private bool UseDigits;
        private bool UseSymbols;
        private bool UseLetters;

        private int EnabledSettingsCount;
        private bool EditSetting(string text)
        {
            ZConsole.WriteLine(text);
            string q = ZConsole.ReadLine();
            if (GenerationData.answers.Contains(q))
            {
                EnabledSettingsCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetAllSettings()
        {
            UseSymbols =  EditSetting("Use symbols?");
            UseDigits = EditSetting("Use digits?");
            UseLetters = EditSetting("Use letters?");
        }

        public string Generate(int length)
        {
            SetAllSettings();
            string pw = string.Empty;

            int GENmax = EnabledSettingsCount;
            
            if(GENmax == 3)
            {
                pw = ZRand.GetMixedRandomPassword(length);
            }
            else if(GENmax == 2)
            {
                for(int i = 0; i < length; i++)
                {
                    int y = ZRand.GetLimitedRandom(0, 2);
                    if (UseSymbols == false)
                        if (y == 1)
                            pw += ZRand.GetRandomDigit();
                        else
                            pw += ZRand.GetRandomLetter();
                    else if (UseDigits == false)
                        if (y == 1)
                            pw += ZRand.GetRandomSymbol();
                        else
                            pw += ZRand.GetRandomLetter();
                    else if (UseLetters == false)
                        if (y == 1)
                            pw += ZRand.GetRandomDigit();
                        else
                            pw += ZRand.GetRandomSymbol();
                }
            }
            else
            {
                for(int i = 0; i < length; i++)
                {
                    if (UseSymbols == true)
                        pw += ZRand.GetRandomSymbol();
                    else if(UseDigits == true)
                        pw += ZRand.GetRandomDigit();
                    else if(UseLetters == true)
                        pw += ZRand.GetRandomLetter();
                }
            }

            return pw;
            
        }
    }
}
