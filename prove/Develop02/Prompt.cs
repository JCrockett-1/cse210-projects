using System.Transactions;

public class Prompt
{
    private List<String> _prompts = new List<String>
    {
        "Who was the most interesting person I interacted with today?",  
        "What was the best part of my day?",  
        "How did I see the hand of the Lord in my life today?",  
        "What was the strongest emotion I felt today?",  
        "If I had one thing I could do over today, what would it be?",  
        "What is one lesson I gained from today's experiences?",  
        "What is something unexpected that happened today?",  
        "How did I challenge myself or grow today?",  
        "What is one thing I did today that made me feel fulfilled?",  
        "Who did I appreciate today, and why?",  
        "What is one act of service or kindness I gave today?",  
        "What was the most peaceful moment of my day?",  
        "What was a situation where I had to exercise patience today?",  
        "What inspired me or motivated me today?",  
        "What is something I want to carry forward into tomorrow?",  
        "How did I handle stress or frustration today?",  
        "What was a meaningful conversation I had today?",  
        "What is one thing I saw today that made me smile?",  
        "How did I show love or gratitude to someone today?",  
        "What is something I want to let go of from today?"  
    };

    private List<String> _refillPrompts = new List<String>
    {
        "Who was the most interesting person I interacted with today?",  
        "What was the best part of my day?",  
        "How did I see the hand of the Lord in my life today?",  
        "What was the strongest emotion I felt today?",  
        "If I had one thing I could do over today, what would it be?",  
        "What is one lesson I gained from today's experiences?",  
        "What is something unexpected that happened today?",  
        "How did I challenge myself or grow today?",  
        "What is one thing I did today that made me feel fulfilled?",  
        "Who did I appreciate today, and why?",  
        "What is one act of service or kindness I gave today?",  
        "What was the most peaceful moment of my day?",  
        "What was a situation where I had to exercise patience today?",  
        "What inspired me or motivated me today?",  
        "What is something I want to carry forward into tomorrow?",  
        "How did I handle stress or frustration today?",  
        "What was a meaningful conversation I had today?",  
        "What is one thing I saw today that made me smile?",  
        "How did I show love or gratitude to someone today?",  
        "What is something I want to let go of from today?"  
    };

 public Prompt()
    {
       
    }

    public string PromptDisplay()
    {
        if (_prompts.Count() == 0)
        {
            _prompts.AddRange(_refillPrompts);   
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string current_prompt = _prompts[index];
        _prompts.RemoveAt(index);

        return current_prompt;   
    }

    public void RandomSelect()
    {
    
    }
    
}