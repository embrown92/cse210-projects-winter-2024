namespace Classes
{
    public class Prompts
    {
        //Class variable and list that hold the random prompt and the prompt list
        private string _rPrompt = "";
        private List<string> _promptList; 
        
        
        //Constructor for the Prompt class that receives arguments and assigns values to the class variables.
        public Prompts()
        {
            _promptList = new List<string>();
        }

         //Method to create the prompts list
        public void CreatePromptList()
        {
            _promptList.Add(new string("Why do you want to start a journal?"));
            _promptList.Add(new string("How are you feeling today on a scale of 1-10? What word would you use to describe how you feel right now?"));
            _promptList.Add(new string("What are five things you’re grateful for?"));
            _promptList.Add(new string("What are 10 things that make you feel happy?"));
            _promptList.Add(new string("What are 10 things that make you feel safe and loved?"));
            _promptList.Add(new string("What are five self-care activities that you can do this week?"));
            _promptList.Add(new string("What are 10 things you like about yourself?"));
            _promptList.Add(new string("What are three long-term goals you want to achieve?"));
            _promptList.Add(new string("Write about one of your favourite people."));
            _promptList.Add(new string("What’s an area of your life you’d like to improve and why?"));
            _promptList.Add(new string("What’s your favourite quality in other people?"));
            _promptList.Add(new string("What’s one quality you wish you possessed?"));
            _promptList.Add(new string("What does your dream life look like?"));
            _promptList.Add(new string("What are three small goals that you want to achieve today?"));
            _promptList.Add(new string("How does journaling make you feel?"));
            _promptList.Add(new string("What’s something that triggers you?"));
            _promptList.Add(new string("Write about a problem that you’ve overcome."));
            _promptList.Add(new string("What’s something you’re really proud of?"));
            _promptList.Add(new string("What’s one thing you can do today to make yourself feel better?"));
            _promptList.Add(new string("What was the last reason you smiled?"));
        }

        // Method for getting a random index number to choose a prompt from the list
        public string ShowRandomPrompt()
        {
            CreatePromptList();
            Random _r = new Random();
            int index = _r.Next(_promptList.Count);
            _rPrompt = _promptList[index];
            return _rPrompt;
        }
    }
}
