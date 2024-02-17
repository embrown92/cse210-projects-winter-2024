using System;

public class BreathingActivity : Activity
{

    // Constructor
   public BreathingActivity(string _activityName, string _startingMessage, string _activityDescription, string _endingMessage) : base(_activityName, _startingMessage, _activityDescription, _endingMessage) 
   {

   }

    // Do activity method
    public void DoActivity() {
        StartActivity();
        int remainder = _duration % 8;
        int cycles = (_duration - remainder) / 8;
        if (remainder != 0) {
            int initialBreathIn = remainder / 2;
            int initialBreathOut = remainder - initialBreathIn;
            BreathIn(initialBreathIn);
            BreathOut(initialBreathOut);
            Console.WriteLine();
        }
        for (int i = 0; i < cycles; i ++) {
            BreathIn(5);
            BreathOut(5);
            Console.WriteLine();
        }
        EndActivity();
    }

    // Breath in method
     private void BreathIn(int breathTime) {
        Console.Write("Breath in... ");
        CountdownTimer(breathTime);
    }    

    // Breat out method
    private void BreathOut(int breathTime) {
        Console.Write("Breath Out... ");
        CountdownTimer(breathTime);
    }
}