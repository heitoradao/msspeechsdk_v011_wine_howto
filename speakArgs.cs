using System;
using Microsoft.Speech.Synthesis;

namespace speakCliArgs {
  class Program {
    static void Main(string[] args) {
      if (args.Length < 1) {
        Console.WriteLine("No CLI args => use default text.");
        args = new string[] { "Hello World!" };
      }
      Console.WriteLine("init synth:");
      var synth = new SpeechSynthesizer();

      // What Microsoft's intro example didn't tell me:
      // The audio destination defaults to the null device,
      // so let's customize that.
      synth.SetOutputToDefaultAudioDevice();

      foreach (var arg in args) {
        Console.WriteLine("speak: " + arg);
        synth.Speak(arg);
      }
      Console.WriteLine("done.");
    }
  }
}
